using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiTecnlogy_Frotas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void subMenuTipoPerfil_Click(object sender, EventArgs e)
        {
            TipoPerfil tipoPerfil = new TipoPerfil();

            tipoPerfil.ShowDialog();
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.ShowDialog();
        }

        private void subMenuUsuario_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();

            usuarios.ShowDialog();
        }

        private void subMenuOrderServ_Click(object sender, EventArgs e)
        {
            OrderServico orderServico = new OrderServico();

            orderServico.ShowDialog();
        }

        private void subMenuCadastroVeiculo_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();

            carro.ShowDialog();
        }

        private void subMenuViagem_Click(object sender, EventArgs e)
        {
            Viagem viagem = new Viagem();

            viagem.ShowDialog();
        }

        private void subMenuSaida_Click(object sender, EventArgs e)
        {
            Saida saida = new Saida();

            saida.ShowDialog();
        }

        private void subMenuEntrada_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();

            entrada.ShowDialog();
        }

        private void subMenuLocacao_Click(object sender, EventArgs e)
        {
            Locacao locacao = new Locacao();

            locacao.ShowDialog();
        }

        private void subMenuAbastecimento_Click(object sender, EventArgs e)
        {
            Abastecimento abastecimento = new Abastecimento();

            abastecimento.ShowDialog();
        }

        private void subMenuMulta_Click(object sender, EventArgs e)
        {
            Multa multa = new Multa();

            multa.ShowDialog();
        }

        private void menuSobre_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();

            sobre.ShowDialog();
        }

        private void subMenuManutencaoGeral_Click(object sender, EventArgs e)
        {
            Manutencao manutencao = new Manutencao();

            manutencao.ShowDialog();
        }
    }
}
