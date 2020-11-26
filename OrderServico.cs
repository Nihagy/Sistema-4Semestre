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

namespace BiTecnlogy_Frotas
{
    public partial class OrderServico : Form
    {
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataAdapter _adp;
        private string sqlBanco = "Data Source = Nihagy-Dell; Initial Catalog = BiTeclogyPimIv; Integrated Security = true; ";


        public OrderServico()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodOrdemServ.Text = "";
            txtCodCliente.Text = "";
            txtCodUsuario.Text = "";
            txtCodCarro.Text = "";
            txtDescricao.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Usuarios(CodPerfil,CodCliente,UserAtivo,LoginS,Senha,Cnh,Rg,Cpf) " +
                "VALUES (" + txtCodCliente.Text + "," +
                txtCodUsuario.Text + "," +
                txtCodCarro + ",'" +
                txtDescricao.Text + "')";

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
            string sql = "UPDATE Usuarios SET " +
                "CodCliente = " + txtCodCliente.Text + ", " +
                "CodUsuario = " + txtCodUsuario.Text + ", " +
                "CodCarro = " + txtCodCarro.Text + ", " +
                "Descricao = '" + txtDescricao.Text + "'" +
                " WHERE CodOrdemServico = " + txtCodOrdemServ.Text;

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
            string sql = "DELETE Usuarios where CodOrdemServico = " + txtCodOrdemServ.Text;

            _cnn = new SqlConnection(sqlBanco);

            if (_cnn.State == ConnectionState.Closed)
                _cnn.Open();

            using (_cmd = new SqlCommand(sql, _cnn))
            {
                _cmd.ExecuteNonQuery();
            }

            _cnn.Close();
        }






    }
}
