using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;

namespace BiTecnlogy_Frotas
{
    public partial class Viagem : Form
    {
        public Viagem()
        {
            InitializeComponent();
        }


        private void Viagem_Load(object sender, EventArgs e)
        {
            carregarDadosNoGrid();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodViagem.Text = "";
            txtCodCarro.Text = "";
            txtCodUsuario.Text = "";
            txtKmInicial.Text = "";
            txtHoraSaida.Text = "";
            txtKmFinal.Text = "";
            txtHoraEntrada.Text = "";
            txtKmTotal.Text = "";

            txtCodEndereço.Text = "";
            txtLogradouro.Text = "";
            txtBairro.Text = "";
            txtComplemento.Text = "";
            txtNumero.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO endereco(Logradouro,Bairro,Complemento,Numero,Cidade,Estado) VALUES ('" + txtLogradouro.Text + "','" + txtBairro.Text + "','" + txtComplemento.Text + "','" + txtNumero.Text + "','" + txtCidade.Text + "','" + txtEstado.Text + "')";

            Conexao.ExecutarSql(sql);

            sql = "INSERT INTO Viagem(CodUsuario,CodCarro,CodEndereco,HoraSaida,HoraEntrada,Descricao,CarroKmInicial,CarroKmFinal,CarroKmTotalViagem) " +
                "VALUES (" + txtCodUsuario.Text + "," +
                txtCodCarro.Text + "," +
                txtCodEndereço.Text + "," +
                txtHoraSaida.Text + "," +
                txtHoraEntrada.Text + ",'" +
                txtDescricao.Text + "'," +
                txtKmInicial.Text + "," +
                txtKmFinal.Text + "," +
                txtKmTotal.Text + ")";

            Conexao.ExecutarSql(sql);

            carregarDadosNoGrid();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Viagem SET " +
                "CodUsuario = '" + txtCodUsuario.Text + "', " +
                "CodCarro = " + txtCodCarro.Text + ", " +
                "CodEndereco = " + txtCodEndereço.Text + ", " +
                "HoraSaida = " + txtHoraSaida.Text + ", " +
                "HoraEntrada = " + txtHoraEntrada.Text + ", " +
                "Descricao = '" + txtDescricao.Text + "', " +
                "CarroKmInicial = " + txtKmInicial.Text + ", " +
                "CarroKmFinal = '" + txtKmFinal.Text + ", " +
                "CarroKmTotalViagem = " + txtKmTotal.Text + 
                " WHERE CodViagem = " + txtCodViagem.Text;

            Conexao.ExecutarSql(sql);


            sql = "UPDATE endereco SET " +
                "Logradouro = '" + txtLogradouro.Text + "', " +
                "Bairro = '" + txtBairro.Text + "', " +
                "Complemento = '" + txtComplemento.Text + "', " +
                "Numero = '" + txtNumero.Text + "', " +
                "Cidade = '" + txtCidade.Text + "', " +
                "Estado = '" + txtEstado.Text + "'" +
                " WHERE CodEndereco = " + txtCodEndereço.Text;

            Conexao.ExecutarSql(sql);

            carregarDadosNoGrid();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE Viagem where CodViagem = " + txtCodViagem.Text;

            Conexao.ExecutarSql(sql);



            sql = "DELETE endereco where CodEndereco = " + txtCodEndereço.Text;

            Conexao.ExecutarSql(sql);

            carregarDadosNoGrid();
        }

        private void dgViagem_SelectionChanged(object sender, EventArgs e)
        {
            atualizarCamposTela();
        }




        private void carregarDadosNoGrid()
        {
            dgViagem.DataSource = Conexao.ObterDados("select * from Viagem as v inner join endereco as e ON  v.CodEndereco = e.CodEndereco");

            formatarGridEstados();
        }


        private void atualizarCamposTela()
        {
            txtCodViagem.Text = dgViagem[0, dgViagem.CurrentRow.Index].Value.ToString(); ;
            txtCodUsuario.Text = dgViagem[1, dgViagem.CurrentRow.Index].Value.ToString();
            txtCodCarro.Text = dgViagem[2, dgViagem.CurrentRow.Index].Value.ToString(); ;
            txtHoraSaida.Text = dgViagem[4, dgViagem.CurrentRow.Index].Value.ToString();
            txtHoraEntrada.Text = dgViagem[5, dgViagem.CurrentRow.Index].Value.ToString();
            txtDescricao.Text = dgViagem[6, dgViagem.CurrentRow.Index].Value.ToString(); ;
            txtKmInicial.Text = dgViagem[7, dgViagem.CurrentRow.Index].Value.ToString();
            txtKmFinal.Text = dgViagem[8, dgViagem.CurrentRow.Index].Value.ToString();
            txtKmTotal.Text = dgViagem[9, dgViagem.CurrentRow.Index].Value.ToString();





            txtCodEndereço.Text = dgViagem[10, dgViagem.CurrentRow.Index].Value.ToString();
            txtLogradouro.Text = dgViagem[11, dgViagem.CurrentRow.Index].Value.ToString();
            txtBairro.Text = dgViagem[12, dgViagem.CurrentRow.Index].Value.ToString();
            txtComplemento.Text = dgViagem[13, dgViagem.CurrentRow.Index].Value.ToString();
            txtNumero.Text = dgViagem[14, dgViagem.CurrentRow.Index].Value.ToString();
            txtCidade.Text = dgViagem[15, dgViagem.CurrentRow.Index].Value.ToString();
            txtEstado.Text = dgViagem[16, dgViagem.CurrentRow.Index].Value.ToString();

        }


        private void formatarGridEstados()
        {
            //dgPerfil.ReadOnly = true;
            //dgPerfil.ScrollBars = ScrollBars.Vertical;
            //dgPerfil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dgViagem.Columns[0].HeaderText = "Cód. Viagem";
            dgViagem.Columns[1].HeaderText = "Cód. Usuario";
            dgViagem.Columns[2].HeaderText = "Cod. Carro";
            dgViagem.Columns[3].Visible = false;
            dgViagem.Columns[4].HeaderText = "Hora Saida";
            dgViagem.Columns[5].HeaderText = "Hora Entrada";
            dgViagem.Columns[6].HeaderText = "Descrição";
            dgViagem.Columns[7].HeaderText = "Km Inicial";
            dgViagem.Columns[8].HeaderText = "Km Final";
            dgViagem.Columns[9].HeaderText = "Km Total";


            dgViagem.Columns[10].HeaderText = "Cod. Endereço";
            dgViagem.Columns[11].HeaderText = "Logradouro";
            dgViagem.Columns[12].HeaderText = "Bairro";
            dgViagem.Columns[13].HeaderText = "Complemento";
            dgViagem.Columns[14].HeaderText = "Numero";
            dgViagem.Columns[15].HeaderText = "Cidade";
            dgViagem.Columns[16].HeaderText = "Estado";

            dgViagem.Columns[0].Width = 50;
            //dgViagem.Columns[1].Width = 150;
            //dgViagem.Columns[2].Width = 150;


        }

       
    }
}
