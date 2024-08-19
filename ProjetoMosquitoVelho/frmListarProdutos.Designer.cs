
namespace ProjetoMosquitoVelho
{
    partial class frmListarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarProdutos));
            this.btnCarregar = new System.Windows.Forms.Button();
            this.ltbListadeProdutos = new System.Windows.Forms.ListBox();
            this.cboProdutos = new System.Windows.Forms.ComboBox();
            this.lblListadeProdutos = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblListarItens = new System.Windows.Forms.Label();
            this.cboListarItens = new System.Windows.Forms.ComboBox();
            this.btnTestarPessoa = new System.Windows.Forms.Button();
            this.lblTestarPessoa = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMostrarNumeroCartao = new System.Windows.Forms.Label();
            this.lblMostrarDocumento = new System.Windows.Forms.Label();
            this.mtbNumerodoCartao = new System.Windows.Forms.MaskedTextBox();
            this.mtbDocumento = new System.Windows.Forms.MaskedTextBox();
            this.btnTestarLogin = new System.Windows.Forms.Button();
            this.txtTestaLogin = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(609, 300);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(161, 34);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // ltbListadeProdutos
            // 
            this.ltbListadeProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListadeProdutos.FormattingEnabled = true;
            this.ltbListadeProdutos.ItemHeight = 20;
            this.ltbListadeProdutos.Location = new System.Drawing.Point(609, 62);
            this.ltbListadeProdutos.Name = "ltbListadeProdutos";
            this.ltbListadeProdutos.Size = new System.Drawing.Size(167, 184);
            this.ltbListadeProdutos.TabIndex = 1;
            // 
            // cboProdutos
            // 
            this.cboProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProdutos.FormattingEnabled = true;
            this.cboProdutos.Location = new System.Drawing.Point(44, 63);
            this.cboProdutos.Name = "cboProdutos";
            this.cboProdutos.Size = new System.Drawing.Size(148, 28);
            this.cboProdutos.TabIndex = 2;
            this.cboProdutos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblListadeProdutos
            // 
            this.lblListadeProdutos.AutoSize = true;
            this.lblListadeProdutos.Location = new System.Drawing.Point(612, 37);
            this.lblListadeProdutos.Name = "lblListadeProdutos";
            this.lblListadeProdutos.Size = new System.Drawing.Size(89, 13);
            this.lblListadeProdutos.TabIndex = 3;
            this.lblListadeProdutos.Text = "Lista de Produtos";
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Location = new System.Drawing.Point(41, 37);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(49, 13);
            this.lblProdutos.TabIndex = 4;
            this.lblProdutos.Text = "Produtos";
            // 
            // lblListarItens
            // 
            this.lblListarItens.AutoSize = true;
            this.lblListarItens.Location = new System.Drawing.Point(240, 37);
            this.lblListarItens.Name = "lblListarItens";
            this.lblListarItens.Size = new System.Drawing.Size(58, 13);
            this.lblListarItens.TabIndex = 6;
            this.lblListarItens.Tag = "";
            this.lblListarItens.Text = "Listar Itens";
            // 
            // cboListarItens
            // 
            this.cboListarItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboListarItens.FormattingEnabled = true;
            this.cboListarItens.Location = new System.Drawing.Point(237, 62);
            this.cboListarItens.Name = "cboListarItens";
            this.cboListarItens.Size = new System.Drawing.Size(148, 28);
            this.cboListarItens.TabIndex = 5;
            this.cboListarItens.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btnTestarPessoa
            // 
            this.btnTestarPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestarPessoa.Location = new System.Drawing.Point(44, 159);
            this.btnTestarPessoa.Name = "btnTestarPessoa";
            this.btnTestarPessoa.Size = new System.Drawing.Size(148, 34);
            this.btnTestarPessoa.TabIndex = 7;
            this.btnTestarPessoa.Text = "&Testar Pessoa";
            this.btnTestarPessoa.UseVisualStyleBackColor = true;
            this.btnTestarPessoa.Click += new System.EventHandler(this.btnTestarPessoa_Click);
            // 
            // lblTestarPessoa
            // 
            this.lblTestarPessoa.AutoSize = true;
            this.lblTestarPessoa.Location = new System.Drawing.Point(240, 171);
            this.lblTestarPessoa.Name = "lblTestarPessoa";
            this.lblTestarPessoa.Size = new System.Drawing.Size(0, 13);
            this.lblTestarPessoa.TabIndex = 9;
            this.lblTestarPessoa.Tag = "";
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(44, 252);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(148, 34);
            this.btnReservar.TabIndex = 10;
            this.btnReservar.Text = "&Reserva";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(615, 374);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(155, 34);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(412, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 186);
            this.listBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 12;
            this.label1.Tag = "";
            this.label1.Text = "Mostra Pessoa";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(41, 317);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 13;
            this.lblDocumento.Tag = "";
            this.lblDocumento.Text = "Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 15;
            this.label2.Tag = "";
            this.label2.Text = "Número do Cartão";
            // 
            // lblMostrarNumeroCartao
            // 
            this.lblMostrarNumeroCartao.AutoSize = true;
            this.lblMostrarNumeroCartao.Location = new System.Drawing.Point(217, 409);
            this.lblMostrarNumeroCartao.Name = "lblMostrarNumeroCartao";
            this.lblMostrarNumeroCartao.Size = new System.Drawing.Size(131, 13);
            this.lblMostrarNumeroCartao.TabIndex = 18;
            this.lblMostrarNumeroCartao.Tag = "";
            this.lblMostrarNumeroCartao.Text = "Mostrar Número do Cartão";
            // 
            // lblMostrarDocumento
            // 
            this.lblMostrarDocumento.AutoSize = true;
            this.lblMostrarDocumento.Location = new System.Drawing.Point(217, 347);
            this.lblMostrarDocumento.Name = "lblMostrarDocumento";
            this.lblMostrarDocumento.Size = new System.Drawing.Size(100, 13);
            this.lblMostrarDocumento.TabIndex = 17;
            this.lblMostrarDocumento.Tag = "";
            this.lblMostrarDocumento.Text = "Mostrar Documento";
            // 
            // mtbNumerodoCartao
            // 
            this.mtbNumerodoCartao.Location = new System.Drawing.Point(44, 406);
            this.mtbNumerodoCartao.Mask = "000,000,000-00";
            this.mtbNumerodoCartao.Name = "mtbNumerodoCartao";
            this.mtbNumerodoCartao.Size = new System.Drawing.Size(148, 20);
            this.mtbNumerodoCartao.TabIndex = 21;
            // 
            // mtbDocumento
            // 
            this.mtbDocumento.Location = new System.Drawing.Point(44, 340);
            this.mtbDocumento.Name = "mtbDocumento";
            this.mtbDocumento.Size = new System.Drawing.Size(148, 20);
            this.mtbDocumento.TabIndex = 22;
            // 
            // btnTestarLogin
            // 
            this.btnTestarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestarLogin.Location = new System.Drawing.Point(237, 252);
            this.btnTestarLogin.Name = "btnTestarLogin";
            this.btnTestarLogin.Size = new System.Drawing.Size(148, 34);
            this.btnTestarLogin.TabIndex = 23;
            this.btnTestarLogin.Text = "&Testar Login";
            this.btnTestarLogin.UseVisualStyleBackColor = true;
            this.btnTestarLogin.Click += new System.EventHandler(this.btnTestarLogin_Click);
            // 
            // txtTestaLogin
            // 
            this.txtTestaLogin.Location = new System.Drawing.Point(237, 210);
            this.txtTestaLogin.Name = "txtTestaLogin";
            this.txtTestaLogin.Size = new System.Drawing.Size(148, 20);
            this.txtTestaLogin.TabIndex = 24;
            // 
            // frmListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTestaLogin);
            this.Controls.Add(this.btnTestarLogin);
            this.Controls.Add(this.mtbDocumento);
            this.Controls.Add(this.mtbNumerodoCartao);
            this.Controls.Add(this.lblMostrarNumeroCartao);
            this.Controls.Add(this.lblMostrarDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.lblTestarPessoa);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnTestarPessoa);
            this.Controls.Add(this.lblListarItens);
            this.Controls.Add(this.cboListarItens);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.lblListadeProdutos);
            this.Controls.Add(this.cboProdutos);
            this.Controls.Add(this.ltbListadeProdutos);
            this.Controls.Add(this.btnCarregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema ABC -ListarProdutos";
            this.Load += new System.EventHandler(this.frmListarProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ListBox ltbListadeProdutos;
        private System.Windows.Forms.ComboBox cboProdutos;
        private System.Windows.Forms.Label lblListadeProdutos;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblListarItens;
        private System.Windows.Forms.ComboBox cboListarItens;
        private System.Windows.Forms.Button btnTestarPessoa;
        private System.Windows.Forms.Label lblTestarPessoa;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMostrarNumeroCartao;
        private System.Windows.Forms.Label lblMostrarDocumento;
        private System.Windows.Forms.MaskedTextBox mtbNumerodoCartao;
        private System.Windows.Forms.MaskedTextBox mtbDocumento;
        private System.Windows.Forms.Button btnTestarLogin;
        private System.Windows.Forms.MaskedTextBox txtTestaLogin;
    }
}