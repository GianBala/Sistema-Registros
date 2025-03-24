namespace PROJ_01
{
    partial class Tela_Inicial_Cliente
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Inicial_Cliente));
            label1 = new Label();
            Botao_Fechar = new Button();
            SideBar = new Panel();
            Icone_Logout = new PictureBox();
            Label_Menu = new Label();
            Icone_Menu = new PictureBox();
            Fundo_Menu = new Panel();
            Label_Calendario = new Label();
            Label_Registro = new Label();
            Label_Notificacao = new Label();
            Icone_Calendario = new PictureBox();
            Icone_Registro = new PictureBox();
            Fundo_Notificacao = new Panel();
            Icone_Notificacao = new PictureBox();
            Fundo_Registro = new Panel();
            Fundo_Calendario = new Panel();
            Fundo_Logout = new Panel();
            Label_Logout = new Label();
            Timer_SideBarExpand = new System.Windows.Forms.Timer(components);
            SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Icone_Logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Icone_Menu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Icone_Calendario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Icone_Registro).BeginInit();
            Fundo_Notificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Icone_Notificacao).BeginInit();
            Fundo_Logout.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(631, 149);
            label1.Name = "label1";
            label1.Size = new Size(185, 15);
            label1.TabIndex = 0;
            label1.Text = "CLIENTE LOGADO COM SUCESSO";
            // 
            // Botao_Fechar
            // 
            Botao_Fechar.BackColor = Color.Gold;
            Botao_Fechar.FlatAppearance.BorderSize = 0;
            Botao_Fechar.FlatAppearance.MouseDownBackColor = Color.Cyan;
            Botao_Fechar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            Botao_Fechar.FlatStyle = FlatStyle.Flat;
            Botao_Fechar.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Botao_Fechar.Location = new Point(656, 75);
            Botao_Fechar.Name = "Botao_Fechar";
            Botao_Fechar.Size = new Size(125, 25);
            Botao_Fechar.TabIndex = 2;
            Botao_Fechar.Text = "Fechar";
            Botao_Fechar.UseVisualStyleBackColor = false;
            Botao_Fechar.Click += Botao_Fechar_Click;
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(37, 45, 95);
            SideBar.Controls.Add(Icone_Logout);
            SideBar.Controls.Add(Label_Menu);
            SideBar.Controls.Add(Icone_Menu);
            SideBar.Controls.Add(Fundo_Menu);
            SideBar.Controls.Add(Label_Calendario);
            SideBar.Controls.Add(Label_Registro);
            SideBar.Controls.Add(Label_Notificacao);
            SideBar.Controls.Add(Icone_Calendario);
            SideBar.Controls.Add(Icone_Registro);
            SideBar.Controls.Add(Fundo_Notificacao);
            SideBar.Controls.Add(Fundo_Registro);
            SideBar.Controls.Add(Fundo_Calendario);
            SideBar.Controls.Add(Fundo_Logout);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 0);
            SideBar.MaximumSize = new Size(186, 480);
            SideBar.MinimumSize = new Size(53, 480);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(53, 480);
            SideBar.TabIndex = 4;
            // 
            // Icone_Logout
            // 
            Icone_Logout.Cursor = Cursors.Hand;
            Icone_Logout.Image = (Image)resources.GetObject("Icone_Logout.Image");
            Icone_Logout.Location = new Point(14, 439);
            Icone_Logout.Name = "Icone_Logout";
            Icone_Logout.Size = new Size(30, 32);
            Icone_Logout.SizeMode = PictureBoxSizeMode.StretchImage;
            Icone_Logout.TabIndex = 48;
            Icone_Logout.TabStop = false;
            Icone_Logout.Click += Logout_Click;
            Icone_Logout.MouseEnter += Fundo_MouseEnter;
            Icone_Logout.MouseLeave += Fundo_MouseLeave;
            // 
            // Label_Menu
            // 
            Label_Menu.AutoSize = true;
            Label_Menu.Cursor = Cursors.Hand;
            Label_Menu.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Menu.ForeColor = SystemColors.Window;
            Label_Menu.Location = new Point(73, 30);
            Label_Menu.Name = "Label_Menu";
            Label_Menu.Size = new Size(57, 22);
            Label_Menu.TabIndex = 10;
            Label_Menu.Text = "Menu";
            Label_Menu.Click += Menu_Click;
            Label_Menu.MouseEnter += Fundo_MouseEnter;
            Label_Menu.MouseLeave += Fundo_MouseLeave;
            // 
            // Icone_Menu
            // 
            Icone_Menu.Cursor = Cursors.Hand;
            Icone_Menu.Image = (Image)resources.GetObject("Icone_Menu.Image");
            Icone_Menu.Location = new Point(12, 30);
            Icone_Menu.Name = "Icone_Menu";
            Icone_Menu.Size = new Size(27, 21);
            Icone_Menu.SizeMode = PictureBoxSizeMode.StretchImage;
            Icone_Menu.TabIndex = 1;
            Icone_Menu.TabStop = false;
            Icone_Menu.Click += Menu_Click;
            Icone_Menu.MouseEnter += Fundo_MouseEnter;
            Icone_Menu.MouseLeave += Fundo_MouseLeave;
            // 
            // Fundo_Menu
            // 
            Fundo_Menu.BackColor = Color.Transparent;
            Fundo_Menu.BackgroundImageLayout = ImageLayout.None;
            Fundo_Menu.Cursor = Cursors.Hand;
            Fundo_Menu.Location = new Point(0, 12);
            Fundo_Menu.Name = "Fundo_Menu";
            Fundo_Menu.Size = new Size(184, 58);
            Fundo_Menu.TabIndex = 13;
            Fundo_Menu.Click += Menu_Click;
            Fundo_Menu.MouseEnter += Fundo_MouseEnter;
            Fundo_Menu.MouseLeave += Fundo_MouseLeave;
            // 
            // Label_Calendario
            // 
            Label_Calendario.AutoSize = true;
            Label_Calendario.Cursor = Cursors.Hand;
            Label_Calendario.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Calendario.ForeColor = SystemColors.Window;
            Label_Calendario.Location = new Point(50, 255);
            Label_Calendario.Name = "Label_Calendario";
            Label_Calendario.Size = new Size(98, 22);
            Label_Calendario.TabIndex = 39;
            Label_Calendario.Text = "Calendário";
            Label_Calendario.Click += Calendario_Click;
            Label_Calendario.MouseEnter += Fundo_MouseEnter;
            Label_Calendario.MouseLeave += Fundo_MouseLeave;
            // 
            // Label_Registro
            // 
            Label_Registro.AutoSize = true;
            Label_Registro.Cursor = Cursors.Hand;
            Label_Registro.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Registro.ForeColor = SystemColors.Window;
            Label_Registro.Location = new Point(52, 185);
            Label_Registro.Name = "Label_Registro";
            Label_Registro.Size = new Size(85, 22);
            Label_Registro.TabIndex = 38;
            Label_Registro.Text = "Registros";
            Label_Registro.Click += Registro_Click;
            Label_Registro.MouseEnter += Fundo_MouseEnter;
            Label_Registro.MouseLeave += Fundo_MouseLeave;
            // 
            // Label_Notificacao
            // 
            Label_Notificacao.AutoSize = true;
            Label_Notificacao.Cursor = Cursors.Hand;
            Label_Notificacao.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Notificacao.ForeColor = SystemColors.Window;
            Label_Notificacao.Location = new Point(50, 118);
            Label_Notificacao.Name = "Label_Notificacao";
            Label_Notificacao.Size = new Size(107, 22);
            Label_Notificacao.TabIndex = 33;
            Label_Notificacao.Text = "Notificações";
            Label_Notificacao.Click += Notificacao_Click;
            Label_Notificacao.MouseEnter += Fundo_MouseEnter;
            Label_Notificacao.MouseLeave += Fundo_MouseLeave;
            // 
            // Icone_Calendario
            // 
            Icone_Calendario.Cursor = Cursors.Hand;
            Icone_Calendario.Image = (Image)resources.GetObject("Icone_Calendario.Image");
            Icone_Calendario.Location = new Point(12, 248);
            Icone_Calendario.Name = "Icone_Calendario";
            Icone_Calendario.Size = new Size(30, 32);
            Icone_Calendario.SizeMode = PictureBoxSizeMode.StretchImage;
            Icone_Calendario.TabIndex = 34;
            Icone_Calendario.TabStop = false;
            Icone_Calendario.Click += Calendario_Click;
            Icone_Calendario.MouseEnter += Fundo_MouseEnter;
            Icone_Calendario.MouseLeave += Fundo_MouseLeave;
            // 
            // Icone_Registro
            // 
            Icone_Registro.Cursor = Cursors.Hand;
            Icone_Registro.Image = (Image)resources.GetObject("Icone_Registro.Image");
            Icone_Registro.Location = new Point(11, 179);
            Icone_Registro.Name = "Icone_Registro";
            Icone_Registro.Size = new Size(30, 30);
            Icone_Registro.SizeMode = PictureBoxSizeMode.StretchImage;
            Icone_Registro.TabIndex = 36;
            Icone_Registro.TabStop = false;
            Icone_Registro.Click += Registro_Click;
            Icone_Registro.MouseEnter += Fundo_MouseEnter;
            Icone_Registro.MouseLeave += Fundo_MouseLeave;
            // 
            // Fundo_Notificacao
            // 
            Fundo_Notificacao.BackColor = Color.Transparent;
            Fundo_Notificacao.BackgroundImageLayout = ImageLayout.None;
            Fundo_Notificacao.Controls.Add(Icone_Notificacao);
            Fundo_Notificacao.Cursor = Cursors.Hand;
            Fundo_Notificacao.Location = new Point(1, 101);
            Fundo_Notificacao.Name = "Fundo_Notificacao";
            Fundo_Notificacao.Size = new Size(184, 58);
            Fundo_Notificacao.TabIndex = 40;
            Fundo_Notificacao.Click += Notificacao_Click;
            Fundo_Notificacao.MouseEnter += Fundo_MouseEnter;
            Fundo_Notificacao.MouseLeave += Fundo_MouseLeave;
            // 
            // Icone_Notificacao
            // 
            Icone_Notificacao.Cursor = Cursors.Hand;
            Icone_Notificacao.Image = (Image)resources.GetObject("Icone_Notificacao.Image");
            Icone_Notificacao.Location = new Point(13, 13);
            Icone_Notificacao.Name = "Icone_Notificacao";
            Icone_Notificacao.Size = new Size(24, 27);
            Icone_Notificacao.SizeMode = PictureBoxSizeMode.StretchImage;
            Icone_Notificacao.TabIndex = 0;
            Icone_Notificacao.TabStop = false;
            Icone_Notificacao.Click += Notificacao_Click;
            Icone_Notificacao.MouseEnter += Fundo_MouseEnter;
            Icone_Notificacao.MouseLeave += Fundo_MouseLeave;
            // 
            // Fundo_Registro
            // 
            Fundo_Registro.BackColor = Color.Transparent;
            Fundo_Registro.BackgroundImageLayout = ImageLayout.None;
            Fundo_Registro.Cursor = Cursors.Hand;
            Fundo_Registro.Location = new Point(1, 169);
            Fundo_Registro.Name = "Fundo_Registro";
            Fundo_Registro.Size = new Size(184, 58);
            Fundo_Registro.TabIndex = 42;
            Fundo_Registro.Click += Registro_Click;
            Fundo_Registro.MouseEnter += Fundo_MouseEnter;
            Fundo_Registro.MouseLeave += Fundo_MouseLeave;
            // 
            // Fundo_Calendario
            // 
            Fundo_Calendario.BackColor = Color.Transparent;
            Fundo_Calendario.BackgroundImageLayout = ImageLayout.None;
            Fundo_Calendario.Cursor = Cursors.Hand;
            Fundo_Calendario.Location = new Point(1, 238);
            Fundo_Calendario.Name = "Fundo_Calendario";
            Fundo_Calendario.Size = new Size(186, 58);
            Fundo_Calendario.TabIndex = 43;
            Fundo_Calendario.Click += Calendario_Click;
            Fundo_Calendario.MouseEnter += Fundo_MouseEnter;
            Fundo_Calendario.MouseLeave += Fundo_MouseLeave;
            // 
            // Fundo_Logout
            // 
            Fundo_Logout.BackColor = Color.Transparent;
            Fundo_Logout.BackgroundImageLayout = ImageLayout.None;
            Fundo_Logout.Controls.Add(Label_Logout);
            Fundo_Logout.Cursor = Cursors.Hand;
            Fundo_Logout.Location = new Point(2, 434);
            Fundo_Logout.Name = "Fundo_Logout";
            Fundo_Logout.Size = new Size(185, 47);
            Fundo_Logout.TabIndex = 45;
            Fundo_Logout.Click += Logout_Click;
            Fundo_Logout.MouseEnter += Fundo_MouseEnter;
            Fundo_Logout.MouseLeave += Fundo_MouseLeave;
            // 
            // Label_Logout
            // 
            Label_Logout.AutoSize = true;
            Label_Logout.Cursor = Cursors.Hand;
            Label_Logout.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Logout.ForeColor = SystemColors.Window;
            Label_Logout.Location = new Point(49, 10);
            Label_Logout.Name = "Label_Logout";
            Label_Logout.Size = new Size(66, 22);
            Label_Logout.TabIndex = 10;
            Label_Logout.Text = "Logout";
            Label_Logout.Click += Logout_Click;
            Label_Logout.MouseEnter += Fundo_MouseEnter;
            Label_Logout.MouseLeave += Fundo_MouseLeave;
            // 
            // Timer_SideBarExpand
            // 
            Timer_SideBarExpand.Tick += SideBarExpandir;
            // 
            // Tela_Inicial_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(895, 480);
            Controls.Add(SideBar);
            Controls.Add(Botao_Fechar);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Tela_Inicial_Cliente";
            Text = "Tela_Inicial";
            SideBar.ResumeLayout(false);
            SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Icone_Logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)Icone_Menu).EndInit();
            ((System.ComponentModel.ISupportInitialize)Icone_Calendario).EndInit();
            ((System.ComponentModel.ISupportInitialize)Icone_Registro).EndInit();
            Fundo_Notificacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Icone_Notificacao).EndInit();
            Fundo_Logout.ResumeLayout(false);
            Fundo_Logout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Botao_Fechar;
        private Panel SideBar;
        private PictureBox Icone_Menu;
        private Label Label_Menu;
        private Panel Fundo_Menu;
        private System.Windows.Forms.Timer Timer_SideBarExpand;
        private PictureBox Icone_Logout;
        private Label Label_Calendario;
        private Panel Fundo_Notificacao;
        private PictureBox Icone_Notificacao;
        private Label Label_Registro;
        private Label Label_Notificacao;
        private Panel Fundo_Registro;
        private PictureBox Icone_Calendario;
        private Panel Fundo_Calendario;
        private PictureBox Icone_Registro;
        private Panel Fundo_Logout;
        private Label Label_Logout;
    }
}