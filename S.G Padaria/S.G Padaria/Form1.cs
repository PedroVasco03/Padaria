﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace S.G_Padaria
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Inicio;
        }
        conexao conex = new conexao();

        private void button1_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Login;
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            if (txt_UsuarioADM.Text != "" && txt_SenhaADM.Text != "")
            {
                try
                {
                    if (conex.eUserName(txt_UsuarioADM.Text.ToUpper()))
                    {
                        if (conex.eUserSenha(txt_SenhaADM.Text.ToUpper()))
                        {
                            txt_SenhaADM.Text = "";
                            txt_UsuarioADM.Text = "";
                            frm_Admin venha = new frm_Admin();
                            venha.ShowDialog();
                            
                        }
                        else
                        {
                            MessageBox.Show("Senha errada");
                        }
                    }
                    else
                    {
                        MessageBox.Show("user errado");
                    }
                }
                catch
                {
                    MessageBox.Show("Erro, ao listar os livros!");
                }
            }
            else
            {
                MessageBox.Show("Insira os dados de Login do Administrador!");
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Login;
        }
    }
}