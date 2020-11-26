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
    public partial class Usuarios : Form
    {
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataAdapter _adp;
        private string sqlBanco = "Data Source = Nihagy-Dell; Initial Catalog = BiTeclogyPimIv; Integrated Security = true; ";

        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodUsuario.Text = "";
            txtCodPerfil.Text = "";
            txtCodCliente.Text = "";
            txtUserAtivo.Text = "";
            txtCnh.Text = "";
            txtRg.Text = "";
            txtCpf.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Usuarios(CodPerfil,CodCliente,UserAtivo,LoginS,Senha,Cnh,Rg,Cpf) " +
                "VALUES (1,1,1," + 
                txtLogin.Text + "','" +
                txtSenha.Text + "','" +
                txtCnh.Text + "','" +
                txtRg.Text + "','" +
                txtCpf.Text + "')";

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
                "CodPerfil = '" + txtCodPerfil.Text + "', " +
                "CodCliente = '" + txtCodCliente.Text + "', " +
                "UserAtivo = '" + txtUserAtivo.Text + "', " +
                "LoginS = '" + txtLogin.Text + "', " +
                "Senha = '" + txtSenha.Text + "', " +
                "Cnh = '" + txtCnh.Text + "', " +
                "Rg = '" + txtRg.Text + "'," +
                "Cpf = '" + txtCpf.Text + "'," +
                " WHERE CodUsuario = " + txtCodUsuario.Text;

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
            string sql = "DELETE Usuarios where CodUsuario = " + txtCodUsuario.Text;

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
