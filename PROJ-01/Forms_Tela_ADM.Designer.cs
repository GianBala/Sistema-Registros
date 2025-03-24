using System.Windows.Forms;

namespace PROJ_01
{
    partial class Tela_Inicial_ADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Inicial_ADM));
            SideBar = new Panel();
            Icone_Logout = new PictureBox();
            Label_Cadastro = new Label();
            Icone_Cadastro = new PictureBox();
            Label_Menu = new Label();
            Label_Calendario = new Label();
            Label_Registro = new Label();
            Label_Msg = new Label();
            Label_Notificacao = new Label();
            Icone_Calendario = new PictureBox();
            Icone_Registro = new PictureBox();
            Icone_Msg = new PictureBox();
            Icone_Menu = new PictureBox();
            Fundo_Notificacao = new Panel();
            Icone_Notificacao = new PictureBox();
            Fundo_Msg = new Panel();
            Fundo_Registro = new Panel();
            Fundo_Calendario = new Panel();
            Fundo_Menu = new Panel();
            Fundo_Cadastro = new Panel();
            Fundo_Logout = new Panel();
            Label_Logout = new Label();
            Timer_SideBarExpand = new System.Windows.Forms.Timer(components);
            Botao_Nova_Notificacao = new Button();
            label1 = new Label();
            Layout_Lista_Notificacao = new FlowLayoutPanel();
            Preview_Notificacao_0 = new Panel();
            Fundo_Remetente_Notificacao_0 = new Panel();
            Label_Remetente_Notificacao_0 = new Label();
            Fundo_Titulo_Notificacao_0 = new Panel();
            Label_Titulo_Notificacao_0 = new Label();
            Fundo_Preview_Msg_Notificacao_0 = new Panel();
            Label_Preview_Msg_Notificacao_0 = new Label();
            Preview_Notificacao_1 = new Panel();
            Fundo_Titulo_Notificacao_1 = new Panel();
            Label_Titulo_Notificacao_1 = new Label();
            Fundo_Remetente_Notificacao_1 = new Panel();
            Label_Remetente_Notificacao_1 = new Label();
            Fundo_Preview_Msg_Notificacao_1 = new Panel();
            Label_Preview_Msg_Notificacao_1 = new Label();
            Fundo_Notificacao_Completa = new Panel();
            Fundo_Msg_Notificacao_Completa = new Panel();
            Label_Msg_Notificacao_Completa = new Label();
            Fundo_Titulo_Notificacao_Completa = new Panel();
            Label_Titulo_Notificacao_Completa = new Label();
            Fundo_Remetente_Notificacao_Completa = new Panel();
            Label_Remetente_Notificacao_Completa = new Label();
            SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Icone_Logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Icone_Cadastro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Icone_Calendario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Icone_Registro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Icone_Msg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Icone_Menu).BeginInit();
            Fundo_Notificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Icone_Notificacao).BeginInit();
            Fundo_Logout.SuspendLayout();
            Layout_Lista_Notificacao.SuspendLayout();
            Preview_Notificacao_0.SuspendLayout();
            Fundo_Remetente_Notificacao_0.SuspendLayout();
            Fundo_Titulo_Notificacao_0.SuspendLayout();
            Fundo_Preview_Msg_Notificacao_0.SuspendLayout();
            Preview_Notificacao_1.SuspendLayout();
            Fundo_Titulo_Notificacao_1.SuspendLayout();
            Fundo_Remetente_Notificacao_1.SuspendLayout();
            Fundo_Preview_Msg_Notificacao_1.SuspendLayout();
            Fundo_Notificacao_Completa.SuspendLayout();
            Fundo_Msg_Notificacao_Completa.SuspendLayout();
            Fundo_Titulo_Notificacao_Completa.SuspendLayout();
            Fundo_Remetente_Notificacao_Completa.SuspendLayout();
            SuspendLayout();
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(37, 45, 95);
            SideBar.Controls.Add(Icone_Logout);
            SideBar.Controls.Add(Label_Cadastro);
            SideBar.Controls.Add(Icone_Cadastro);
            SideBar.Controls.Add(Label_Menu);
            SideBar.Controls.Add(Label_Calendario);
            SideBar.Controls.Add(Label_Registro);
            SideBar.Controls.Add(Label_Msg);
            SideBar.Controls.Add(Label_Notificacao);
            SideBar.Controls.Add(Icone_Calendario);
            SideBar.Controls.Add(Icone_Registro);
            SideBar.Controls.Add(Icone_Msg);
            SideBar.Controls.Add(Icone_Menu);
            SideBar.Controls.Add(Fundo_Notificacao);
            SideBar.Controls.Add(Fundo_Msg);
            SideBar.Controls.Add(Fundo_Registro);
            SideBar.Controls.Add(Fundo_Calendario);
            SideBar.Controls.Add(Fundo_Menu);
            SideBar.Controls.Add(Fundo_Cadastro);
            SideBar.Controls.Add(Fundo_Logout);
            SideBar.Location = new Point(0, 0);
            SideBar.MaximumSize = new Size(186, 480);
            SideBar.MinimumSize = new Size(53, 480);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(53, 480);
            SideBar.TabIndex = 4;
            SideBar.Paint += SideBar_Paint;
            // 
            // Icone_Logout
            // 
            Icone_Logout.Cursor = Cursors.Hand;
            Icone_Logout.Image = (Image)resources.GetObject("Icone_Logout.Image");
            Icone_Logout.Location = new Point(14, 439);
            Icone_Logout.Name = "Icone_Logout";
            Icone_Logout.Size = new Size(30, 32);
            Icone_Logout.SizeMode = PictureBoxSizeMode.StretchImage;
            Icone_Logout.TabIndex = 16;
            Icone_Logout.TabStop = false;
            // 
            // Label_Cadastro
            // 
            Label_Cadastro.AutoSize = true;
            Label_Cadastro.Cursor = Cursors.Hand;
            Label_Cadastro.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Cadastro.ForeColor = SystemColors.Window;
            Label_Cadastro.Location = new Point(53, 185);
            Label_Cadastro.Name = "Label_Cadastro";
            Label_Cadastro.Size = new Size(90, 22);
            Label_Cadastro.TabIndex = 15;
            Label_Cadastro.Text = "Cadastros";
            // 
            // Icone_Cadastro
            // 
            Icone_Cadastro.Cursor = Cursors.Hand;
            Icone_Cadastro.Image = (Image)resources.GetObject("Icone_Cadastro.Image");
            Icone_Cadastro.Location = new Point(11, 181);
            Icone_Cadastro.Name = "Icone_Cadastro";
            Icone_Cadastro.Size = new Size(32, 28);
            Icone_Cadastro.SizeMode = PictureBoxSizeMode.StretchImage;
            Icone_Cadastro.TabIndex = 14;
            Icone_Cadastro.TabStop = false;
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
            // 
            // Label_Calendario
            // 
            Label_Calendario.AutoSize = true;
            Label_Calendario.Cursor = Cursors.Hand;
            Label_Calendario.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Calendario.ForeColor = SystemColors.Window;
            Label_Calendario.Location = new Point(50, 386);
            Label_Calendario.Name = "Label_Calendario";
            Label_Calendario.Size = new Size(98, 22);
            Label_Calendario.TabIndex = 9;
            Label_Calendario.Text = "Calendário";
            // 
            // Label_Registro
            // 
            Label_Registro.AutoSize = true;
            Label_Registro.Cursor = Cursors.Hand;
            Label_Registro.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Registro.ForeColor = SystemColors.Window;
            Label_Registro.Location = new Point(51, 316);
            Label_Registro.Name = "Label_Registro";
            Label_Registro.Size = new Size(85, 22);
            Label_Registro.TabIndex = 8;
            Label_Registro.Text = "Registros";
            // 
            // Label_Msg
            // 
            Label_Msg.AutoSize = true;
            Label_Msg.Cursor = Cursors.Hand;
            Label_Msg.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Msg.ForeColor = SystemColors.Window;
            Label_Msg.Location = new Point(50, 250);
            Label_Msg.Name = "Label_Msg";
            Label_Msg.Size = new Size(100, 22);
            Label_Msg.TabIndex = 7;
            Label_Msg.Text = "Mensagens";
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
            Label_Notificacao.TabIndex = 5;
            Label_Notificacao.Text = "Notificações";
            // 
            // Icone_Calendario
            // 
            Icone_Calendario.Cursor = Cursors.Hand;
            Icone_Calendario.Image = (Image)resources.GetObject("Icone_Calendario.Image");
            Icone_Calendario.Location = new Point(12, 380);
            Icone_Calendario.Name = "Icone_Calendario";
            Icone_Calendario.Size = new Size(30, 32);
            Icone_Calendario.SizeMode = PictureBoxSizeMode.StretchImage;
            Icone_Calendario.TabIndex = 5;
            Icone_Calendario.TabStop = false;
            // 
            // Icone_Registro
            // 
            Icone_Registro.Cursor = Cursors.Hand;
            Icone_Registro.Image = (Image)resources.GetObject("Icone_Registro.Image");
            Icone_Registro.Location = new Point(11, 311);
            Icone_Registro.Name = "Icone_Registro";
            Icone_Registro.Size = new Size(30, 30);
            Icone_Registro.SizeMode = PictureBoxSizeMode.StretchImage;
            Icone_Registro.TabIndex = 6;
            Icone_Registro.TabStop = false;
            // 
            // Icone_Msg
            // 
            Icone_Msg.Cursor = Cursors.Hand;
            Icone_Msg.Image = (Image)resources.GetObject("Icone_Msg.Image");
            Icone_Msg.Location = new Point(13, 251);
            Icone_Msg.Name = "Icone_Msg";
            Icone_Msg.Size = new Size(27, 21);
            Icone_Msg.SizeMode = PictureBoxSizeMode.StretchImage;
            Icone_Msg.TabIndex = 5;
            Icone_Msg.TabStop = false;
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
            Fundo_Notificacao.TabIndex = 11;
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
            // 
            // Fundo_Msg
            // 
            Fundo_Msg.BackColor = Color.Transparent;
            Fundo_Msg.BackgroundImageLayout = ImageLayout.None;
            Fundo_Msg.Cursor = Cursors.Hand;
            Fundo_Msg.Location = new Point(0, 233);
            Fundo_Msg.Name = "Fundo_Msg";
            Fundo_Msg.Size = new Size(184, 58);
            Fundo_Msg.TabIndex = 12;
            // 
            // Fundo_Registro
            // 
            Fundo_Registro.BackColor = Color.Transparent;
            Fundo_Registro.BackgroundImageLayout = ImageLayout.None;
            Fundo_Registro.Cursor = Cursors.Hand;
            Fundo_Registro.Location = new Point(0, 300);
            Fundo_Registro.Name = "Fundo_Registro";
            Fundo_Registro.Size = new Size(184, 58);
            Fundo_Registro.TabIndex = 12;
            // 
            // Fundo_Calendario
            // 
            Fundo_Calendario.BackColor = Color.Transparent;
            Fundo_Calendario.BackgroundImageLayout = ImageLayout.None;
            Fundo_Calendario.Cursor = Cursors.Hand;
            Fundo_Calendario.Location = new Point(0, 369);
            Fundo_Calendario.Name = "Fundo_Calendario";
            Fundo_Calendario.Size = new Size(186, 58);
            Fundo_Calendario.TabIndex = 12;
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
            // 
            // Fundo_Cadastro
            // 
            Fundo_Cadastro.BackColor = Color.Transparent;
            Fundo_Cadastro.BackgroundImageLayout = ImageLayout.None;
            Fundo_Cadastro.Cursor = Cursors.Hand;
            Fundo_Cadastro.Location = new Point(1, 167);
            Fundo_Cadastro.Name = "Fundo_Cadastro";
            Fundo_Cadastro.Size = new Size(184, 58);
            Fundo_Cadastro.TabIndex = 13;
            // 
            // Fundo_Logout
            // 
            Fundo_Logout.BackColor = Color.Transparent;
            Fundo_Logout.BackgroundImageLayout = ImageLayout.None;
            Fundo_Logout.Controls.Add(Label_Logout);
            Fundo_Logout.Cursor = Cursors.Hand;
            Fundo_Logout.Location = new Point(1, 433);
            Fundo_Logout.Name = "Fundo_Logout";
            Fundo_Logout.Size = new Size(185, 47);
            Fundo_Logout.TabIndex = 13;
            // 
            // Label_Logout
            // 
            Label_Logout.AutoSize = true;
            Label_Logout.Cursor = Cursors.Hand;
            Label_Logout.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Logout.ForeColor = SystemColors.Window;
            Label_Logout.Location = new Point(50, 11);
            Label_Logout.Name = "Label_Logout";
            Label_Logout.Size = new Size(66, 22);
            Label_Logout.TabIndex = 10;
            Label_Logout.Text = "Logout";
            // 
            // Timer_SideBarExpand
            // 
            Timer_SideBarExpand.Tick += SideBarExpandir;
            // 
            // Botao_Nova_Notificacao
            // 
            Botao_Nova_Notificacao.BackColor = Color.Gold;
            Botao_Nova_Notificacao.FlatAppearance.BorderSize = 0;
            Botao_Nova_Notificacao.FlatAppearance.MouseDownBackColor = Color.Cyan;
            Botao_Nova_Notificacao.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            Botao_Nova_Notificacao.FlatStyle = FlatStyle.Flat;
            Botao_Nova_Notificacao.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Botao_Nova_Notificacao.Location = new Point(324, 43);
            Botao_Nova_Notificacao.Name = "Botao_Nova_Notificacao";
            Botao_Nova_Notificacao.Size = new Size(125, 25);
            Botao_Nova_Notificacao.TabIndex = 5;
            Botao_Nova_Notificacao.Text = "Nova Notificação";
            Botao_Nova_Notificacao.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(305, 16);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 0;
            label1.Text = "ADM LOGADO COM SUCESSO";
            label1.Click += label1_Click;
            // 
            // Layout_Lista_Notificacao
            // 
            Layout_Lista_Notificacao.AutoScroll = true;
            Layout_Lista_Notificacao.BackColor = Color.Gainsboro;
            Layout_Lista_Notificacao.Controls.Add(Preview_Notificacao_0);
            Layout_Lista_Notificacao.Controls.Add(Preview_Notificacao_1);
            Layout_Lista_Notificacao.Location = new Point(187, 0);
            Layout_Lista_Notificacao.Name = "Layout_Lista_Notificacao";
            Layout_Lista_Notificacao.Size = new Size(221, 480);
            Layout_Lista_Notificacao.TabIndex = 6;
            // 
            // Preview_Notificacao_0
            // 
            Preview_Notificacao_0.BackColor = Color.FromArgb(37, 45, 95);
            Preview_Notificacao_0.Controls.Add(Fundo_Remetente_Notificacao_0);
            Preview_Notificacao_0.Controls.Add(Fundo_Titulo_Notificacao_0);
            Preview_Notificacao_0.Controls.Add(Fundo_Preview_Msg_Notificacao_0);
            Preview_Notificacao_0.Cursor = Cursors.Hand;
            Preview_Notificacao_0.Location = new Point(3, 3);
            Preview_Notificacao_0.Name = "Preview_Notificacao_0";
            Preview_Notificacao_0.Size = new Size(197, 100);
            Preview_Notificacao_0.TabIndex = 1;
            // 
            // Fundo_Remetente_Notificacao_0
            // 
            Fundo_Remetente_Notificacao_0.BackColor = Color.FromArgb(59, 66, 108);
            Fundo_Remetente_Notificacao_0.Controls.Add(Label_Remetente_Notificacao_0);
            Fundo_Remetente_Notificacao_0.Cursor = Cursors.Hand;
            Fundo_Remetente_Notificacao_0.ForeColor = SystemColors.Window;
            Fundo_Remetente_Notificacao_0.Location = new Point(5, 5);
            Fundo_Remetente_Notificacao_0.Name = "Fundo_Remetente_Notificacao_0";
            Fundo_Remetente_Notificacao_0.Size = new Size(186, 22);
            Fundo_Remetente_Notificacao_0.TabIndex = 5;
            // 
            // Label_Remetente_Notificacao_0
            // 
            Label_Remetente_Notificacao_0.AutoSize = true;
            Label_Remetente_Notificacao_0.BackColor = Color.Transparent;
            Label_Remetente_Notificacao_0.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Remetente_Notificacao_0.Location = new Point(5, 3);
            Label_Remetente_Notificacao_0.Name = "Label_Remetente_Notificacao_0";
            Label_Remetente_Notificacao_0.Size = new Size(32, 14);
            Label_Remetente_Notificacao_0.TabIndex = 0;
            Label_Remetente_Notificacao_0.Text = "John";
            // 
            // Fundo_Titulo_Notificacao_0
            // 
            Fundo_Titulo_Notificacao_0.BackColor = Color.FromArgb(59, 66, 108);
            Fundo_Titulo_Notificacao_0.Controls.Add(Label_Titulo_Notificacao_0);
            Fundo_Titulo_Notificacao_0.Cursor = Cursors.Hand;
            Fundo_Titulo_Notificacao_0.Location = new Point(5, 32);
            Fundo_Titulo_Notificacao_0.Name = "Fundo_Titulo_Notificacao_0";
            Fundo_Titulo_Notificacao_0.Size = new Size(186, 22);
            Fundo_Titulo_Notificacao_0.TabIndex = 6;
            // 
            // Label_Titulo_Notificacao_0
            // 
            Label_Titulo_Notificacao_0.AutoSize = true;
            Label_Titulo_Notificacao_0.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Titulo_Notificacao_0.ForeColor = SystemColors.Window;
            Label_Titulo_Notificacao_0.Location = new Point(4, 3);
            Label_Titulo_Notificacao_0.Name = "Label_Titulo_Notificacao_0";
            Label_Titulo_Notificacao_0.Size = new Size(74, 14);
            Label_Titulo_Notificacao_0.TabIndex = 3;
            Label_Titulo_Notificacao_0.Text = "La ele 1000x";
            // 
            // Fundo_Preview_Msg_Notificacao_0
            // 
            Fundo_Preview_Msg_Notificacao_0.BackColor = Color.FromArgb(59, 66, 108);
            Fundo_Preview_Msg_Notificacao_0.Controls.Add(Label_Preview_Msg_Notificacao_0);
            Fundo_Preview_Msg_Notificacao_0.Cursor = Cursors.Hand;
            Fundo_Preview_Msg_Notificacao_0.Location = new Point(5, 58);
            Fundo_Preview_Msg_Notificacao_0.Name = "Fundo_Preview_Msg_Notificacao_0";
            Fundo_Preview_Msg_Notificacao_0.Size = new Size(186, 36);
            Fundo_Preview_Msg_Notificacao_0.TabIndex = 7;
            // 
            // Label_Preview_Msg_Notificacao_0
            // 
            Label_Preview_Msg_Notificacao_0.AutoSize = true;
            Label_Preview_Msg_Notificacao_0.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Preview_Msg_Notificacao_0.ForeColor = SystemColors.Window;
            Label_Preview_Msg_Notificacao_0.Location = new Point(4, 3);
            Label_Preview_Msg_Notificacao_0.MaximumSize = new Size(181, 30);
            Label_Preview_Msg_Notificacao_0.Name = "Label_Preview_Msg_Notificacao_0";
            Label_Preview_Msg_Notificacao_0.Size = new Size(141, 14);
            Label_Preview_Msg_Notificacao_0.TabIndex = 4;
            Label_Preview_Msg_Notificacao_0.Text = "Vou te mandar video laele";
            // 
            // Preview_Notificacao_1
            // 
            Preview_Notificacao_1.BackColor = Color.FromArgb(37, 45, 95);
            Preview_Notificacao_1.Controls.Add(Fundo_Titulo_Notificacao_1);
            Preview_Notificacao_1.Controls.Add(Fundo_Remetente_Notificacao_1);
            Preview_Notificacao_1.Controls.Add(Fundo_Preview_Msg_Notificacao_1);
            Preview_Notificacao_1.Cursor = Cursors.Hand;
            Preview_Notificacao_1.Location = new Point(3, 109);
            Preview_Notificacao_1.Name = "Preview_Notificacao_1";
            Preview_Notificacao_1.Size = new Size(197, 100);
            Preview_Notificacao_1.TabIndex = 0;
            // 
            // Fundo_Titulo_Notificacao_1
            // 
            Fundo_Titulo_Notificacao_1.BackColor = Color.FromArgb(59, 66, 108);
            Fundo_Titulo_Notificacao_1.Controls.Add(Label_Titulo_Notificacao_1);
            Fundo_Titulo_Notificacao_1.Cursor = Cursors.Hand;
            Fundo_Titulo_Notificacao_1.Location = new Point(5, 32);
            Fundo_Titulo_Notificacao_1.Name = "Fundo_Titulo_Notificacao_1";
            Fundo_Titulo_Notificacao_1.Size = new Size(186, 22);
            Fundo_Titulo_Notificacao_1.TabIndex = 9;
            // 
            // Label_Titulo_Notificacao_1
            // 
            Label_Titulo_Notificacao_1.AutoSize = true;
            Label_Titulo_Notificacao_1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Titulo_Notificacao_1.ForeColor = SystemColors.Window;
            Label_Titulo_Notificacao_1.Location = new Point(4, 3);
            Label_Titulo_Notificacao_1.Name = "Label_Titulo_Notificacao_1";
            Label_Titulo_Notificacao_1.Size = new Size(115, 14);
            Label_Titulo_Notificacao_1.TabIndex = 3;
            Label_Titulo_Notificacao_1.Text = "Guia da Bipolaridade";
            // 
            // Fundo_Remetente_Notificacao_1
            // 
            Fundo_Remetente_Notificacao_1.BackColor = Color.FromArgb(59, 66, 108);
            Fundo_Remetente_Notificacao_1.Controls.Add(Label_Remetente_Notificacao_1);
            Fundo_Remetente_Notificacao_1.Cursor = Cursors.Hand;
            Fundo_Remetente_Notificacao_1.Location = new Point(5, 5);
            Fundo_Remetente_Notificacao_1.Name = "Fundo_Remetente_Notificacao_1";
            Fundo_Remetente_Notificacao_1.Size = new Size(186, 22);
            Fundo_Remetente_Notificacao_1.TabIndex = 8;
            // 
            // Label_Remetente_Notificacao_1
            // 
            Label_Remetente_Notificacao_1.AutoSize = true;
            Label_Remetente_Notificacao_1.BackColor = Color.Transparent;
            Label_Remetente_Notificacao_1.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Remetente_Notificacao_1.ForeColor = SystemColors.Window;
            Label_Remetente_Notificacao_1.Location = new Point(5, 3);
            Label_Remetente_Notificacao_1.Name = "Label_Remetente_Notificacao_1";
            Label_Remetente_Notificacao_1.Size = new Size(45, 14);
            Label_Remetente_Notificacao_1.TabIndex = 0;
            Label_Remetente_Notificacao_1.Text = "Herlan";
            // 
            // Fundo_Preview_Msg_Notificacao_1
            // 
            Fundo_Preview_Msg_Notificacao_1.BackColor = Color.FromArgb(59, 66, 108);
            Fundo_Preview_Msg_Notificacao_1.Controls.Add(Label_Preview_Msg_Notificacao_1);
            Fundo_Preview_Msg_Notificacao_1.Cursor = Cursors.Hand;
            Fundo_Preview_Msg_Notificacao_1.Location = new Point(5, 58);
            Fundo_Preview_Msg_Notificacao_1.Name = "Fundo_Preview_Msg_Notificacao_1";
            Fundo_Preview_Msg_Notificacao_1.Size = new Size(186, 36);
            Fundo_Preview_Msg_Notificacao_1.TabIndex = 10;
            // 
            // Label_Preview_Msg_Notificacao_1
            // 
            Label_Preview_Msg_Notificacao_1.AutoSize = true;
            Label_Preview_Msg_Notificacao_1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Preview_Msg_Notificacao_1.ForeColor = SystemColors.Window;
            Label_Preview_Msg_Notificacao_1.Location = new Point(4, 3);
            Label_Preview_Msg_Notificacao_1.MaximumSize = new Size(181, 30);
            Label_Preview_Msg_Notificacao_1.Name = "Label_Preview_Msg_Notificacao_1";
            Label_Preview_Msg_Notificacao_1.Size = new Size(163, 28);
            Label_Preview_Msg_Notificacao_1.TabIndex = 4;
            Label_Preview_Msg_Notificacao_1.Text = "Capitulo 1 - Falte aula mesmo falando que vai pra aula";
            // 
            // Fundo_Notificacao_Completa
            // 
            Fundo_Notificacao_Completa.BackColor = Color.Wheat;
            Fundo_Notificacao_Completa.Controls.Add(Fundo_Msg_Notificacao_Completa);
            Fundo_Notificacao_Completa.Controls.Add(Botao_Nova_Notificacao);
            Fundo_Notificacao_Completa.Controls.Add(label1);
            Fundo_Notificacao_Completa.Controls.Add(Fundo_Titulo_Notificacao_Completa);
            Fundo_Notificacao_Completa.Controls.Add(Fundo_Remetente_Notificacao_Completa);
            Fundo_Notificacao_Completa.Location = new Point(410, 2);
            Fundo_Notificacao_Completa.Name = "Fundo_Notificacao_Completa";
            Fundo_Notificacao_Completa.Size = new Size(485, 478);
            Fundo_Notificacao_Completa.TabIndex = 7;
            Fundo_Notificacao_Completa.Paint += Fundo_Notificacao_Completa_Paint;
            // 
            // Fundo_Msg_Notificacao_Completa
            // 
            Fundo_Msg_Notificacao_Completa.BackColor = Color.Gainsboro;
            Fundo_Msg_Notificacao_Completa.Controls.Add(Label_Msg_Notificacao_Completa);
            Fundo_Msg_Notificacao_Completa.Location = new Point(14, 123);
            Fundo_Msg_Notificacao_Completa.Name = "Fundo_Msg_Notificacao_Completa";
            Fundo_Msg_Notificacao_Completa.Size = new Size(459, 343);
            Fundo_Msg_Notificacao_Completa.TabIndex = 6;
            // 
            // Label_Msg_Notificacao_Completa
            // 
            Label_Msg_Notificacao_Completa.AutoSize = true;
            Label_Msg_Notificacao_Completa.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Msg_Notificacao_Completa.Location = new Point(7, 12);
            Label_Msg_Notificacao_Completa.MaximumSize = new Size(450, 338);
            Label_Msg_Notificacao_Completa.Name = "Label_Msg_Notificacao_Completa";
            Label_Msg_Notificacao_Completa.Size = new Size(180, 14);
            Label_Msg_Notificacao_Completa.TabIndex = 2;
            Label_Msg_Notificacao_Completa.Text = "Olá Joyce, sua filha caiu do predio\r\n";
            // 
            // Fundo_Titulo_Notificacao_Completa
            // 
            Fundo_Titulo_Notificacao_Completa.BackColor = Color.Gainsboro;
            Fundo_Titulo_Notificacao_Completa.Controls.Add(Label_Titulo_Notificacao_Completa);
            Fundo_Titulo_Notificacao_Completa.Location = new Point(14, 65);
            Fundo_Titulo_Notificacao_Completa.Name = "Fundo_Titulo_Notificacao_Completa";
            Fundo_Titulo_Notificacao_Completa.Size = new Size(265, 37);
            Fundo_Titulo_Notificacao_Completa.TabIndex = 1;
            // 
            // Label_Titulo_Notificacao_Completa
            // 
            Label_Titulo_Notificacao_Completa.AutoSize = true;
            Label_Titulo_Notificacao_Completa.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Titulo_Notificacao_Completa.Location = new Point(9, 12);
            Label_Titulo_Notificacao_Completa.Name = "Label_Titulo_Notificacao_Completa";
            Label_Titulo_Notificacao_Completa.Size = new Size(247, 14);
            Label_Titulo_Notificacao_Completa.TabIndex = 8;
            Label_Titulo_Notificacao_Completa.Text = "WWWWWWWWWWWWWWWWWWWW";
            Label_Titulo_Notificacao_Completa.Click += Label_Titulo_Notificacao_Completa_Click;
            // 
            // Fundo_Remetente_Notificacao_Completa
            // 
            Fundo_Remetente_Notificacao_Completa.BackColor = Color.Gainsboro;
            Fundo_Remetente_Notificacao_Completa.Controls.Add(Label_Remetente_Notificacao_Completa);
            Fundo_Remetente_Notificacao_Completa.Location = new Point(14, 12);
            Fundo_Remetente_Notificacao_Completa.Name = "Fundo_Remetente_Notificacao_Completa";
            Fundo_Remetente_Notificacao_Completa.Size = new Size(265, 37);
            Fundo_Remetente_Notificacao_Completa.TabIndex = 0;
            // 
            // Label_Remetente_Notificacao_Completa
            // 
            Label_Remetente_Notificacao_Completa.AutoSize = true;
            Label_Remetente_Notificacao_Completa.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Remetente_Notificacao_Completa.Location = new Point(9, 12);
            Label_Remetente_Notificacao_Completa.Name = "Label_Remetente_Notificacao_Completa";
            Label_Remetente_Notificacao_Completa.Size = new Size(118, 14);
            Label_Remetente_Notificacao_Completa.TabIndex = 0;
            Label_Remetente_Notificacao_Completa.Text = "Coordenador Junior";
            // 
            // Tela_Inicial_ADM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(895, 480);
            Controls.Add(Fundo_Notificacao_Completa);
            Controls.Add(SideBar);
            Controls.Add(Layout_Lista_Notificacao);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Tela_Inicial_ADM";
            Text = "Tela_Inicial";
            Load += Tela_Inicial_ADM_Load_1;
            SideBar.ResumeLayout(false);
            SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Icone_Logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)Icone_Cadastro).EndInit();
            ((System.ComponentModel.ISupportInitialize)Icone_Calendario).EndInit();
            ((System.ComponentModel.ISupportInitialize)Icone_Registro).EndInit();
            ((System.ComponentModel.ISupportInitialize)Icone_Msg).EndInit();
            ((System.ComponentModel.ISupportInitialize)Icone_Menu).EndInit();
            Fundo_Notificacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Icone_Notificacao).EndInit();
            Fundo_Logout.ResumeLayout(false);
            Fundo_Logout.PerformLayout();
            Layout_Lista_Notificacao.ResumeLayout(false);
            Preview_Notificacao_0.ResumeLayout(false);
            Fundo_Remetente_Notificacao_0.ResumeLayout(false);
            Fundo_Remetente_Notificacao_0.PerformLayout();
            Fundo_Titulo_Notificacao_0.ResumeLayout(false);
            Fundo_Titulo_Notificacao_0.PerformLayout();
            Fundo_Preview_Msg_Notificacao_0.ResumeLayout(false);
            Fundo_Preview_Msg_Notificacao_0.PerformLayout();
            Preview_Notificacao_1.ResumeLayout(false);
            Fundo_Titulo_Notificacao_1.ResumeLayout(false);
            Fundo_Titulo_Notificacao_1.PerformLayout();
            Fundo_Remetente_Notificacao_1.ResumeLayout(false);
            Fundo_Remetente_Notificacao_1.PerformLayout();
            Fundo_Preview_Msg_Notificacao_1.ResumeLayout(false);
            Fundo_Preview_Msg_Notificacao_1.PerformLayout();
            Fundo_Notificacao_Completa.ResumeLayout(false);
            Fundo_Notificacao_Completa.PerformLayout();
            Fundo_Msg_Notificacao_Completa.ResumeLayout(false);
            Fundo_Msg_Notificacao_Completa.PerformLayout();
            Fundo_Titulo_Notificacao_Completa.ResumeLayout(false);
            Fundo_Titulo_Notificacao_Completa.PerformLayout();
            Fundo_Remetente_Notificacao_Completa.ResumeLayout(false);
            Fundo_Remetente_Notificacao_Completa.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel SideBar;
        private PictureBox Icone_Notificacao;
        private PictureBox Icone_Menu;
        private PictureBox Icone_Registro;
        private PictureBox Icone_Msg;
        private PictureBox Icone_Calendario;
        private Label Label_Notificacao;
        private Label Label_Msg;
        private Label Label_Calendario;
        private Label Label_Registro;
        private Label Label_Menu;
        private Panel Fundo_Notificacao;
        private Panel Fundo_Msg;
        private Panel Fundo_Registro;
        private Panel Fundo_Calendario;
        private Panel Fundo_Menu;
        private System.Windows.Forms.Timer Timer_SideBarExpand;
        private PictureBox Icone_Cadastro;
        private Label Label_Cadastro;
        private Panel Fundo_Cadastro;
        private PictureBox Icone_Logout;
        private Panel Fundo_Logout;
        private Label Label_Logout;
        private Button Botao_Nova_Notificacao;
        private Label label1;
        private FlowLayoutPanel Layout_Lista_Notificacao;
        private Panel Preview_Notificacao_1;
        private Panel Fundo_Notificacao_Completa;
        private Panel Fundo_Titulo_Notificacao_1;
        private Label Label_Titulo_Notificacao_1;
        private Panel Fundo_Remetente_Notificacao_1;
        private Label Label_Remetente_Notificacao_1;
        private Panel Fundo_Preview_Msg_Notificacao_1;
        private Label Label_Preview_Msg_Notificacao_1;
        private Panel Fundo_Msg_Notificacao_Completa;
        private Panel Fundo_Titulo_Notificacao_Completa;
        private Panel Fundo_Remetente_Notificacao_Completa;
        private Panel Preview_Notificacao_0;
        private Panel Fundo_Remetente_Notificacao_0;
        private Label Label_Remetente_Notificacao_0;
        private Panel Fundo_Titulo_Notificacao_0;
        private Label Label_Titulo_Notificacao_0;
        private Panel Fundo_Preview_Msg_Notificacao_0;
        private Label Label_Preview_Msg_Notificacao_0;
        private Label Label_Msg_Notificacao_Completa;
        private Label Label_Remetente_Notificacao_Completa;
        private Label Label_Titulo_Notificacao_Completa;
    }
}