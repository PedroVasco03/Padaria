
namespace S.G_Padaria
{
    partial class frm_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Admin));
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pg_Paginas = new Bunifu.UI.WinForms.BunifuPages();
            this.pg_Faturacao = new System.Windows.Forms.TabPage();
            this.pg_Lucro = new System.Windows.Forms.TabPage();
            this.sideBarAnimation = new System.Windows.Forms.Timer(this.components);
            this.pg_Cadastro = new System.Windows.Forms.TabPage();
            this.btn_inserirStock = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PrecoProduto = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_NomeProduto = new Guna.UI.WinForms.GunaLineTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_lucro = new System.Windows.Forms.Button();
            this.btn_faturacao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pg_Paginas.SuspendLayout();
            this.pg_Cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(89)))), ((int)(((byte)(195)))));
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(218, 700);
            this.sidebar.MinimumSize = new System.Drawing.Size(74, 700);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(74, 700);
            this.sidebar.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(-10, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 52);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_sair);
            this.panel6.Location = new System.Drawing.Point(-9, 619);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(231, 52);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_lucro);
            this.panel5.Location = new System.Drawing.Point(-9, 377);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(231, 52);
            this.panel5.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_faturacao);
            this.panel3.Location = new System.Drawing.Point(-11, 299);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 52);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(-11, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 52);
            this.panel2.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pg_Paginas);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(74, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1226, 700);
            this.panel7.TabIndex = 1;
            // 
            // pg_Paginas
            // 
            this.pg_Paginas.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pg_Paginas.AllowTransitions = true;
            this.pg_Paginas.Controls.Add(this.pg_Cadastro);
            this.pg_Paginas.Controls.Add(this.pg_Faturacao);
            this.pg_Paginas.Controls.Add(this.pg_Lucro);
            this.pg_Paginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pg_Paginas.Location = new System.Drawing.Point(0, 0);
            this.pg_Paginas.Multiline = true;
            this.pg_Paginas.Name = "pg_Paginas";
            this.pg_Paginas.Page = this.pg_Cadastro;
            this.pg_Paginas.PageIndex = 0;
            this.pg_Paginas.PageName = "pg_Cadastro";
            this.pg_Paginas.PageTitle = "Cadastro";
            this.pg_Paginas.SelectedIndex = 0;
            this.pg_Paginas.Size = new System.Drawing.Size(1226, 700);
            this.pg_Paginas.TabIndex = 0;
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
            // pg_Faturacao
            // 
            this.pg_Faturacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.pg_Faturacao.Location = new System.Drawing.Point(4, 4);
            this.pg_Faturacao.Name = "pg_Faturacao";
            this.pg_Faturacao.Padding = new System.Windows.Forms.Padding(3);
            this.pg_Faturacao.Size = new System.Drawing.Size(1218, 666);
            this.pg_Faturacao.TabIndex = 1;
            this.pg_Faturacao.Text = "Faturação";
            // 
            // pg_Lucro
            // 
            this.pg_Lucro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.pg_Lucro.Location = new System.Drawing.Point(4, 4);
            this.pg_Lucro.Name = "pg_Lucro";
            this.pg_Lucro.Size = new System.Drawing.Size(1218, 666);
            this.pg_Lucro.TabIndex = 2;
            this.pg_Lucro.Text = "Lucro";
            // 
            // sideBarAnimation
            // 
            this.sideBarAnimation.Interval = 20;
            this.sideBarAnimation.Tick += new System.EventHandler(this.sideBarAnimation_Tick);
            // 
            // pg_Cadastro
            // 
            this.pg_Cadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.pg_Cadastro.BackgroundImage = global::S.G_Padaria.Properties.Resources.Captura_de_tela_2023_03_17_003408;
            this.pg_Cadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pg_Cadastro.Controls.Add(this.btn_inserirStock);
            this.pg_Cadastro.Controls.Add(this.label2);
            this.pg_Cadastro.Controls.Add(this.label1);
            this.pg_Cadastro.Controls.Add(this.txt_PrecoProduto);
            this.pg_Cadastro.Controls.Add(this.txt_NomeProduto);
            this.pg_Cadastro.Location = new System.Drawing.Point(4, 4);
            this.pg_Cadastro.Name = "pg_Cadastro";
            this.pg_Cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.pg_Cadastro.Size = new System.Drawing.Size(1218, 666);
            this.pg_Cadastro.TabIndex = 0;
            this.pg_Cadastro.Text = "Cadastro";
            // 
            // btn_inserirStock
            // 
            this.btn_inserirStock.AnimationHoverSpeed = 0.07F;
            this.btn_inserirStock.AnimationSpeed = 0.03F;
            this.btn_inserirStock.BackColor = System.Drawing.Color.Transparent;
            this.btn_inserirStock.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(89)))), ((int)(((byte)(195)))));
            this.btn_inserirStock.BorderColor = System.Drawing.Color.Black;
            this.btn_inserirStock.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_inserirStock.FocusedColor = System.Drawing.Color.Empty;
            this.btn_inserirStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserirStock.ForeColor = System.Drawing.Color.White;
            this.btn_inserirStock.Image = global::S.G_Padaria.Properties.Resources.login_20px;
            this.btn_inserirStock.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_inserirStock.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_inserirStock.Location = new System.Drawing.Point(529, 420);
            this.btn_inserirStock.Name = "btn_inserirStock";
            this.btn_inserirStock.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.btn_inserirStock.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_inserirStock.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_inserirStock.OnHoverImage = null;
            this.btn_inserirStock.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.btn_inserirStock.Radius = 10;
            this.btn_inserirStock.Size = new System.Drawing.Size(160, 53);
            this.btn_inserirStock.TabIndex = 7;
            this.btn_inserirStock.Text = "Inerir";
            this.btn_inserirStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_inserirStock.Click += new System.EventHandler(this.btn_inserirStock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preço do produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do produto";
            // 
            // txt_PrecoProduto
            // 
            this.txt_PrecoProduto.BackColor = System.Drawing.Color.White;
            this.txt_PrecoProduto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PrecoProduto.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(89)))), ((int)(((byte)(195)))));
            this.txt_PrecoProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrecoProduto.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_PrecoProduto.Location = new System.Drawing.Point(467, 351);
            this.txt_PrecoProduto.Name = "txt_PrecoProduto";
            this.txt_PrecoProduto.PasswordChar = '\0';
            this.txt_PrecoProduto.SelectedText = "";
            this.txt_PrecoProduto.Size = new System.Drawing.Size(289, 39);
            this.txt_PrecoProduto.TabIndex = 3;
            // 
            // txt_NomeProduto
            // 
            this.txt_NomeProduto.BackColor = System.Drawing.Color.White;
            this.txt_NomeProduto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NomeProduto.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(89)))), ((int)(((byte)(195)))));
            this.txt_NomeProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeProduto.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_NomeProduto.Location = new System.Drawing.Point(467, 234);
            this.txt_NomeProduto.Name = "txt_NomeProduto";
            this.txt_NomeProduto.PasswordChar = '\0';
            this.txt_NomeProduto.SelectedText = "";
            this.txt_NomeProduto.Size = new System.Drawing.Size(289, 39);
            this.txt_NomeProduto.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::S.G_Padaria.Properties.Resources.menu_30px;
            this.button3.Location = new System.Drawing.Point(-124, -15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(342, 86);
            this.button3.TabIndex = 3;
            this.button3.Text = "Escond. legenda";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Image = global::S.G_Padaria.Properties.Resources.logout_30px;
            this.btn_sair.Location = new System.Drawing.Point(-124, -15);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(342, 86);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "Terminar sessão";
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_lucro
            // 
            this.btn_lucro.FlatAppearance.BorderSize = 0;
            this.btn_lucro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_lucro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lucro.ForeColor = System.Drawing.Color.White;
            this.btn_lucro.Image = global::S.G_Padaria.Properties.Resources.Euro_Money_30px;
            this.btn_lucro.Location = new System.Drawing.Point(-124, -15);
            this.btn_lucro.Name = "btn_lucro";
            this.btn_lucro.Size = new System.Drawing.Size(342, 86);
            this.btn_lucro.TabIndex = 3;
            this.btn_lucro.Text = "Consultar lucros";
            this.btn_lucro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_lucro.UseVisualStyleBackColor = true;
            this.btn_lucro.Click += new System.EventHandler(this.btn_lucro_Click);
            // 
            // btn_faturacao
            // 
            this.btn_faturacao.FlatAppearance.BorderSize = 0;
            this.btn_faturacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_faturacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_faturacao.ForeColor = System.Drawing.Color.White;
            this.btn_faturacao.Image = global::S.G_Padaria.Properties.Resources.Sell_Stock_30px;
            this.btn_faturacao.Location = new System.Drawing.Point(-124, -15);
            this.btn_faturacao.Name = "btn_faturacao";
            this.btn_faturacao.Size = new System.Drawing.Size(342, 86);
            this.btn_faturacao.TabIndex = 3;
            this.btn_faturacao.Text = "Efetuar Vendas";
            this.btn_faturacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_faturacao.UseVisualStyleBackColor = true;
            this.btn_faturacao.Click += new System.EventHandler(this.btn_faturacao_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::S.G_Padaria.Properties.Resources.Add_properties_30px;
            this.button1.Location = new System.Drawing.Point(-124, -15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 86);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add produto";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.sidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.sidebar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pg_Paginas.ResumeLayout(false);
            this.pg_Cadastro.ResumeLayout(false);
            this.pg_Cadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_faturacao;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_lucro;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Timer sideBarAnimation;
        private Bunifu.UI.WinForms.BunifuPages pg_Paginas;
        private System.Windows.Forms.TabPage pg_Cadastro;
        private System.Windows.Forms.TabPage pg_Faturacao;
        private System.Windows.Forms.TabPage pg_Lucro;
        private Guna.UI.WinForms.GunaButton btn_inserirStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox txt_PrecoProduto;
        private Guna.UI.WinForms.GunaLineTextBox txt_NomeProduto;
    }
}