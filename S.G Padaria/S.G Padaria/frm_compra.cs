using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace S.G_Padaria
{
    public partial class frm_compra : Form
    {
        public static ArrayList tipo_pao = new ArrayList();
        public static ArrayList preco_pao = new ArrayList();
        public static ArrayList qtd_pao = new ArrayList();
        public static ArrayList total_pao = new ArrayList();

        int tipo;
        double preco;
        public frm_compra(int tipo, double preco)
        {

            InitializeComponent();
            this.tipo = tipo;
            this.preco = preco;
            txt_tipo.Text = tipo.ToString();
            txt_preco.Text = preco.ToString();
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            if (txt_qtd.Text != "" && double.Parse(txt_qtd.Text) > 0)
            {
                tipo_pao.Add(txt_tipo.Text);
                preco_pao.Add(double.Parse(txt_preco.Text));
                qtd_pao.Add(int.Parse(txt_qtd.Text));
                total_pao.Add(double.Parse(txt_preco.Text) * int.Parse(txt_qtd.Text));
                form_pagamento pagar = new form_pagamento();
                Hide();
                pagar.ShowDialog();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_qtd.Text != "" && double.Parse(txt_qtd.Text) > 0)
            {
                tipo_pao.Add(txt_tipo.Text);
                preco_pao.Add(double.Parse(txt_preco.Text));
                qtd_pao.Add(int.Parse(txt_qtd.Text));
                total_pao.Add(double.Parse(txt_preco.Text) * int.Parse(txt_qtd.Text));
                form_add adicionar = new form_add();
                Hide();
                adicionar.ShowDialog();
            }
        }
    }
}
