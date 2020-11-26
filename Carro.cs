using System;
using System.Windows.Forms;

using DAL;

namespace BiTecnlogy_Frotas
{
    public partial class Carro : Form
    {
        public Carro()
        {
            InitializeComponent();
        }


        private void Carro_Load(object sender, EventArgs e)
        {
            carregarDadosNoGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodCarro.Text = "";
            txtCodUsuario.Text = "";
            txtPlaca.Text = "";
            txtAno.Text = "";
            txtChassi.Text = "";
            txtQuilometragem.Text = "";
            txtDescricao.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Carro(CodUsuario,Placa,Ano,Chassi,Quilometragem,Descricao)  " +
                "VALUES (1,'" +
                txtCodUsuario.Text + "','" +
                txtPlaca.Text + "','" +
                txtAno.Text + "','" +
                txtChassi.Text + "'," +
                txtQuilometragem.Text + ",'" +
                txtDescricao.Text + "')";

            Conexao.ExecutarSql(sql);

            carregarDadosNoGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Clientes SET " +
                "CodUsuario = '" + txtCodUsuario.Text + "', " +
                "Placa = '" + txtPlaca.Text + "', " +
                "Ano = '" + txtAno.Text + "', " +
                "Chassi = '" + txtChassi.Text + "', " +
                "Quilometragem = '" + txtQuilometragem.Text + "', " +
                "Descricao = 2" +
                " WHERE CodCarro = " + txtCodCarro.Text;

            Conexao.ExecutarSql(sql);

            carregarDadosNoGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE Clientes where CodCarro = " + txtCodCarro.Text;

            Conexao.ExecutarSql(sql);

            carregarDadosNoGrid();
        }

        private void dgCarro_SelectionChanged(object sender, EventArgs e)
        {
            atualizarCamposTela();
        }


        private void carregarDadosNoGrid()
        {
            dgCarro.DataSource = Conexao.ObterDados("select * from Carro");

            formatarGridEstados();
        }


        private void atualizarCamposTela()
        {
            txtCodCarro.Text = dgCarro[0, dgCarro.CurrentRow.Index].Value.ToString(); ;
            txtCodUsuario.Text = dgCarro[1, dgCarro.CurrentRow.Index].Value.ToString(); ;
            txtPlaca.Text = dgCarro[2, dgCarro.CurrentRow.Index].Value.ToString();
            txtAno.Text = dgCarro[3, dgCarro.CurrentRow.Index].Value.ToString();
            txtChassi.Text = dgCarro[4, dgCarro.CurrentRow.Index].Value.ToString();
            txtQuilometragem.Text = dgCarro[5, dgCarro.CurrentRow.Index].Value.ToString();

            txtDescricao.Text = dgCarro[6, dgCarro.CurrentRow.Index].Value.ToString();
        }


        private void formatarGridEstados()
        {
            //dgPerfil.ReadOnly = true;
            //dgPerfil.ScrollBars = ScrollBars.Vertical;
            //dgPerfil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dgCarro.Columns[0].HeaderText = "Cód. Carro";
            dgCarro.Columns[1].HeaderText = "Cod Usuario";
            dgCarro.Columns[2].HeaderText = "Placa";
            dgCarro.Columns[3].HeaderText = "Ano";
            dgCarro.Columns[4].HeaderText = "Chassi";
            dgCarro.Columns[5].HeaderText = "Quilometragem";
            dgCarro.Columns[6].HeaderText = "Descrição";

            dgCarro.Columns[0].Width = 50;
            dgCarro.Columns[1].Width = 50;
            //dgCarro.Columns[2].Width = 150;


        }

        



    }
}
