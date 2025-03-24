namespace PROJ_01
{
    partial class Tela_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Login));
            Botao_Login = new Button();
            Label_Usuario = new Label();
            TextBox_Usuario = new TextBox();
            Label_Senha = new Label();
            TextBox_Senha = new TextBox();
            Botao_Esquece_Senha = new Button();
            ErroMsg = new Label();
            Imagem_Logo = new PictureBox();
            Fundo_TextBox1 = new PictureBox();
            Fundo_TextBox2 = new PictureBox();
            Olho_Aberto = new Button();
            Olho_Fechado = new Button();
            ((System.ComponentModel.ISupportInitialize)Imagem_Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Fundo_TextBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Fundo_TextBox2).BeginInit();
            SuspendLayout();
            // 
            // Botao_Login
            // 
            Botao_Login.BackColor = Color.Gold;
            Botao_Login.FlatAppearance.BorderSize = 0;
            Botao_Login.FlatAppearance.MouseDownBackColor = Color.Cyan;
            Botao_Login.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            Botao_Login.FlatStyle = FlatStyle.Flat;
            Botao_Login.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Botao_Login.Location = new Point(293, 307);
            Botao_Login.Name = "Botao_Login";
            Botao_Login.Size = new Size(125, 25);
            Botao_Login.TabIndex = 0;
            Botao_Login.Text = "Entrar";
            Botao_Login.UseVisualStyleBackColor = false;
            Botao_Login.Click += Botao_Login_Click;
            // 
            // Label_Usuario
            // 
            Label_Usuario.AutoSize = true;
            Label_Usuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Label_Usuario.Location = new Point(316, 217);
            Label_Usuario.Name = "Label_Usuario";
            Label_Usuario.Size = new Size(58, 20);
            Label_Usuario.TabIndex = 1;
            Label_Usuario.Text = "Usuário";
            // 
            // TextBox_Usuario
            // 
            TextBox_Usuario.BackColor = Color.Gold;
            TextBox_Usuario.BorderStyle = BorderStyle.None;
            TextBox_Usuario.Location = new Point(386, 221);
            TextBox_Usuario.Name = "TextBox_Usuario";
            TextBox_Usuario.Size = new Size(115, 16);
            TextBox_Usuario.TabIndex = 2;
            // 
            // Label_Senha
            // 
            Label_Senha.AutoSize = true;
            Label_Senha.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Label_Senha.Location = new Point(326, 257);
            Label_Senha.Name = "Label_Senha";
            Label_Senha.Size = new Size(47, 20);
            Label_Senha.TabIndex = 3;
            Label_Senha.Text = "Senha";
            // 
            // TextBox_Senha
            // 
            TextBox_Senha.BackColor = Color.Gold;
            TextBox_Senha.BorderStyle = BorderStyle.None;
            TextBox_Senha.Location = new Point(386, 261);
            TextBox_Senha.Name = "TextBox_Senha";
            TextBox_Senha.Size = new Size(115, 16);
            TextBox_Senha.TabIndex = 4;
            // 
            // Botao_Esquece_Senha
            // 
            Botao_Esquece_Senha.BackColor = Color.Gold;
            Botao_Esquece_Senha.FlatAppearance.BorderSize = 0;
            Botao_Esquece_Senha.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            Botao_Esquece_Senha.FlatStyle = FlatStyle.Flat;
            Botao_Esquece_Senha.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Botao_Esquece_Senha.Location = new Point(444, 307);
            Botao_Esquece_Senha.Name = "Botao_Esquece_Senha";
            Botao_Esquece_Senha.Size = new Size(125, 25);
            Botao_Esquece_Senha.TabIndex = 6;
            Botao_Esquece_Senha.Text = "Recuperar Senha";
            Botao_Esquece_Senha.UseVisualStyleBackColor = false;
            Botao_Esquece_Senha.Click += Botao_Esquece_Senha_Click;
            // 
            // ErroMsg
            // 
            ErroMsg.AutoSize = true;
            ErroMsg.Location = new Point(363, 349);
            ErroMsg.Name = "ErroMsg";
            ErroMsg.Size = new Size(0, 15);
            ErroMsg.TabIndex = 7;
            // 
            // Imagem_Logo
            // 
            Imagem_Logo.Image = (Image)resources.GetObject("Imagem_Logo.Image");
            Imagem_Logo.Location = new Point(381, 72);
            Imagem_Logo.Name = "Imagem_Logo";
            Imagem_Logo.Size = new Size(108, 108);
            Imagem_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Imagem_Logo.TabIndex = 8;
            Imagem_Logo.TabStop = false;
            // 
            // Fundo_TextBox1
            // 
            Fundo_TextBox1.Image = (Image)resources.GetObject("Fundo_TextBox1.Image");
            Fundo_TextBox1.Location = new Point(381, 217);
            Fundo_TextBox1.Name = "Fundo_TextBox1";
            Fundo_TextBox1.Size = new Size(125, 25);
            Fundo_TextBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Fundo_TextBox1.TabIndex = 9;
            Fundo_TextBox1.TabStop = false;
            // 
            // Fundo_TextBox2
            // 
            Fundo_TextBox2.Image = (Image)resources.GetObject("Fundo_TextBox2.Image");
            Fundo_TextBox2.Location = new Point(381, 257);
            Fundo_TextBox2.Name = "Fundo_TextBox2";
            Fundo_TextBox2.Size = new Size(125, 25);
            Fundo_TextBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            Fundo_TextBox2.TabIndex = 10;
            Fundo_TextBox2.TabStop = false;
            // 
            // Olho_Aberto
            // 
            Olho_Aberto.BackColor = Color.Khaki;
            Olho_Aberto.FlatAppearance.BorderSize = 0;
            Olho_Aberto.FlatAppearance.MouseOverBackColor = Color.Gold;
            Olho_Aberto.FlatStyle = FlatStyle.Flat;
            Olho_Aberto.Image = (Image)resources.GetObject("Olho_Aberto.Image");
            Olho_Aberto.Location = new Point(512, 257);
            Olho_Aberto.Name = "Olho_Aberto";
            Olho_Aberto.Size = new Size(34, 26);
            Olho_Aberto.TabIndex = 11;
            Olho_Aberto.UseVisualStyleBackColor = false;
            Olho_Aberto.Click += Olho_Aberto_Click;
            // 
            // Olho_Fechado
            // 
            Olho_Fechado.BackColor = Color.Khaki;
            Olho_Fechado.FlatAppearance.BorderSize = 0;
            Olho_Fechado.FlatAppearance.MouseOverBackColor = Color.Gold;
            Olho_Fechado.FlatStyle = FlatStyle.Flat;
            Olho_Fechado.Image = (Image)resources.GetObject("Olho_Fechado.Image");
            Olho_Fechado.Location = new Point(512, 257);
            Olho_Fechado.Name = "Olho_Fechado";
            Olho_Fechado.Size = new Size(34, 26);
            Olho_Fechado.TabIndex = 12;
            Olho_Fechado.UseVisualStyleBackColor = false;
            Olho_Fechado.Click += Olho_Fechado_Click;
            // 
            // Tela_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(895, 480);
            Controls.Add(Olho_Aberto);
            Controls.Add(Imagem_Logo);
            Controls.Add(ErroMsg);
            Controls.Add(Botao_Esquece_Senha);
            Controls.Add(TextBox_Senha);
            Controls.Add(Label_Senha);
            Controls.Add(Label_Usuario);
            Controls.Add(TextBox_Usuario);
            Controls.Add(Fundo_TextBox1);
            Controls.Add(Fundo_TextBox2);
            Controls.Add(Botao_Login);
            Controls.Add(Olho_Fechado);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Tela_Login";
            Text = "Tela_Login";
            ((System.ComponentModel.ISupportInitialize)Imagem_Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)Fundo_TextBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Fundo_TextBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Botao_Login;
        private Label Label_Usuario;
        private TextBox TextBox_Usuario;
        private Label Label_Senha;
        private TextBox TextBox_Senha;
        private Button Botao_Esquece_Senha;
        private Label ErroMsg;
        private PictureBox Imagem_Logo;
        private PictureBox Fundo_TextBox1;
        private PictureBox Fundo_TextBox2;
        private Button Olho_Aberto;
        private Button Olho_Fechado;
    }
}
