namespace BiTecnlogy_Frotas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.telaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuTipoPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuOrderServ = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuManutencaoGeral = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuContasPagar = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuContasReceber = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuCadastroVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuViagem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuLocacao = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuAbastecimento = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuMulta = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telaInicialToolStripMenuItem,
            this.usuarioPerfilToolStripMenuItem,
            this.menuCliente,
            this.sobreToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.veiculosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.menuSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // telaInicialToolStripMenuItem
            // 
            this.telaInicialToolStripMenuItem.Name = "telaInicialToolStripMenuItem";
            this.telaInicialToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.telaInicialToolStripMenuItem.Text = "Tela Inicial";
            // 
            // usuarioPerfilToolStripMenuItem
            // 
            this.usuarioPerfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuUsuario,
            this.subMenuTipoPerfil});
            this.usuarioPerfilToolStripMenuItem.Name = "usuarioPerfilToolStripMenuItem";
            this.usuarioPerfilToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.usuarioPerfilToolStripMenuItem.Text = "Usuario/Perfil";
            // 
            // subMenuUsuario
            // 
            this.subMenuUsuario.Name = "subMenuUsuario";
            this.subMenuUsuario.Size = new System.Drawing.Size(127, 22);
            this.subMenuUsuario.Text = "Usuario";
            this.subMenuUsuario.Click += new System.EventHandler(this.subMenuUsuario_Click);
            // 
            // subMenuTipoPerfil
            // 
            this.subMenuTipoPerfil.Name = "subMenuTipoPerfil";
            this.subMenuTipoPerfil.Size = new System.Drawing.Size(127, 22);
            this.subMenuTipoPerfil.Text = "Tipo Perfil";
            this.subMenuTipoPerfil.Click += new System.EventHandler(this.subMenuTipoPerfil_Click);
            // 
            // menuCliente
            // 
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(56, 20);
            this.menuCliente.Text = "Cliente";
            this.menuCliente.Click += new System.EventHandler(this.menuCliente_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuOrderServ,
            this.subMenuManutencaoGeral});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.sobreToolStripMenuItem.Text = "Manutenção";
            // 
            // subMenuOrderServ
            // 
            this.subMenuOrderServ.Name = "subMenuOrderServ";
            this.subMenuOrderServ.Size = new System.Drawing.Size(171, 22);
            this.subMenuOrderServ.Text = "Ordem Serviço";
            this.subMenuOrderServ.Click += new System.EventHandler(this.subMenuOrderServ_Click);
            // 
            // subMenuManutencaoGeral
            // 
            this.subMenuManutencaoGeral.Name = "subMenuManutencaoGeral";
            this.subMenuManutencaoGeral.Size = new System.Drawing.Size(171, 22);
            this.subMenuManutencaoGeral.Text = "Manutenção Geral";
            this.subMenuManutencaoGeral.Click += new System.EventHandler(this.subMenuManutencaoGeral_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuContasPagar,
            this.subMenuContasReceber});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // subMenuContasPagar
            // 
            this.subMenuContasPagar.Name = "subMenuContasPagar";
            this.subMenuContasPagar.Size = new System.Drawing.Size(162, 22);
            this.subMenuContasPagar.Text = "Contas a Pagar";
            // 
            // subMenuContasReceber
            // 
            this.subMenuContasReceber.Name = "subMenuContasReceber";
            this.subMenuContasReceber.Size = new System.Drawing.Size(162, 22);
            this.subMenuContasReceber.Text = "Contas a receber";
            // 
            // veiculosToolStripMenuItem
            // 
            this.veiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCadastroVeiculo,
            this.subMenuViagem,
            this.subMenuSaida,
            this.subMenuEntrada,
            this.subMenuLocacao,
            this.subMenuAbastecimento,
            this.subMenuMulta});
            this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.veiculosToolStripMenuItem.Text = "Veiculos";
            // 
            // subMenuCadastroVeiculo
            // 
            this.subMenuCadastroVeiculo.Name = "subMenuCadastroVeiculo";
            this.subMenuCadastroVeiculo.Size = new System.Drawing.Size(154, 22);
            this.subMenuCadastroVeiculo.Text = "Cadastro";
            this.subMenuCadastroVeiculo.Click += new System.EventHandler(this.subMenuCadastroVeiculo_Click);
            // 
            // subMenuViagem
            // 
            this.subMenuViagem.Name = "subMenuViagem";
            this.subMenuViagem.Size = new System.Drawing.Size(154, 22);
            this.subMenuViagem.Text = "Viagem";
            this.subMenuViagem.Click += new System.EventHandler(this.subMenuViagem_Click);
            // 
            // subMenuSaida
            // 
            this.subMenuSaida.Name = "subMenuSaida";
            this.subMenuSaida.Size = new System.Drawing.Size(154, 22);
            this.subMenuSaida.Text = "Saida";
            this.subMenuSaida.Click += new System.EventHandler(this.subMenuSaida_Click);
            // 
            // subMenuEntrada
            // 
            this.subMenuEntrada.Name = "subMenuEntrada";
            this.subMenuEntrada.Size = new System.Drawing.Size(154, 22);
            this.subMenuEntrada.Text = "Entrada";
            this.subMenuEntrada.Click += new System.EventHandler(this.subMenuEntrada_Click);
            // 
            // subMenuLocacao
            // 
            this.subMenuLocacao.Name = "subMenuLocacao";
            this.subMenuLocacao.Size = new System.Drawing.Size(154, 22);
            this.subMenuLocacao.Text = "Locação";
            this.subMenuLocacao.Click += new System.EventHandler(this.subMenuLocacao_Click);
            // 
            // subMenuAbastecimento
            // 
            this.subMenuAbastecimento.Name = "subMenuAbastecimento";
            this.subMenuAbastecimento.Size = new System.Drawing.Size(154, 22);
            this.subMenuAbastecimento.Text = "Abastecimento";
            this.subMenuAbastecimento.Click += new System.EventHandler(this.subMenuAbastecimento_Click);
            // 
            // subMenuMulta
            // 
            this.subMenuMulta.Name = "subMenuMulta";
            this.subMenuMulta.Size = new System.Drawing.Size(154, 22);
            this.subMenuMulta.Text = "Multa";
            this.subMenuMulta.Click += new System.EventHandler(this.subMenuMulta_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // menuSobre
            // 
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(49, 20);
            this.menuSobre.Text = "Sobre";
            this.menuSobre.Click += new System.EventHandler(this.menuSobre_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox1.Image = global::BiTecnlogy_Frotas.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem telaInicialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSobre;
        private System.Windows.Forms.ToolStripMenuItem usuarioPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subMenuUsuario;
        private System.Windows.Forms.ToolStripMenuItem subMenuTipoPerfil;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem subMenuOrderServ;
        private System.Windows.Forms.ToolStripMenuItem subMenuContasPagar;
        private System.Windows.Forms.ToolStripMenuItem subMenuContasReceber;
        private System.Windows.Forms.ToolStripMenuItem subMenuCadastroVeiculo;
        private System.Windows.Forms.ToolStripMenuItem subMenuViagem;
        private System.Windows.Forms.ToolStripMenuItem subMenuSaida;
        private System.Windows.Forms.ToolStripMenuItem subMenuEntrada;
        private System.Windows.Forms.ToolStripMenuItem subMenuLocacao;
        private System.Windows.Forms.ToolStripMenuItem subMenuAbastecimento;
        private System.Windows.Forms.ToolStripMenuItem subMenuMulta;
        private System.Windows.Forms.ToolStripMenuItem subMenuManutencaoGeral;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

