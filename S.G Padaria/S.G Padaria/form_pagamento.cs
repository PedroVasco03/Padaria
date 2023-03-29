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
    public partial class form_pagamento : Form
    {
        double total = 0;
        
        public form_pagamento()
        {
            InitializeComponent();
            foreach (double soma in frm_compra.total_pao)
            {
                total += soma;
            }
            txt_total.Text = total.ToString();
        }
        MySqlConnection conexao = new MySqlConnection("server=localhost; user=root; password=''; database=db_padaria");

        private void btn_regPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_pagamento.Text != "" && double.Parse(txt_pagamento.Text) > 0)
                {
                    double pagamento = double.Parse(txt_pagamento.Text);
                    if (pagamento >= total)
                    {
                        double troco = pagamento - total;
                        double valorPagar = total - pagamento;


                        for (int item = 0; item < frm_compra.tipo_pao.Count; item++)
                        {
                            MySqlCommand comando = new MySqlCommand();
                            conexao.Open();
                            comando.CommandText = "insert into TB_FACTURA (idproduto, quantidade, preco, data_da_venda) values('" + frm_compra.tipo_pao[item] + "', '" + frm_compra.qtd_pao[item] + "', '" + frm_compra.preco_pao[item] + "' ,'" + DateTime.Now.Date + "')";
                            comando.Connection = conexao;
                            comando.ExecuteNonQuery();
                            comando.Dispose();
                            conexao.Close();
                        }
                        MySqlCommand comando2 = new MySqlCommand();
                        conexao.Open();
                        comando2.CommandText = "insert into TB_PAGAMENTO (TOTAL, PAGAMENTO, TROCO, data_da_venda) values('" + total + "','" + pagamento + "','" + troco+ "' ,'" + DateTime.Now.Date + "')";
                        comando2.Connection = conexao;
                        comando2.ExecuteNonQuery();
                        comando2.Dispose();
                        conexao.Close();
                        frm_compra.tipo_pao.Clear();
                        frm_compra.preco_pao.Clear();
                        frm_compra.qtd_pao.Clear();
                        frm_compra.total_pao.Clear();
                        MessageBox.Show("Pagamento Efectuado com sucesso!");
                        frm_Admin admin = new frm_Admin();
                        Hide();
                        admin.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Erro: Pagamento Inválido");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
