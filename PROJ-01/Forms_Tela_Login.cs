using System.Collections.Generic;

namespace PROJ_01
{
    public partial class Tela_Login : Form
    {
        
        static Usuario heruran = new Usuario("Herlan", "Herlan", "meutigrinho", 0);
        static Usuario messias = new Usuario("Messias", "Messias", "eimacho", 1);
        static Usuario deivison = new Usuario("Deivison", "Deivison", "canaralho", 2);
        static Usuario john = new Usuario("John", "John", "laele", 3);
        static Usuario tester = new Usuario("t", "t", "t", 1);
        static public List<Usuario> valid_users = new List<Usuario> {heruran,messias,deivison,john,tester};
        public Tela_Login()
        {
            InitializeComponent();
        }

        private void Botao_Login_Click(object sender, EventArgs e)
        {

            string user = " ";
            string senha = " ";

            //Control userBox = this.Controls.Find("TextBox_Usuario", true).FirstOrDefault();
            Control userBox = TextBox_Usuario;
            if (userBox != null)
                user = userBox.Text;

            //Control senhaBox = this.Controls.Find("TextBox_Senha", true).FirstOrDefault();
            Control senhaBox = TextBox_Senha;
            if (senhaBox != null)
                senha = senhaBox.Text;

            Usuario usuario_input = valid_users.FirstOrDefault(_usuario => _usuario.Login == user);

            //Control msgBox = this.Controls.Find("ErroMsg", true).FirstOrDefault();
            Control msgBox = ErroMsg;
            if (msgBox != null)
                if (usuario_input != null)
                {
                    if (usuario_input.Senha == senha)
                    {
                        msgBox.Text = $"Usuario Válido";

                        userBox.Text = "";
                        senhaBox.Text = "";

                        switch (usuario_input.ID_level)
                        {
                            case 0:
                                Console.WriteLine(" ");
                                break;

                            case 1:
                                Tela_Inicial_ADM novoFormularioADM = new Tela_Inicial_ADM(this, usuario_input);
                                novoFormularioADM.StartPosition = FormStartPosition.Manual;
                                novoFormularioADM.Location = this.Location;
                                novoFormularioADM.Show();
                                //novoFormularioADM.FormClosed += (s, args) => this.Close();
                                this.Hide();
                                msgBox.Text = "";
                                break;

                            case 2:
                                Tela_Inicial_Funcionario novoFormularioFuncionario = new Tela_Inicial_Funcionario(this);
                                novoFormularioFuncionario.StartPosition = FormStartPosition.Manual;
                                novoFormularioFuncionario.Location = this.Location;
                                novoFormularioFuncionario.Show();
                                //novoFormularioFuncionario.FormClosed += (s, args) => this.Close();
                                this.Hide();
                                msgBox.Text = "";
                                break;

                            case 3:
                                Tela_Inicial_Cliente novoFormularioCliente = new Tela_Inicial_Cliente(this);
                                novoFormularioCliente.StartPosition = FormStartPosition.Manual;
                                novoFormularioCliente.Location = this.Location;
                                novoFormularioCliente.Show();
                                //novoFormularioCliente.FormClosed += (s, args) => this.Close();
                                this.Hide();
                                msgBox.Text = "";
                                break;
                        }

                        //novoFormulario.FormClosed += (s, args) => this.Close();
                    }
                    else
                        msgBox.Text = "Senha Incorreta";
                }
                else
                    msgBox.Text = "Usuario Invalido";

            
        }

        private void Botao_Esquece_Senha_Click(object sender, EventArgs e)
        {

        }

        private void Olho_Aberto_Click(object sender, EventArgs e)
        {
            if(TextBox_Senha.PasswordChar == '\0')
            {
                Olho_Fechado.BringToFront();
                TextBox_Senha.PasswordChar = '*';
            }
        }

        private void Olho_Fechado_Click(object sender, EventArgs e)
        {
            if (TextBox_Senha.PasswordChar == '*')
            {
                Olho_Aberto.BringToFront();
                TextBox_Senha.PasswordChar = '\0';
            }
        }
    }
}
