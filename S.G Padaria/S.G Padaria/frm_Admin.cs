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
using MySql.Data.MySqlClient;

namespace S.G_Padaria
{
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }
        bool sidebarExpand;
        conexao conex = new conexao();
        private object pg_vendas;
        string dia = DateTime.Now.Date.ToString();
        public static ArrayList tipo_pao = new ArrayList();
        public static ArrayList preco_pao = new ArrayList();
        public static ArrayList qtd_pao = new ArrayList();
        public static ArrayList total_pao = new ArrayList();

        int tipo;
        double preco;
        double total = 0;

        private void sideBarAnimation_Tick(object sender, EventArgs e)
        {
            //define o minimo e maximo tamanho do sidebar

            if (sidebarExpand)
            {
                //se sidebar está expandido, minimiza
                sidebar.Width -= 40;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sideBarAnimation.Stop();
                }
            }
            else
            {
                //se sidebar está minimizado, expanda
                sidebar.Width += 40;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sideBarAnimation.Stop();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sideBarAnimation.Start();
        }



        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Tem certeza que deseja sair?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirma == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_faturacao_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Faturacao;
            pg_venda.Page = pg_produtos;
        }

        private void btn_lucro_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Lucro;
        }


        private void btn_selecionar1_Click(object sender, EventArgs e)
        {
            frm_compra compra = new frm_compra(1, 120.0);
            Hide();
            compra.ShowDialog();
        }

        private void btn_selecionar2_Click(object sender, EventArgs e)
        {
            frm_compra compra = new frm_compra(2, 40.0);
            Hide();
            compra.ShowDialog();
        }

        private void btn_selecionar3_Click(object sender, EventArgs e)
        {
            frm_compra compra = new frm_compra(3, 50.0);
            Hide();
            compra.ShowDialog();
        }

        private void pg_Lucro_Enter(object sender, EventArgs e)
        {
            MessageBox.Show(dia);
            conexao conex = new conexao();

            try
            {
                string query = "SELECT * FROM TB_PAGAMENTO";
                DataTable tabela = conex.Buscar(query);
                dgv_pagamento.DataSource = tabela;
                string query2 = "SELECT SUM(TOTAL) FROM TB_PAGAMENTO WHERE DATA_DA_VENDA = '" + dia + "';";
                DataTable tabela2 = conex.Buscar(query2);
                lbl_venda.Text = tabela.Rows[0]["SUM"].ToString();
            }
            catch
            {
                MessageBox.Show("Erro ao exibir pagamentos");
            }
        }
    }
}
