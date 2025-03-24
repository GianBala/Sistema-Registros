using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PROJ_01
{
    internal class MouseInteract
    {
        public static void Criar_Notificacao(object sender, EventArgs e, FlowLayoutPanel Layout_Lista_Notificacao, Usuario usuarioAtivo)
        {
            CriarInstancia.CriarNotificacao(Layout_Lista_Notificacao, usuarioAtivo);
        }
        public static void Logout_Click(object sender, EventArgs e, Form tela1, Form tela2)
        {
            if(tela2 is IClosingProgrammatically closing)
            {
                closing.IClosingProgrammatically = true;
            }
            tela1.Location = tela2.Location;
            tela1.Show();
            tela2.Close();
        }

        public static void Menu_Click(object sender, EventArgs e, Label label1, System.Windows.Forms.Timer Timer_SideBarExpand)
        {
            label1.Text = "Menu Clicado";
            Timer_SideBarExpand.Start();
        }

        public static void Notificacao_Click(object sender, EventArgs e, Form tela, ref string janelaAtiva, ref object iconeAtivo)
        {
            foreach(Control controle in tela.Controls)
            {
                if(controle.Name != "SideBar" && controle.Name != "Fundo_Notificacao_Completa" && controle.Name != "Layout_Lista_Notificacao")
                    controle.Visible = false;
            }
            
            Control fundoMsgCompleta = (Control)tela.Controls["Fundo_Notificacao_Completa"];
            Control layoutPreviewNotificacao = (Control)tela.Controls["Layout_Lista_Notificacao"];

            if (fundoMsgCompleta.Visible == false)
            {
                fundoMsgCompleta.Visible = true;
            }
            if(layoutPreviewNotificacao.Visible == false)
            {
                layoutPreviewNotificacao.Visible = true;
            }

            
            
            janelaAtiva = "Notificacao";
            Control temp1 = sender as Control;
            Control temp2 = iconeAtivo as Control;
            if (temp1.Name.Substring(6) != temp2.Name.Substring(6))
            {
                Fundo_MouseEnter(sender, null, " ");
                Fundo_MouseLeave(iconeAtivo, null, " ");
            }
            iconeAtivo = sender;
        }

        public static void Mensagem_Click(object sender, EventArgs e, Form tela, ref string janelaAtiva, ref object iconeAtivo)
        {
            foreach (Control controle in tela.Controls)
            {
                if (controle.Name != "SideBar")
                    controle.Visible = false;
            }
           
            janelaAtiva = "Msg";
            Control temp1 = sender as Control;
            Control temp2 = iconeAtivo as Control;
            if (temp1.Name.Substring(6) != temp2.Name.Substring(6))
            {
                Fundo_MouseEnter(sender, null, " ");
                Fundo_MouseLeave(iconeAtivo, null, " ");
            }
            iconeAtivo = sender;
        }

        public static void Registro_Click(object sender, EventArgs e, Form tela, ref string janelaAtiva, ref object iconeAtivo)
        {
            foreach (Control controle in tela.Controls)
            {
                if (controle.Name != "SideBar")
                    controle.Visible = false;
            }
           
            janelaAtiva = "Registro";
            Control temp1 = sender as Control;
            Control temp2 = iconeAtivo as Control;
            if (temp1.Name.Substring(6) != temp2.Name.Substring(6))
            {
                Fundo_MouseEnter(sender, null, " ");
                Fundo_MouseLeave(iconeAtivo, null, " ");
            }
            iconeAtivo = sender;
        }

        public static void Calendario_Click(object sender, EventArgs e, Form tela, ref string janelaAtiva, ref object iconeAtivo)
        {
            foreach (Control controle in tela.Controls)
            {
                if (controle.Name != "SideBar")
                    controle.Visible = false;
            }
            
            janelaAtiva = "Calendario";
            Control temp1 = sender as Control;
            Control temp2 = iconeAtivo as Control;
            if (temp1.Name.Substring(6) != temp2.Name.Substring(6))
            {
                Fundo_MouseEnter(sender, null, " ");
                Fundo_MouseLeave(iconeAtivo, null, " ");
            }
            iconeAtivo = sender;
        }

        public static void Cadastro_Click(object sender, EventArgs e, Form tela, ref string janelaAtiva, ref object iconeAtivo)
        {
            foreach (Control controle in tela.Controls)
            {
                if (controle.Name != "SideBar")
                    controle.Visible = false;
            }
            janelaAtiva = "Cadastro";
            Control temp1 = sender as Control;
            Control temp2 = iconeAtivo as Control;
            if (temp1.Name.Substring(6) != temp2.Name.Substring(6))
            {
                Fundo_MouseEnter(sender, null, " ");
                Fundo_MouseLeave(iconeAtivo, null, " ");
            }
            iconeAtivo = sender;
        }
        public static void Fundo_MouseEnter(object sender, EventArgs e, string janelaAtiva)
        {
            
            Control emCima = ((Control)sender);
            string ultimoNome = emCima.Name.Substring(6);
            Form tela = Form.ActiveForm;
            Debug.WriteLine(tela.Controls.Count);
            if (janelaAtiva != ultimoNome)
            {
                if (tela != null)
                {
                    Control Correspondente1 = tela.Controls.Find($"Fundo_{ultimoNome}", true).FirstOrDefault();
                    Control Correspondente2 = tela.Controls.Find($"Label_{ultimoNome}", true).FirstOrDefault();
                    Control Correspondente3 = tela.Controls.Find($"Icone_{ultimoNome}", true).FirstOrDefault();
                    if (Correspondente1 != null)
                        Correspondente1.BackColor = Color.FromArgb(59, 66, 108);
                    if (Correspondente2 != null)
                        Correspondente2.BackColor = Color.FromArgb(59, 66, 108);
                    if (Correspondente3 != null)
                        Correspondente3.BackColor = Color.FromArgb(59, 66, 108);
                }
            }
        }

        public static void Fundo_MouseLeave(object sender, EventArgs e, string janelaAtiva)
        {
            Control emCima = ((Control)sender);
            string ultimoNome = emCima.Name.Substring(6);
            Form tela = Form.ActiveForm;
            if (janelaAtiva != ultimoNome)
            {
                if (tela != null)
                {
                    Control Correspondente1 = tela.Controls.Find($"Fundo_{ultimoNome}", true).FirstOrDefault();
                    Control Correspondente2 = tela.Controls.Find($"Label_{ultimoNome}", true).FirstOrDefault();
                    Control Correspondente3 = tela.Controls.Find($"Icone_{ultimoNome}", true).FirstOrDefault();
                    if (Correspondente1 != null)
                        Correspondente1.BackColor = Color.FromArgb(37, 45, 95);
                    if (Correspondente2 != null)
                        Correspondente2.BackColor = Color.FromArgb(37, 45, 95);
                    if (Correspondente3 != null)
                        Correspondente3.BackColor = Color.FromArgb(37, 45, 95);
                }
            }
         }

        public static void Notificacao_MouseEnter(object sender, EventArgs e)
        {
            Control emCima = ((Control)sender);
            Form tela = Form.ActiveForm;
            string ultimoNome = emCima.Name.Substring(emCima.Name.Length - 13);
            if (tela != null)
            {
                Control Correspondente1 = tela.Controls.Find($"Preview_{ultimoNome}", true).FirstOrDefault();
                Control Correspondente2 = tela.Controls.Find($"Fundo_Remetente_{ultimoNome}", true).FirstOrDefault();
                Control Correspondente3 = tela.Controls.Find($"Fundo_Titulo_{ultimoNome}", true).FirstOrDefault();
                Control Correspondente4 = tela.Controls.Find($"Fundo_Preview_Msg_{ultimoNome}", true).FirstOrDefault();

                if (Correspondente1 != null)
                {
                    Correspondente1.BackColor = Color.FromArgb(59, 66, 108);
                }
                if(Correspondente2 != null)
                {
                    Correspondente2.BackColor = Color.FromArgb(93, 99, 139);
                }
                if(Correspondente3 != null)
                {
                    Correspondente3.BackColor = Color.FromArgb(93, 99, 139);
                }
                if(Correspondente4 != null)
                {
                    Correspondente4.BackColor = Color.FromArgb(93, 99, 139);
                }
            }
        }
        public static void Notificacao_MouseLeave(object sender, EventArgs e)
        {
            Control emCima = ((Control)sender);
            Form tela = Form.ActiveForm;
            string ultimoNome = emCima.Name.Substring(emCima.Name.Length - 13);
            if (tela != null)
            { 
                Control Correspondente1 = tela.Controls.Find($"Preview_{ultimoNome}", true).FirstOrDefault();
                Control Correspondente2 = tela.Controls.Find($"Fundo_Remetente_{ultimoNome}", true).FirstOrDefault();
                Control Correspondente3 = tela.Controls.Find($"Fundo_Titulo_{ultimoNome}", true).FirstOrDefault();
                Control Correspondente4 = tela.Controls.Find($"Fundo_Preview_Msg_{ultimoNome}", true).FirstOrDefault();

                if (Correspondente1 != null)
                {
                    Correspondente1.BackColor = Color.FromArgb(37, 45, 95);
                }
                if (Correspondente2 != null)
                {
                    Correspondente2.BackColor = Color.FromArgb(59, 66, 108);
                }
                if (Correspondente3 != null)
                {
                    Correspondente3.BackColor = Color.FromArgb(59, 66, 108);
                }
                if (Correspondente4 != null)
                {
                    Correspondente4.BackColor = Color.FromArgb(59, 66, 108);
                }
            }
        }

        public static void Notificacao_MouseEnter2(object sender, EventArgs e)
        {
            Control emCima = ((Control)sender);
            Form tela = Form.ActiveForm;
            string ultimoNome = emCima.Name.Substring(emCima.Name.Length - 14);
            if (tela != null)
            {
                Control Correspondente1 = tela.Controls.Find($"Preview_{ultimoNome}", true).FirstOrDefault();
                Control Correspondente2 = tela.Controls.Find($"Fundo_Remetente_{ultimoNome}", true).FirstOrDefault();
                Control Correspondente3 = tela.Controls.Find($"Fundo_Titulo_{ultimoNome}", true).FirstOrDefault();
                Control Correspondente4 = tela.Controls.Find($"Fundo_Preview_Msg_{ultimoNome}", true).FirstOrDefault();

                if (Correspondente1 != null)
                {
                    Correspondente1.BackColor = Color.FromArgb(59, 66, 108);
                }
                if (Correspondente2 != null)
                {
                    Correspondente2.BackColor = Color.FromArgb(93, 99, 139);
                }
                if (Correspondente3 != null)
                {
                    Correspondente3.BackColor = Color.FromArgb(93, 99, 139);
                }
                if (Correspondente4 != null)
                {
                    Correspondente4.BackColor = Color.FromArgb(93, 99, 139);
                }
            }
        }

        public static void Notificacao_MouseLeave2(object sender, EventArgs e)
        {
            Control emCima = ((Control)sender);
            Form tela = Form.ActiveForm;
            string ultimoNome = emCima.Name.Substring(emCima.Name.Length - 14);
            if (tela != null)
            {
                Control Correspondente1 = tela.Controls.Find($"Preview_{ultimoNome}", true).FirstOrDefault();
                Control Correspondente2 = tela.Controls.Find($"Fundo_Remetente_{ultimoNome}", true).FirstOrDefault();
                Control Correspondente3 = tela.Controls.Find($"Fundo_Titulo_{ultimoNome}", true).FirstOrDefault();
                Control Correspondente4 = tela.Controls.Find($"Fundo_Preview_Msg_{ultimoNome}", true).FirstOrDefault();

                if (Correspondente1 != null)
                {
                    Correspondente1.BackColor = Color.FromArgb(37, 45, 95);
                }
                if (Correspondente2 != null)
                {
                    Correspondente2.BackColor = Color.FromArgb(59, 66, 108);
                }
                if (Correspondente3 != null)
                {
                    Correspondente3.BackColor = Color.FromArgb(59, 66, 108);
                }
                if (Correspondente4 != null)
                {
                    Correspondente4.BackColor = Color.FromArgb(59, 66, 108);
                }
            }
        }

        public static void Notificacao_Preview_Click(object sender, EventArgs e, int index , Form tela,Usuario usuarioAtivo)
        {

            Debug.WriteLine("Clicou Preview");
            
            Panel panel = (Panel)tela.Controls["Fundo_Notificacao_Completa"];
            Panel panel2 = (Panel)panel.Controls["Fundo_Remetente_Notificacao_Completa"];
            Panel panel3 = (Panel)panel.Controls["Fundo_Titulo_Notificacao_Completa"];
            Panel panel4 = (Panel)panel.Controls["Fundo_Msg_Notificacao_Completa"];

            Label remetente = (Label)panel2.Controls["Label_Remetente_Notificacao_Completa"];
            Label titulo = (Label)panel3.Controls["Label_Titulo_Notificacao_Completa"];
            Label texto = (Label)panel4.Controls["Label_Msg_Notificacao_Completa"];

            //Control layoutPreviewNotificacao = (Control)tela.Controls["Layout_Lista_Notificacao"];
            Debug.WriteLine($"Index {index}");
            remetente.Text = usuarioAtivo.ListaNotificacao[index].Remetente;
            titulo.Text = usuarioAtivo.ListaNotificacao[index].Titulo;
            texto.Text = usuarioAtivo.ListaNotificacao[index].Texto;
        }

        public static void AdicionarEventosDeMouseNotificacao(Control parent, int index)
        {
            Form formularioAtual = parent.FindForm();

            if (formularioAtual is IUsuarioAtivo telaUser)
            {
                Usuario usuarioAtivo = telaUser.IUsuarioAtivo;

                
                if (index <= 9)
                {
                    parent.MouseEnter += Notificacao_MouseEnter;
                    parent.MouseLeave += Notificacao_MouseLeave;
                    parent.Click += (sender, e) => Notificacao_Preview_Click(sender, e, index, formularioAtual, usuarioAtivo);
                }
                else
                {
                    parent.MouseEnter += Notificacao_MouseEnter2;
                    parent.MouseLeave += Notificacao_MouseLeave2;
                    parent.Click += (sender, e) => Notificacao_Preview_Click(sender, e, index, formularioAtual, usuarioAtivo);

                }
                foreach (Control ctrl in parent.Controls)
                {
                    if (index <= 9)
                    {
                        ctrl.MouseEnter += Notificacao_MouseEnter;
                        ctrl.MouseLeave += Notificacao_MouseLeave;
                        ctrl.Click += (sender, e) => Notificacao_Preview_Click(sender, e, index, formularioAtual, usuarioAtivo); 

                    }
                    else
                    {
                        ctrl.MouseEnter += Notificacao_MouseEnter2;
                        ctrl.MouseLeave += Notificacao_MouseLeave2;
                        ctrl.Click += (sender, e) => Notificacao_Preview_Click(sender, e, index, formularioAtual, usuarioAtivo);

                    }

                    // Se o controle contiver outros controles dentro dele, adicione os eventos a eles também
                    if (ctrl.Controls.Count > 0)
                    {
                        AdicionarEventosDeMouseNotificacao(ctrl, index);
                    }
                }

            }
        }

        
    }
}
//450; 333