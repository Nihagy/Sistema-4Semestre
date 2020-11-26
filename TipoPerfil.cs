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

using DTO;
using DAL;

namespace BiTecnlogy_Frotas
{
    public partial class TipoPerfil : Form
    {
        private TipoPerfil _tipoPerfil;
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataAdapter _adp;
        private string sqlBanco = "Data Source = Nihagy-Dell; Initial Catalog = BiTeclogyPimIv; Integrated Security = true; ";

        public TipoPerfil()
        {
            InitializeComponent();
        }

        private void TipoPerfil_Load(object sender, EventArgs e)
        {
            _tipoPerfil = new TipoPerfil();
            carregarDadosNoGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtTipo.Text = "";
            txtDescricao.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string sql = "INSERT INTO Perfis(TipoPerfil,Descricao) VALUES ('" + txtTipo.Text + "','" + txtDescricao.Text + "')";


            Conexao.ExecutarSql(sql);

            carregarDadosNoGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Perfis SET TipoPerfil = '" + txtTipo.Text + "', Descricao = '" + txtDescricao.Text + "' WHERE CodPerfil = " + txtCod.Text;

            Conexao.ExecutarSql(sql);

            carregarDadosNoGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE Perfis where CodPerfil = " + txtCod.Text;

            Conexao.ExecutarSql(sql);

            carregarDadosNoGrid();
        }

        private void dgPerfil_SelectionChanged(object sender, EventArgs e)
        {
            atualizarCamposTela();
        }





        private void carregarDadosNoGrid()
        {
            dgPerfil.DataSource = Conexao.ObterDados("select * from Perfis");

            formatarGridEstados();
        }


        private void atualizarCamposTela()
        {
            txtCod.Text = dgPerfil[0, dgPerfil.CurrentRow.Index].Value.ToString(); ;
            txtTipo.Text = dgPerfil[1, dgPerfil.CurrentRow.Index].Value.ToString(); ;
            txtDescricao.Text = dgPerfil[2, dgPerfil.CurrentRow.Index].Value.ToString();
        }


        private void formatarGridEstados()
        {
            //dgPerfil.ReadOnly = true;
            //dgPerfil.ScrollBars = ScrollBars.Vertical;
            //dgPerfil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dgPerfil.Columns[0].HeaderText = "Cód.";
            dgPerfil.Columns[1].HeaderText = "Tipo";
            dgPerfil.Columns[2].HeaderText = "Descrição";

            dgPerfil.Columns[0].Width = 50;
            dgPerfil.Columns[1].Width = 150;
            dgPerfil.Columns[2].Width = 150;


        }




    }
}
