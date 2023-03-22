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
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }
        bool sidebarExpand;
        conexao conex = new conexao();
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

        private void btn_inserirStock_Click(object sender, EventArgs e)
        {
            if (txt_NomeProduto.Text != "" && txt_PrecoProduto.Text != "")
            {
                try
                {
                    conex.InserirProuto(txt_NomeProduto.Text.ToString(), txt_PrecoProduto.Text.ToString());
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    MessageBox.Show("Erro, ao inserir o Produto!");
                }
            }
            else
            {
                MessageBox.Show("Impossível inserir sem informações corretas");
            }
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
        }

        private void btn_lucro_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Lucro;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Cadastro;
        }
    }
}
