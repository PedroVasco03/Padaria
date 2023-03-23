
namespace S.G_Padaria
{
    partial class frm_Principal
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation2 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.pg_Paginas = new Bunifu.UI.WinForms.BunifuPages();
            this.pg_Login = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pg_LoginPaginas = new Bunifu.UI.WinForms.BunifuPages();
            this.pg_logado = new System.Windows.Forms.TabPage();
            this.pg_cadasro = new System.Windows.Forms.TabPage();
            this.lbl_cadastro = new System.Windows.Forms.LinkLabel();
            this.lbl_recuperarSenha = new System.Windows.Forms.LinkLabel();
            this.btn_logar = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SenhaADM = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_UsuarioADM = new Guna.UI.WinForms.GunaLineTextBox();
            this.pg_recuperar = new System.Windows.Forms.TabPage();
            this.lbl_entrar = new System.Windows.Forms.LinkLabel();
            this.btn_cadastrar = new Guna.UI.WinForms.GunaButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_senhaNEW = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_userNEW = new Guna.UI.WinForms.GunaLineTextBox();
            this.btn_alterarSenha = new Guna.UI.WinForms.GunaButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_senha = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_usuario = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_voltar = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.pg_Paginas.SuspendLayout();
            this.pg_Login.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pg_LoginPaginas.SuspendLayout();
            this.pg_logado.SuspendLayout();
            this.pg_cadasro.SuspendLayout();
            this.pg_recuperar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pg_Paginas
            // 
            this.pg_Paginas.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pg_Paginas.AllowTransitions = false;
            this.pg_Paginas.Controls.Add(this.pg_Login);
            this.pg_Paginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pg_Paginas.Location = new System.Drawing.Point(0, 0);
            this.pg_Paginas.Margin = new System.Windows.Forms.Padding(0);
            this.pg_Paginas.Multiline = true;
            this.pg_Paginas.Name = "pg_Paginas";
            this.pg_Paginas.Page = this.pg_Login;
            this.pg_Paginas.PageIndex = 0;
            this.pg_Paginas.PageName = "pg_Login";
            this.pg_Paginas.PageTitle = "Login";
            this.pg_Paginas.SelectedIndex = 0;
            this.pg_Paginas.Size = new System.Drawing.Size(1300, 700);
            this.pg_Paginas.TabIndex = 1;
            animation2.AnimateOnlyDifferences = false;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.pg_Paginas.Transition = animation2;
            this.pg_Paginas.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // pg_Login
            // 
            this.pg_Login.Controls.Add(this.panel3);
            this.pg_Login.Location = new System.Drawing.Point(4, 4);
            this.pg_Login.Name = "pg_Login";
            this.pg_Login.Padding = new System.Windows.Forms.Padding(3);
            this.pg_Login.Size = new System.Drawing.Size(1292, 666);
            this.pg_Login.TabIndex = 1;
            this.pg_Login.Text = "Login";
            this.pg_Login.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1286, 660);
            this.panel3.TabIndex = 0;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.panel5;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaControlBox2.IconColor = System.Drawing.Color.White;
            this.gunaControlBox2.IconSize = 259F;
            this.gunaControlBox2.Location = new System.Drawing.Point(621, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(64, 70);
            this.gunaControlBox2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::S.G_Padaria.Properties.Resources.mohamed_hassouna_N4gtuEZ5gWc_unsplash__1_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.gunaControlBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(601, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 660);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.pg_LoginPaginas);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(609, 660);
            this.panel5.TabIndex = 0;
            // 
            // pg_LoginPaginas
            // 
            this.pg_LoginPaginas.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pg_LoginPaginas.AllowTransitions = true;
            this.pg_LoginPaginas.Controls.Add(this.pg_logado);
            this.pg_LoginPaginas.Controls.Add(this.pg_cadasro);
            this.pg_LoginPaginas.Controls.Add(this.pg_recuperar);
            this.pg_LoginPaginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pg_LoginPaginas.Location = new System.Drawing.Point(0, 0);
            this.pg_LoginPaginas.Multiline = true;
            this.pg_LoginPaginas.Name = "pg_LoginPaginas";
            this.pg_LoginPaginas.Page = this.pg_recuperar;
            this.pg_LoginPaginas.PageIndex = 2;
            this.pg_LoginPaginas.PageName = "pg_recuperar";
            this.pg_LoginPaginas.PageTitle = "Recuperar";
            this.pg_LoginPaginas.SelectedIndex = 0;
            this.pg_LoginPaginas.Size = new System.Drawing.Size(609, 660);
            this.pg_LoginPaginas.TabIndex = 0;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.pg_LoginPaginas.Transition = animation1;
            this.pg_LoginPaginas.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // pg_logado
            // 
            this.pg_logado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.pg_logado.Controls.Add(this.lbl_cadastro);
            this.pg_logado.Controls.Add(this.lbl_recuperarSenha);
            this.pg_logado.Controls.Add(this.btn_logar);
            this.pg_logado.Controls.Add(this.label2);
            this.pg_logado.Controls.Add(this.label3);
            this.pg_logado.Controls.Add(this.label5);
            this.pg_logado.Controls.Add(this.label4);
            this.pg_logado.Controls.Add(this.label1);
            this.pg_logado.Controls.Add(this.txt_SenhaADM);
            this.pg_logado.Controls.Add(this.txt_UsuarioADM);
            this.pg_logado.Location = new System.Drawing.Point(4, 4);
            this.pg_logado.Name = "pg_logado";
            this.pg_logado.Padding = new System.Windows.Forms.Padding(3);
            this.pg_logado.Size = new System.Drawing.Size(601, 626);
            this.pg_logado.TabIndex = 0;
            this.pg_logado.Text = "Logando";
            // 
            // pg_cadasro
            // 
            this.pg_cadasro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.pg_cadasro.Controls.Add(this.lbl_entrar);
            this.pg_cadasro.Controls.Add(this.btn_cadastrar);
            this.pg_cadasro.Controls.Add(this.label6);
            this.pg_cadasro.Controls.Add(this.label7);
            this.pg_cadasro.Controls.Add(this.label8);
            this.pg_cadasro.Controls.Add(this.label9);
            this.pg_cadasro.Controls.Add(this.label10);
            this.pg_cadasro.Controls.Add(this.txt_senhaNEW);
            this.pg_cadasro.Controls.Add(this.txt_userNEW);
            this.pg_cadasro.Location = new System.Drawing.Point(4, 4);
            this.pg_cadasro.Name = "pg_cadasro";
            this.pg_cadasro.Padding = new System.Windows.Forms.Padding(3);
            this.pg_cadasro.Size = new System.Drawing.Size(601, 626);
            this.pg_cadasro.TabIndex = 1;
            this.pg_cadasro.Text = "Cadastrando";
            // 
            // lbl_cadastro
            // 
            this.lbl_cadastro.ActiveLinkColor = System.Drawing.Color.Black;
            this.lbl_cadastro.AutoSize = true;
            this.lbl_cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cadastro.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadastro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.lbl_cadastro.Location = new System.Drawing.Point(280, 544);
            this.lbl_cadastro.Name = "lbl_cadastro";
            this.lbl_cadastro.Size = new System.Drawing.Size(109, 23);
            this.lbl_cadastro.TabIndex = 12;
            this.lbl_cadastro.TabStop = true;
            this.lbl_cadastro.Text = "Cadastrar-se";
            this.lbl_cadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_cadastro_LinkClicked);
            // 
            // lbl_recuperarSenha
            // 
            this.lbl_recuperarSenha.ActiveLinkColor = System.Drawing.Color.Black;
            this.lbl_recuperarSenha.AutoSize = true;
            this.lbl_recuperarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_recuperarSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_recuperarSenha.Location = new System.Drawing.Point(329, 375);
            this.lbl_recuperarSenha.Name = "lbl_recuperarSenha";
            this.lbl_recuperarSenha.Size = new System.Drawing.Size(151, 21);
            this.lbl_recuperarSenha.TabIndex = 13;
            this.lbl_recuperarSenha.TabStop = true;
            this.lbl_recuperarSenha.Text = "Esqueceu a senha?";
            this.lbl_recuperarSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_recuperarSenha_LinkClicked);
            // 
            // btn_logar
            // 
            this.btn_logar.AnimationHoverSpeed = 0.07F;
            this.btn_logar.AnimationSpeed = 0.03F;
            this.btn_logar.BackColor = System.Drawing.Color.Transparent;
            this.btn_logar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.btn_logar.BorderColor = System.Drawing.Color.Black;
            this.btn_logar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_logar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_logar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logar.ForeColor = System.Drawing.Color.White;
            this.btn_logar.Image = global::S.G_Padaria.Properties.Resources.login_20px;
            this.btn_logar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_logar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_logar.Location = new System.Drawing.Point(129, 433);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.btn_logar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_logar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_logar.OnHoverImage = null;
            this.btn_logar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.btn_logar.Radius = 10;
            this.btn_logar.Size = new System.Drawing.Size(160, 53);
            this.btn_logar.TabIndex = 11;
            this.btn_logar.Text = "Logar";
            this.btn_logar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bem vindo de volta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Não tem uma conta?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Entre usando nome de usuário e senha.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome de usuário";
            // 
            // txt_SenhaADM
            // 
            this.txt_SenhaADM.BackColor = System.Drawing.Color.White;
            this.txt_SenhaADM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SenhaADM.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.txt_SenhaADM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SenhaADM.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_SenhaADM.Location = new System.Drawing.Point(129, 294);
            this.txt_SenhaADM.Name = "txt_SenhaADM";
            this.txt_SenhaADM.PasswordChar = '●';
            this.txt_SenhaADM.SelectedText = "";
            this.txt_SenhaADM.Size = new System.Drawing.Size(289, 39);
            this.txt_SenhaADM.TabIndex = 4;
            this.txt_SenhaADM.UseSystemPasswordChar = true;
            // 
            // txt_UsuarioADM
            // 
            this.txt_UsuarioADM.BackColor = System.Drawing.Color.White;
            this.txt_UsuarioADM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UsuarioADM.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.txt_UsuarioADM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UsuarioADM.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_UsuarioADM.Location = new System.Drawing.Point(129, 209);
            this.txt_UsuarioADM.Name = "txt_UsuarioADM";
            this.txt_UsuarioADM.PasswordChar = '\0';
            this.txt_UsuarioADM.SelectedText = "";
            this.txt_UsuarioADM.Size = new System.Drawing.Size(289, 39);
            this.txt_UsuarioADM.TabIndex = 5;
            // 
            // pg_recuperar
            // 
            this.pg_recuperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.pg_recuperar.Controls.Add(this.lbl_voltar);
            this.pg_recuperar.Controls.Add(this.label13);
            this.pg_recuperar.Controls.Add(this.btn_alterarSenha);
            this.pg_recuperar.Controls.Add(this.label11);
            this.pg_recuperar.Controls.Add(this.label12);
            this.pg_recuperar.Controls.Add(this.label14);
            this.pg_recuperar.Controls.Add(this.label15);
            this.pg_recuperar.Controls.Add(this.txt_senha);
            this.pg_recuperar.Controls.Add(this.txt_usuario);
            this.pg_recuperar.Location = new System.Drawing.Point(4, 4);
            this.pg_recuperar.Name = "pg_recuperar";
            this.pg_recuperar.Size = new System.Drawing.Size(601, 626);
            this.pg_recuperar.TabIndex = 2;
            this.pg_recuperar.Text = "Recuperar";
            // 
            // lbl_entrar
            // 
            this.lbl_entrar.ActiveLinkColor = System.Drawing.Color.Black;
            this.lbl_entrar.AutoSize = true;
            this.lbl_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_entrar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.lbl_entrar.Location = new System.Drawing.Point(256, 511);
            this.lbl_entrar.Name = "lbl_entrar";
            this.lbl_entrar.Size = new System.Drawing.Size(59, 23);
            this.lbl_entrar.TabIndex = 22;
            this.lbl_entrar.TabStop = true;
            this.lbl_entrar.Text = "Entrar";
            this.lbl_entrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_entrar_LinkClicked);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.AnimationHoverSpeed = 0.07F;
            this.btn_cadastrar.AnimationSpeed = 0.03F;
            this.btn_cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.btn_cadastrar.BorderColor = System.Drawing.Color.Black;
            this.btn_cadastrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_cadastrar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_cadastrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Image = global::S.G_Padaria.Properties.Resources.login_20px;
            this.btn_cadastrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_cadastrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_cadastrar.Location = new System.Drawing.Point(129, 380);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.btn_cadastrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_cadastrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.OnHoverImage = null;
            this.btn_cadastrar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.btn_cadastrar.Radius = 10;
            this.btn_cadastrar.Size = new System.Drawing.Size(160, 53);
            this.btn_cadastrar.TabIndex = 21;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Senha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(348, 45);
            this.label7.TabIndex = 17;
            this.label7.Text = "Bem vindo ao sistema";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(125, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "ja tem uma conta?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(125, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(382, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Escolha um nome de usuário e  e senha a sua escolha.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(125, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Nome de usuário";
            // 
            // txt_senhaNEW
            // 
            this.txt_senhaNEW.BackColor = System.Drawing.Color.White;
            this.txt_senhaNEW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_senhaNEW.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.txt_senhaNEW.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senhaNEW.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_senhaNEW.Location = new System.Drawing.Point(129, 294);
            this.txt_senhaNEW.Name = "txt_senhaNEW";
            this.txt_senhaNEW.PasswordChar = '●';
            this.txt_senhaNEW.SelectedText = "";
            this.txt_senhaNEW.Size = new System.Drawing.Size(289, 39);
            this.txt_senhaNEW.TabIndex = 14;
            this.txt_senhaNEW.UseSystemPasswordChar = true;
            // 
            // txt_userNEW
            // 
            this.txt_userNEW.BackColor = System.Drawing.Color.White;
            this.txt_userNEW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_userNEW.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.txt_userNEW.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userNEW.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_userNEW.Location = new System.Drawing.Point(129, 209);
            this.txt_userNEW.Name = "txt_userNEW";
            this.txt_userNEW.PasswordChar = '\0';
            this.txt_userNEW.SelectedText = "";
            this.txt_userNEW.Size = new System.Drawing.Size(289, 39);
            this.txt_userNEW.TabIndex = 15;
            // 
            // btn_alterarSenha
            // 
            this.btn_alterarSenha.AnimationHoverSpeed = 0.07F;
            this.btn_alterarSenha.AnimationSpeed = 0.03F;
            this.btn_alterarSenha.BackColor = System.Drawing.Color.Transparent;
            this.btn_alterarSenha.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.btn_alterarSenha.BorderColor = System.Drawing.Color.Black;
            this.btn_alterarSenha.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_alterarSenha.FocusedColor = System.Drawing.Color.Empty;
            this.btn_alterarSenha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterarSenha.ForeColor = System.Drawing.Color.White;
            this.btn_alterarSenha.Image = null;
            this.btn_alterarSenha.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_alterarSenha.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_alterarSenha.Location = new System.Drawing.Point(224, 371);
            this.btn_alterarSenha.Name = "btn_alterarSenha";
            this.btn_alterarSenha.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.btn_alterarSenha.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_alterarSenha.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_alterarSenha.OnHoverImage = null;
            this.btn_alterarSenha.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.btn_alterarSenha.Radius = 10;
            this.btn_alterarSenha.Size = new System.Drawing.Size(160, 53);
            this.btn_alterarSenha.TabIndex = 21;
            this.btn_alterarSenha.Text = "Alterar";
            this.btn_alterarSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(158, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 21);
            this.label11.TabIndex = 16;
            this.label11.Text = "Nova senha";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(125, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(351, 45);
            this.label12.TabIndex = 17;
            this.label12.Text = "Recuperação de senha";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(129, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(262, 21);
            this.label14.TabIndex = 19;
            this.label14.Text = "Esqueceu a Senha? não se preocupe.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(158, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 21);
            this.label15.TabIndex = 20;
            this.label15.Text = "Nome de usuário";
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.Color.White;
            this.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_senha.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.txt_senha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_senha.Location = new System.Drawing.Point(162, 294);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '●';
            this.txt_senha.SelectedText = "";
            this.txt_senha.Size = new System.Drawing.Size(289, 39);
            this.txt_senha.TabIndex = 14;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.White;
            this.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_usuario.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_usuario.Location = new System.Drawing.Point(162, 209);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PasswordChar = '\0';
            this.txt_usuario.SelectedText = "";
            this.txt_usuario.Size = new System.Drawing.Size(289, 39);
            this.txt_usuario.TabIndex = 15;
            // 
            // lbl_voltar
            // 
            this.lbl_voltar.ActiveLinkColor = System.Drawing.Color.Black;
            this.lbl_voltar.AutoSize = true;
            this.lbl_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_voltar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_voltar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.lbl_voltar.Location = new System.Drawing.Point(244, 470);
            this.lbl_voltar.Name = "lbl_voltar";
            this.lbl_voltar.Size = new System.Drawing.Size(58, 23);
            this.lbl_voltar.TabIndex = 24;
            this.lbl_voltar.TabStop = true;
            this.lbl_voltar.Text = "Voltar";
            this.lbl_voltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_voltar_LinkClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(158, 470);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 21);
            this.label13.TabIndex = 23;
            this.label13.Text = "Tudo certo?";
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pg_Paginas);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pg_Paginas.ResumeLayout(false);
            this.pg_Login.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pg_LoginPaginas.ResumeLayout(false);
            this.pg_logado.ResumeLayout(false);
            this.pg_logado.PerformLayout();
            this.pg_cadasro.ResumeLayout(false);
            this.pg_cadasro.PerformLayout();
            this.pg_recuperar.ResumeLayout(false);
            this.pg_recuperar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPages pg_Paginas;
        private System.Windows.Forms.TabPage pg_Login;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.UI.WinForms.BunifuPages pg_LoginPaginas;
        private System.Windows.Forms.TabPage pg_logado;
        private System.Windows.Forms.LinkLabel lbl_cadastro;
        private System.Windows.Forms.LinkLabel lbl_recuperarSenha;
        private Guna.UI.WinForms.GunaButton btn_logar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox txt_SenhaADM;
        private Guna.UI.WinForms.GunaLineTextBox txt_UsuarioADM;
        private System.Windows.Forms.TabPage pg_cadasro;
        private System.Windows.Forms.TabPage pg_recuperar;
        private System.Windows.Forms.LinkLabel lbl_entrar;
        private Guna.UI.WinForms.GunaButton btn_cadastrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaLineTextBox txt_senhaNEW;
        private Guna.UI.WinForms.GunaLineTextBox txt_userNEW;
        private Guna.UI.WinForms.GunaButton btn_alterarSenha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Guna.UI.WinForms.GunaLineTextBox txt_senha;
        private Guna.UI.WinForms.GunaLineTextBox txt_usuario;
        private System.Windows.Forms.LinkLabel lbl_voltar;
        private System.Windows.Forms.Label label13;
    }
}

