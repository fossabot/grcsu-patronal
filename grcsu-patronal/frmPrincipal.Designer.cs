namespace grcsu_patronal
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblCapitalSocial = new System.Windows.Forms.Label();
            this.lblAliquota = new System.Windows.Forms.Label();
            this.lblTributo = new System.Windows.Forms.Label();
            this.lblParcela = new System.Windows.Forms.Label();
            this.lblValorAPagar = new System.Windows.Forms.Label();
            this.txtCapitalSocial = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblAliquotaResultado = new System.Windows.Forms.Label();
            this.lblTributoResultado = new System.Windows.Forms.Label();
            this.lblParcelaResultado = new System.Windows.Forms.Label();
            this.lblValorAPagarResultado = new System.Windows.Forms.Label();
            this.lblAvisoDeUso = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lnkSite = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCapitalSocial
            // 
            this.lblCapitalSocial.AutoSize = true;
            this.lblCapitalSocial.Location = new System.Drawing.Point(12, 55);
            this.lblCapitalSocial.Name = "lblCapitalSocial";
            this.lblCapitalSocial.Size = new System.Drawing.Size(186, 21);
            this.lblCapitalSocial.TabIndex = 0;
            this.lblCapitalSocial.Text = "Capital social da empresa";
            // 
            // lblAliquota
            // 
            this.lblAliquota.AutoSize = true;
            this.lblAliquota.Location = new System.Drawing.Point(12, 102);
            this.lblAliquota.Name = "lblAliquota";
            this.lblAliquota.Size = new System.Drawing.Size(68, 21);
            this.lblAliquota.TabIndex = 1;
            this.lblAliquota.Text = "Alíquota";
            // 
            // lblTributo
            // 
            this.lblTributo.AutoSize = true;
            this.lblTributo.Location = new System.Drawing.Point(12, 147);
            this.lblTributo.Name = "lblTributo";
            this.lblTributo.Size = new System.Drawing.Size(119, 21);
            this.lblTributo.TabIndex = 2;
            this.lblTributo.Text = "Valor do tributo";
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(12, 192);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(154, 21);
            this.lblParcela.TabIndex = 3;
            this.lblParcela.Text = "Parcela a acrescentar";
            // 
            // lblValorAPagar
            // 
            this.lblValorAPagar.AutoSize = true;
            this.lblValorAPagar.Location = new System.Drawing.Point(12, 237);
            this.lblValorAPagar.Name = "lblValorAPagar";
            this.lblValorAPagar.Size = new System.Drawing.Size(102, 21);
            this.lblValorAPagar.TabIndex = 4;
            this.lblValorAPagar.Text = "Valor a pagar";
            // 
            // txtCapitalSocial
            // 
            this.txtCapitalSocial.Location = new System.Drawing.Point(314, 52);
            this.txtCapitalSocial.Name = "txtCapitalSocial";
            this.txtCapitalSocial.Size = new System.Drawing.Size(158, 29);
            this.txtCapitalSocial.TabIndex = 5;
            this.txtCapitalSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapitalSocial_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(519, 52);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(93, 29);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblAliquotaResultado
            // 
            this.lblAliquotaResultado.AutoSize = true;
            this.lblAliquotaResultado.Location = new System.Drawing.Point(420, 97);
            this.lblAliquotaResultado.Name = "lblAliquotaResultado";
            this.lblAliquotaResultado.Size = new System.Drawing.Size(52, 21);
            this.lblAliquotaResultado.TabIndex = 7;
            this.lblAliquotaResultado.Text = "label6";
            // 
            // lblTributoResultado
            // 
            this.lblTributoResultado.AutoSize = true;
            this.lblTributoResultado.Location = new System.Drawing.Point(420, 143);
            this.lblTributoResultado.Name = "lblTributoResultado";
            this.lblTributoResultado.Size = new System.Drawing.Size(52, 21);
            this.lblTributoResultado.TabIndex = 8;
            this.lblTributoResultado.Text = "label7";
            // 
            // lblParcelaResultado
            // 
            this.lblParcelaResultado.AutoSize = true;
            this.lblParcelaResultado.Location = new System.Drawing.Point(420, 189);
            this.lblParcelaResultado.Name = "lblParcelaResultado";
            this.lblParcelaResultado.Size = new System.Drawing.Size(52, 21);
            this.lblParcelaResultado.TabIndex = 9;
            this.lblParcelaResultado.Text = "label8";
            // 
            // lblValorAPagarResultado
            // 
            this.lblValorAPagarResultado.AutoSize = true;
            this.lblValorAPagarResultado.Location = new System.Drawing.Point(420, 235);
            this.lblValorAPagarResultado.Name = "lblValorAPagarResultado";
            this.lblValorAPagarResultado.Size = new System.Drawing.Size(52, 21);
            this.lblValorAPagarResultado.TabIndex = 10;
            this.lblValorAPagarResultado.Text = "label9";
            // 
            // lblAvisoDeUso
            // 
            this.lblAvisoDeUso.AutoEllipsis = true;
            this.lblAvisoDeUso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoDeUso.Location = new System.Drawing.Point(12, 310);
            this.lblAvisoDeUso.Name = "lblAvisoDeUso";
            this.lblAvisoDeUso.Size = new System.Drawing.Size(600, 49);
            this.lblAvisoDeUso.TabIndex = 11;
            this.lblAvisoDeUso.Text = "Aviso: Este programa serve ao único propósito de auxiliar no cálculo do tributo, " +
    "não devendo ser usado como substituto da boa e velha calculadora. VOCÊ FOI AVISA" +
    "DO.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Caixa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Sobre";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(519, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 29);
            this.button3.TabIndex = 15;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(604, 21);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Auxiliar de Cálculo da Guia de Recolhimento da Contribuição Sindical Urbana Patro" +
    "nal";
            // 
            // lnkSite
            // 
            this.lnkSite.AutoSize = true;
            this.lnkSite.Location = new System.Drawing.Point(12, 411);
            this.lnkSite.Name = "lnkSite";
            this.lnkSite.Size = new System.Drawing.Size(387, 21);
            this.lnkSite.TabIndex = 17;
            this.lnkSite.TabStop = true;
            this.lnkSite.Text = "GRCSU Patronal (C) 2017 J Santana Gestão de Pessoal.";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lnkSite);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAvisoDeUso);
            this.Controls.Add(this.lblValorAPagarResultado);
            this.Controls.Add(this.lblParcelaResultado);
            this.Controls.Add(this.lblTributoResultado);
            this.Controls.Add(this.lblAliquotaResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCapitalSocial);
            this.Controls.Add(this.lblValorAPagar);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.lblTributo);
            this.Controls.Add(this.lblAliquota);
            this.Controls.Add(this.lblCapitalSocial);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GRCSU Patronal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapitalSocial;
        private System.Windows.Forms.Label lblAliquota;
        private System.Windows.Forms.Label lblTributo;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.Label lblValorAPagar;
        private System.Windows.Forms.TextBox txtCapitalSocial;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblAliquotaResultado;
        private System.Windows.Forms.Label lblTributoResultado;
        private System.Windows.Forms.Label lblParcelaResultado;
        private System.Windows.Forms.Label lblValorAPagarResultado;
        private System.Windows.Forms.Label lblAvisoDeUso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.LinkLabel lnkSite;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

