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
    public partial class Entrada : Form
    {
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataAdapter _adp;
        private string sqlBanco = "Data Source = Nihagy-Dell; Initial Catalog = BiTeclogyPimIv; Integrated Security = true; ";

        public Entrada()
        {
            InitializeComponent();
        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            carregarDadosNoGrid();
        }



        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodEntrada.Text = "";
            txtCodUsuario.Text = "";
            txtCodViagem.Text = "";
            txtCodCarro.Text = "";
            txtHoraEntrada.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Entrada SET " +
                "CodUsuario = " + txtCodUsuario.Text + ", " +
                "CodViagem = '" + txtCodViagem.Text + "', " +
                "CodCarro = '" + txtCodCarro.Text + "', " +
                "HoraSaida = '" + txtHoraEntrada.Text +
                " WHERE CodEntrada = " + txtCodEntrada.Text;

            _cnn = new SqlConnection(sqlBanco);

            if (_cnn.State == ConnectionState.Closed)
                _cnn.Open();

            using (_cmd = new SqlCommand(sql, _cnn))
            {
                _cmd.ExecuteNonQuery();
            }

            _cnn.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Entrada SET " +
                "CodUsuario = " + txtCodUsuario.Text + ", " +
                "CodViagem = '" + txtCodViagem.Text + "', " +
                "CodCarro = '" + txtCodCarro.Text + "', " +
                "HoraSaida = '" + txtHoraEntrada.Text +
                " WHERE CodEntrada = " + txtCodEntrada.Text;

            _cnn = new SqlConnection(sqlBanco);

            if (_cnn.State == ConnectionState.Closed)
                _cnn.Open();

            using (_cmd = new SqlCommand(sql, _cnn))
            {
                _cmd.ExecuteNonQuery();
            }

            _cnn.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE Entrada where CodEntrada = " + txtCodEntrada.Text;

            _cnn = new SqlConnection(sqlBanco);

            if (_cnn.State == ConnectionState.Closed)
                _cnn.Open();

            using (_cmd = new SqlCommand(sql, _cnn))
            {
                _cmd.ExecuteNonQuery();
            }

            _cnn.Close();
        }

        private void dgEntrada_SelectionChanged(object sender, EventArgs e)
        {
            atualizarCamposTela();
        }




        private void carregarDadosNoGrid()
        {
            dgEntrada.DataSource = Conexao.ObterDados("select * from Entrada");

            formatarGridEstados();
        }


        private void atualizarCamposTela()
        {
            txtCodEntrada.Text = dgEntrada[0, dgEntrada.CurrentRow.Index].Value.ToString(); ;
            txtCodUsuario.Text = dgEntrada[1, dgEntrada.CurrentRow.Index].Value.ToString(); ;
            txtCodViagem.Text = dgEntrada[2, dgEntrada.CurrentRow.Index].Value.ToString();
            txtCodCarro.Text = dgEntrada[3, dgEntrada.CurrentRow.Index].Value.ToString();
            txtHoraEntrada.Text = dgEntrada[4, dgEntrada.CurrentRow.Index].Value.ToString();


        }


        private void formatarGridEstados()
        {

            dgEntrada.Columns[0].HeaderText = "Cod. Entrada";
            dgEntrada.Columns[1].HeaderText = "Cod. Usuario";
            dgEntrada.Columns[2].HeaderText = "Cod. Viagem";
            dgEntrada.Columns[3].HeaderText = "Cod. Carro";
            dgEntrada.Columns[4].HeaderText = "Hora Entrada";

            dgEntrada.Columns[0].Width = 50;
            dgEntrada.Columns[1].Width = 50;
            dgEntrada.Columns[2].Width = 50;
            dgEntrada.Columns[2].Width = 50;


        }

        
    }
}
