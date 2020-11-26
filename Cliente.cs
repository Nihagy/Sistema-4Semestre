using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

using DAL;

namespace BiTecnlogy_Frotas
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }


        private void Cliente_Load(object sender, EventArgs e)
        {
            carregarDadosNoGrid();
        }



        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodCliente.Text = "";
            txtCNPJ.Text = "";
            txtNome.Text = "";
            txtEmpresa.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";

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
            string sql = "INSERT INTO endereco(Logradouro,Bairro,Complemento,Numero,Cidade,Estado) VALUES ('" + txtLogradouro.Text + "','" + txtBairro.Text + "','"  + txtComplemento.Text + "','" + txtNumero.Text + "','" + txtCidade.Text + "','" + txtEstado.Text + "')";

            Conexao.ExecutarSql(sql);


            sql = "INSERT INTO Clientes(Nome,Telefone,Cnpj,Empresa,Email,CodEndereco) VALUES ('" + txtNome.Text + "','" + txtTelefone.Text + "','" + txtCNPJ.Text + "','" + txtEmpresa.Text + "','" + txtEmail.Text + "', 2)";

            Conexao.ExecutarSql(sql);

            carregarDadosNoGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Clientes SET " +
                "Nome = '" + txtNome.Text + "', " +
                "Telefone = '" + txtTelefone.Text + "', " +
                "Cnpj = '" + txtCNPJ.Text + "', " +
                "Empresa = '" + txtEmpresa.Text + "', " +
                "Email = '" + txtEmail.Text + "', " +
                "CodEndereco = 2" +
                " WHERE CodCliente = " + txtCodCliente.Text;

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
            string sql = "DELETE Clientes where CodCliente = " + txtCodCliente.Text;

            Conexao.ExecutarSql(sql);


            sql = "DELETE endereco where CodEndereco = " + txtCodEndereço.Text;

            Conexao.ExecutarSql(sql);

            carregarDadosNoGrid();


        }




        private void carregarDadosNoGrid()
        {
            dgCliente.DataSource = Conexao.ObterDados("select * from Clientes as c inner join endereco as e ON  c.CodEndereco = e.CodEndereco");

            formatarGridEstados();
        }


        private void atualizarCamposTela()
        {
            txtCodCliente.Text = dgCliente[0, dgCliente.CurrentRow.Index].Value.ToString(); ;
            txtNome.Text = dgCliente[1, dgCliente.CurrentRow.Index].Value.ToString(); ;
            txtTelefone.Text = dgCliente[2, dgCliente.CurrentRow.Index].Value.ToString();
            txtCNPJ.Text = dgCliente[3, dgCliente.CurrentRow.Index].Value.ToString();
            txtEmpresa.Text = dgCliente[4, dgCliente.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dgCliente[5, dgCliente.CurrentRow.Index].Value.ToString();

            txtCodEndereço.Text = dgCliente[6, dgCliente.CurrentRow.Index].Value.ToString();
            txtLogradouro.Text = dgCliente[7, dgCliente.CurrentRow.Index].Value.ToString();
            txtBairro.Text = dgCliente[8, dgCliente.CurrentRow.Index].Value.ToString();
            txtComplemento.Text = dgCliente[9, dgCliente.CurrentRow.Index].Value.ToString();
            txtNumero.Text = dgCliente[10, dgCliente.CurrentRow.Index].Value.ToString();
            txtCidade.Text = dgCliente[11, dgCliente.CurrentRow.Index].Value.ToString();
            txtEstado.Text = dgCliente[12, dgCliente.CurrentRow.Index].Value.ToString();

        }


        private void formatarGridEstados()
        {
            //dgPerfil.ReadOnly = true;
            //dgPerfil.ScrollBars = ScrollBars.Vertical;
            //dgPerfil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dgCliente.Columns[0].HeaderText = "Cód. Cliente";
            dgCliente.Columns[1].HeaderText = "Nome";
            dgCliente.Columns[2].HeaderText = "Telefone";
            dgCliente.Columns[3].HeaderText = "Cnpj";
            dgCliente.Columns[4].HeaderText = "Empresa";
            dgCliente.Columns[5].HeaderText = "Email";
            dgCliente.Columns[6].Visible = false;


            dgCliente.Columns[7].HeaderText = "Cod. Endereço";
            dgCliente.Columns[8].HeaderText = "Logradouro";
            dgCliente.Columns[9].HeaderText = "Bairro";
            dgCliente.Columns[10].HeaderText = "Complemento";
            dgCliente.Columns[11].HeaderText = "Numero";
            dgCliente.Columns[12].HeaderText = "Cidade";
            dgCliente.Columns[13].HeaderText = "Estado";

            dgCliente.Columns[0].Width = 50;
            //dgCliente.Columns[1].Width = 150;
            //dgCliente.Columns[2].Width = 150;


        }

        private void dgCliente_SelectionChanged(object sender, EventArgs e)
        {
            atualizarCamposTela();
        }

        



    }
}
