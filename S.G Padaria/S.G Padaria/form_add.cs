using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.G_Padaria
{
    public partial class form_add : Form
    {
        public form_add()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_qtd.Text != "" && double.Parse(txt_qtd.Text) > 0 && cmb_tipo.SelectedIndex != 0)
            {
                if (cmb_tipo.SelectedIndex == 1)
                {
                    frm_compra.tipo_pao.Add(1);
                    frm_compra.preco_pao.Add(double.Parse(txt_preco.Text));
                    frm_compra.qtd_pao.Add(int.Parse(txt_qtd.Text));
                    frm_compra.total_pao.Add(double.Parse(txt_preco.Text) * int.Parse(txt_qtd.Text));
                }
                if (cmb_tipo.SelectedIndex == 2)
                {
                    frm_compra.tipo_pao.Add(2);
                    frm_compra.preco_pao.Add(double.Parse(txt_preco.Text));
                    frm_compra.qtd_pao.Add(int.Parse(txt_qtd.Text));
                    frm_compra.total_pao.Add(double.Parse(txt_preco.Text) * int.Parse(txt_qtd.Text));
                }
                if (cmb_tipo.SelectedIndex == 3)
                {
                    frm_compra.tipo_pao.Add(3);
                    frm_compra.preco_pao.Add(double.Parse(txt_preco.Text));
                    frm_compra.qtd_pao.Add(int.Parse(txt_qtd.Text));
                    frm_compra.total_pao.Add(double.Parse(txt_preco.Text) * int.Parse(txt_qtd.Text));
                }
            }
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            form_pagamento pay = new form_pagamento();
            Hide();
            pay.ShowDialog();
        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipo.SelectedIndex == 1)
            {
                txt_preco.Text = "120";
            }
            else if (cmb_tipo.SelectedIndex == 2)
            {
                txt_preco.Text = "40";
            }
            else if (cmb_tipo.SelectedIndex == 3)
            {
                txt_preco.Text = "50";
            }
            else
            {
                txt_preco.Text = "";
            }
        }
    }
}
