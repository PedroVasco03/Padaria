using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace S.G_Padaria
{
     class conexao
    {
        private MySqlConnection BuscarConexao()
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost; user=root; password=''; database=db_padaria");
            return conexao; 
        }

        public DataTable Buscar(string query)
        {
            MySqlConnection conexao = BuscarConexao();
            conexao.Open();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexao);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela); 
            conexao.Close();

            return tabela;
        }

        public bool eUserName(string name)
        {
            bool cond = false;
            string user = "select * from TB_ADMINISTRADOR;";
            DataTable tabela = Buscar(user);
            string userName = tabela.Rows[0]["NOME"].ToString();
            if(userName== name)
            {
                 cond=true;
            }
            else
            {
                cond= false;
            }
            return cond;
        }
        public bool eUserSenha(string senha)
        {
            bool cond = false;
            string user = "select * from TB_ADMINISTRADOR;";
            DataTable tabela = Buscar(user);
            string userName = tabela.Rows[0]["SENHA"].ToString();
            if (userName == senha)
            {
                cond = true;
            }
            else
            {
                cond = false;
            }
            return cond;
        }

        public void alterarSenha(string usuario, string novaSenha)
        {
            string query = "Update tb_administrador set senha = '" + novaSenha + "' where nome = '"+usuario+"'";
            MySqlConnection conexao = BuscarConexao();
            conexao.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = query;
            comando.Connection = conexao;
            comando.ExecuteNonQuery();
            comando.Dispose();
            conexao.Close();
            MessageBox.Show("Senha Alterada com sucesso");
        }

        public void CadastrarAdm(string usuario, string senha)
        {
            MySqlConnection conexao = BuscarConexao();
            conexao.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "insert into tb_ADMINISTRADOR (NOME, SENHA) values('" + usuario + "', '" + senha + "')";
            comando.Connection = conexao;
            comando.ExecuteNonQuery();
            comando.Dispose();
            conexao.Close();
            MessageBox.Show("Novo ADM cadastrado com sucesso");
        }
    }
}
