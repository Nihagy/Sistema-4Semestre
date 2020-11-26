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
    public partial class Saida : Form
    {
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataAdapter _adp;
        private string sqlBanco = "Data Source = Nihagy-Dell; Initial Catalog = BiTeclogyPimIv; Integrated Security = true; ";

        public Saida()
        {
            InitializeComponent();
        }

        private void Saida_Load(object sender, EventArgs e)
        {
            carregarDadosNoGrid();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodSaida.Text = "";
            txtCodUsuario.Text = "";
            txtCodViagem.Text = "";
            txtCodCarro.Text = "";
            txtHoraSaida.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Saida(CodUsuario,CodViagem,CodCarro,HoraSaida)" +
                "VALUES (" + txtCodUsuario + "," +
                txtCodViagem.Text + "," +
                txtCodCarro.Text + "," +
                txtHoraSaida.Text + ")";

            Conexao.ExecutarSql(sql);

            carregarDadosNoGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Saida SET " +
                "CodUsuario = " + txtCodUsuario.Text + ", " +
                "CodViagem = '" + txtCodViagem.Text + "', " +
                "CodCarro = '" + txtCodCarro.Text + "', " +
                "HoraSaida = '" + txtHoraSaida.Text +
                " WHERE CodSaida = " + txtCodSaida.Text;

            Conexao.ExecutarSql(sql);

            carregarDadosNoGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE Saida where CodSaida = " + txtCodSaida.Text;

            Conexao.ExecutarSql(sql);

            carregarDadosNoGrid();
        }

        private void dgSaida_SelectionChanged(object sender, EventArgs e)
        {
            atualizarCamposTela();
        }



        private void carregarDadosNoGrid()
        {
            dgSaida.DataSource = Conexao.ObterDados("select * from Saida");

            formatarGridEstados();
        }


        private void atualizarCamposTela()
        {
            txtCodSaida.Text = dgSaida[0, dgSaida.CurrentRow.Index].Value.ToString(); ;
            txtCodUsuario.Text = dgSaida[1, dgSaida.CurrentRow.Index].Value.ToString(); ;
            txtCodViagem.Text = dgSaida[2, dgSaida.CurrentRow.Index].Value.ToString();
            txtCodCarro.Text = dgSaida[3, dgSaida.CurrentRow.Index].Value.ToString();
            txtHoraSaida.Text = dgSaida[4, dgSaida.CurrentRow.Index].Value.ToString();


        }


        private void formatarGridEstados()
        {

            dgSaida.Columns[0].HeaderText = "Cod. Saida";
            dgSaida.Columns[1].HeaderText = "Cod. Usuario";
            dgSaida.Columns[2].HeaderText = "Cod. Viagem";
            dgSaida.Columns[3].HeaderText = "Cod. Carro";
            dgSaida.Columns[4].HeaderText = "Hora Saida";

            dgSaida.Columns[0].Width = 50;
            dgSaida.Columns[1].Width = 50;
            dgSaida.Columns[2].Width = 50;
            dgSaida.Columns[2].Width = 50;


        }




    }
}
