using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJ_01
{
    public partial class Tela_Inicial_Funcionario : Form, IUsuarioAtivo
    {
        Tela_Login tela;
        public Usuario IUsuarioAtivo { get; set; }
        private bool isClosingProgrammatically = false;
        bool SideBarExpand = false;
        public Tela_Inicial_Funcionario(Tela_Login tela)
        {
            this.tela = tela;
            this.FormClosing += new FormClosingEventHandler(Tela_Inicial_Funcionario_FormClosing);
            InitializeComponent();
        }

        private void Botao_Fechar_Click(object sender, EventArgs e)
        {
            tela.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            isClosingProgrammatically = true;
            tela.Location = this.Location;
            tela.Show();
            this.Close();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            label1.Text = "Menu Clicado";
            Timer_SideBarExpand.Start();
        }

        private void Notificacao_Click(object sender, EventArgs e)
        {
            label1.Text = "Notificação Clicado";
        }

        private void Mensagem_Click(object sender, EventArgs e)
        {
            label1.Text = "Mensagens Clicado";
        }

        private void Registro_Click(object sender, EventArgs e)
        {
            label1.Text = "Registros Clicado";
        }

        private void Calendario_Click(object sender, EventArgs e)
        {
            label1.Text = "Calendario Clicado";
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            label1.Text = "Cadastro Clicado";
        }

        private void SideBarExpandir(object sender, EventArgs e)
        {
            if (this.SideBarExpand == true)
            {
                SideBar.Width -= 10;
                if (SideBar.Width <= SideBar.MinimumSize.Width)
                {
                    SideBarExpand = false;
                    Timer_SideBarExpand.Stop();
                }

            }
            else
            {
                SideBar.Width += 10;
                if (SideBar.Width >= SideBar.MaximumSize.Width)
                {
                    SideBarExpand = true;
                    Timer_SideBarExpand.Stop();
                }
            }
        }
        private void Fundo_MouseEnter(object sender, EventArgs e)
        {
            Control emCima = ((Control)sender);
            string ultimoNome = emCima.Name.Substring(6);
            Control Correspondente1 = this.Controls.Find($"Fundo_{ultimoNome}", true).FirstOrDefault();
            Control Correspondente2 = this.Controls.Find($"Label_{ultimoNome}", true).FirstOrDefault();
            Control Correspondente3 = this.Controls.Find($"Icone_{ultimoNome}", true).FirstOrDefault();
            if(Correspondente1 != null)
                Correspondente1.BackColor = Color.FromArgb(59, 66, 108);
            if (Correspondente2 != null)
                Correspondente2.BackColor = Color.FromArgb(59, 66, 108);
            if (Correspondente3 != null)
                Correspondente3.BackColor = Color.FromArgb(59, 66, 108);
        }

        private void Fundo_MouseLeave(object sender, EventArgs e)
        {
            Control emCima = ((Control)sender);
            string ultimoNome = emCima.Name.Substring(6);
            Control Correspondente1 = this.Controls.Find($"Fundo_{ultimoNome}", true).FirstOrDefault();
            Control Correspondente2 = this.Controls.Find($"Label_{ultimoNome}", true).FirstOrDefault();
            Control Correspondente3 = this.Controls.Find($"Icone_{ultimoNome}", true).FirstOrDefault();
            if (Correspondente1 != null)
                Correspondente1.BackColor = Color.FromArgb(37, 45, 95);
            if (Correspondente2 != null)
                Correspondente2.BackColor = Color.FromArgb(37, 45, 95);
            if (Correspondente3 != null)
                Correspondente3.BackColor = Color.FromArgb(37, 45, 95);
        }
        private void Tela_Inicial_Funcionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verifica se o Form2 foi fechado pelo usuário (botão "X")
            if (e.CloseReason == CloseReason.UserClosing && !isClosingProgrammatically)
            {
                // Fecha o Form1
                if (tela != null)
                {
                    tela.Close();
                }
            }
        }

    }
}
