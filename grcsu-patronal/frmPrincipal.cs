﻿using System;
using System.Windows.Forms;

namespace grcsu_patronal
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Limpa a propriedade Text dos controles especificados
            lblAliquotaResultado.Text = "";
            lblTributoResultado.Text = "";
            lblParcelaResultado.Text = "";
            lblValorAPagarResultado.Text = "";
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Cálculo da GRCSU a partir do capital social da empresa.
            MessageBox.Show("Ainda não fui implementado.", "Não pronto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Se OK, leva o usuário ao site da GRCSU da Caixa após mensagem de isenção de responsabilidade.
            if (MessageBox.Show("Ao clicar em OK, você será levado ao site da GRSCU para preenchimento dos dados e geração da guia de recolhimento, ao mesmo tempo isentando o fornecedor do software de qualquer responsabilidade quanto aos valores calculados. Consulte a documentação.", "Preenchimento da Guia na Caixa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                // Abre o navegador no site da Caixa.
                System.Diagnostics.Process.Start("https://sindical.caixa.gov.br/sitcs_internet/contribuinte/login/login.do");
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mostra o form frmSobre.
            frmSobre a = new frmSobre();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Fecha a aplicação.
            Application.Exit();
        }
    }
}
