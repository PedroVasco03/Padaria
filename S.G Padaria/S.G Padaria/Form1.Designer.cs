
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_Home = new System.Windows.Forms.Panel();
            this.pg_Paginas = new Bunifu.UI.WinForms.BunifuPages();
            this.pg_Inicio = new System.Windows.Forms.TabPage();
            this.pg_Login = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.btn_entrar = new Guna.UI.WinForms.GunaButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_logar = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SenhaADM = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_UsuarioADM = new Guna.UI.WinForms.GunaLineTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_Home.SuspendLayout();
            this.pg_Paginas.SuspendLayout();
            this.pg_Inicio.SuspendLayout();
            this.pg_Login.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnl_Home);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 700);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 54);
            this.panel2.TabIndex = 1;
            // 
            // pnl_Home
            // 
            this.pnl_Home.Controls.Add(this.btn_Home);
            this.pnl_Home.Location = new System.Drawing.Point(0, 236);
            this.pnl_Home.Name = "pnl_Home";
            this.pnl_Home.Size = new System.Drawing.Size(229, 54);
            this.pnl_Home.TabIndex = 1;
            // 
            // pg_Paginas
            // 
            this.pg_Paginas.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pg_Paginas.AllowTransitions = false;
            this.pg_Paginas.Controls.Add(this.pg_Inicio);
            this.pg_Paginas.Controls.Add(this.pg_Login);
            this.pg_Paginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pg_Paginas.Location = new System.Drawing.Point(229, 0);
            this.pg_Paginas.Margin = new System.Windows.Forms.Padding(0);
            this.pg_Paginas.Multiline = true;
            this.pg_Paginas.Name = "pg_Paginas";
            this.pg_Paginas.Page = this.pg_Inicio;
            this.pg_Paginas.PageIndex = 0;
            this.pg_Paginas.PageName = "pg_Inicio";
            this.pg_Paginas.PageTitle = "Inicio";
            this.pg_Paginas.SelectedIndex = 0;
            this.pg_Paginas.Size = new System.Drawing.Size(1071, 700);
            this.pg_Paginas.TabIndex = 1;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.pg_Paginas.Transition = animation1;
            this.pg_Paginas.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // pg_Inicio
            // 
            this.pg_Inicio.Controls.Add(this.panel4);
            this.pg_Inicio.Location = new System.Drawing.Point(4, 4);
            this.pg_Inicio.Name = "pg_Inicio";
            this.pg_Inicio.Padding = new System.Windows.Forms.Padding(3);
            this.pg_Inicio.Size = new System.Drawing.Size(1063, 666);
            this.pg_Inicio.TabIndex = 0;
            this.pg_Inicio.Text = "Inicio";
            this.pg_Inicio.UseVisualStyleBackColor = true;
            // 
            // pg_Login
            // 
            this.pg_Login.Controls.Add(this.panel3);
            this.pg_Login.Location = new System.Drawing.Point(4, 4);
            this.pg_Login.Name = "pg_Login";
            this.pg_Login.Padding = new System.Windows.Forms.Padding(3);
            this.pg_Login.Size = new System.Drawing.Size(1063, 666);
            this.pg_Login.TabIndex = 1;
            this.pg_Login.Text = "Login";
            this.pg_Login.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1057, 660);
            this.panel3.TabIndex = 0;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panel4;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.panel5;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackgroundImage = global::S.G_Padaria.Properties.Resources.Captura_de_tela_2023_03_21_215000;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.gunaControlBox1);
            this.panel4.Controls.Add(this.btn_entrar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1057, 660);
            this.panel4.TabIndex = 1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 259F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1000, -8);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(64, 70);
            this.gunaControlBox1.TabIndex = 4;
            // 
            // btn_entrar
            // 
            this.btn_entrar.AnimationHoverSpeed = 0.07F;
            this.btn_entrar.AnimationSpeed = 0.03F;
            this.btn_entrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_entrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.btn_entrar.BorderColor = System.Drawing.Color.Black;
            this.btn_entrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_entrar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_entrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.Color.White;
            this.btn_entrar.Image = global::S.G_Padaria.Properties.Resources.login_20px;
            this.btn_entrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_entrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_entrar.Location = new System.Drawing.Point(343, 295);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.btn_entrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_entrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_entrar.OnHoverImage = null;
            this.btn_entrar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.btn_entrar.Radius = 10;
            this.btn_entrar.Size = new System.Drawing.Size(179, 70);
            this.btn_entrar.TabIndex = 3;
            this.btn_entrar.Text = "Entrar Agora";
            this.btn_entrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::S.G_Padaria.Properties.Resources._this;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.gunaControlBox2);
            this.panel5.Controls.Add(this.btn_logar);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txt_SenhaADM);
            this.panel5.Controls.Add(this.txt_UsuarioADM);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1057, 660);
            this.panel5.TabIndex = 0;
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
            this.btn_logar.Location = new System.Drawing.Point(296, 405);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.btn_logar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_logar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_logar.OnHoverImage = null;
            this.btn_logar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.btn_logar.Radius = 10;
            this.btn_logar.Size = new System.Drawing.Size(160, 53);
            this.btn_logar.TabIndex = 2;
            this.btn_logar.Text = "Logar";
            this.btn_logar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome de usuário";
            // 
            // txt_SenhaADM
            // 
            this.txt_SenhaADM.BackColor = System.Drawing.Color.White;
            this.txt_SenhaADM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SenhaADM.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.txt_SenhaADM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SenhaADM.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_SenhaADM.Location = new System.Drawing.Point(224, 343);
            this.txt_SenhaADM.Name = "txt_SenhaADM";
            this.txt_SenhaADM.PasswordChar = '●';
            this.txt_SenhaADM.SelectedText = "";
            this.txt_SenhaADM.Size = new System.Drawing.Size(289, 39);
            this.txt_SenhaADM.TabIndex = 0;
            this.txt_SenhaADM.UseSystemPasswordChar = true;
            // 
            // txt_UsuarioADM
            // 
            this.txt_UsuarioADM.BackColor = System.Drawing.Color.White;
            this.txt_UsuarioADM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UsuarioADM.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.txt_UsuarioADM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UsuarioADM.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_UsuarioADM.Location = new System.Drawing.Point(224, 234);
            this.txt_UsuarioADM.Name = "txt_UsuarioADM";
            this.txt_UsuarioADM.PasswordChar = '\0';
            this.txt_UsuarioADM.SelectedText = "";
            this.txt_UsuarioADM.Size = new System.Drawing.Size(289, 39);
            this.txt_UsuarioADM.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(148)))), ((int)(((byte)(91)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::S.G_Padaria.Properties.Resources.Administrator_Male_40px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-9, -17);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(246, 82);
            this.button1.TabIndex = 2;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(148)))), ((int)(((byte)(91)))));
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Image = global::S.G_Padaria.Properties.Resources.home_40px;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(-9, -15);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_Home.Size = new System.Drawing.Size(238, 82);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.Text = "Início";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::S.G_Padaria.Properties.Resources.bread_100px;
            this.pictureBox1.Location = new System.Drawing.Point(64, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaControlBox2.IconColor = System.Drawing.Color.White;
            this.gunaControlBox2.IconSize = 259F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1000, -7);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(64, 70);
            this.gunaControlBox2.TabIndex = 5;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pg_Paginas);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnl_Home.ResumeLayout(false);
            this.pg_Paginas.ResumeLayout(false);
            this.pg_Inicio.ResumeLayout(false);
            this.pg_Login.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_Home;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuPages pg_Paginas;
        private System.Windows.Forms.TabPage pg_Inicio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage pg_Login;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI.WinForms.GunaButton btn_logar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox txt_SenhaADM;
        private Guna.UI.WinForms.GunaLineTextBox txt_UsuarioADM;
        private Guna.UI.WinForms.GunaButton btn_entrar;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
    }
}

