using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Diagnostics;

namespace PROJ_01
{
    public partial class Tela_Inicial_ADM : Form, IUsuarioAtivo, IClosingProgrammatically
    {
        Tela_Login tela;
        //CriarInstancia InstCreator = new CriarInstancia();
        public Usuario IUsuarioAtivo { get; set; }
        public string janelaAberta = " ";
        public object iconeAtivo;
        public bool IClosingProgrammatically { get; set; }
        bool SideBarExpand = false;
        public Tela_Inicial_ADM(Tela_Login tela, Usuario usuarioLogado)
        {
            this.tela = tela;
            this.IClosingProgrammatically = false;
            this.IUsuarioAtivo = usuarioLogado;
            this.IUsuarioAtivo.ListaNotificacao.Add(new Mensagem
            {
                Remetente = "John",
                Destinatario = "Herlan",
                Titulo = "La ele 1000x",
                //Texto = "Saiba que voce vai subir no tigrinho herlan...",
                Texto = "Vou te mandar video laele"
            }
            );
            this.IUsuarioAtivo.ListaNotificacao.Add(new Mensagem
            {
                Remetente = "Herlan",
                Destinatario = "Deivison",
                Titulo = "Guia da Bipolaridade",
                //Texto = "Saiba que voce vai subir no tigrinho herlan...",
                Texto = "Capitulo 1 - Falte aula mesmo falando que vai pra aula"
            }
            );
            this.FormClosing += (sender, e) => FormFechar.Tela_FormClosing(sender, e, tela, IClosingProgrammatically);
            InitializeComponent();
            AplicarEventoMouseNotificacao();
            iconeAtivo = Icone_Notificacao;
        }

        private void Botao_Fechar_Click(object sender, EventArgs e)
        {
            tela.Close();

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





        public void AplicarEventoMouseNotificacao()
        {
            Icone_Logout.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Icone_Logout.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Icone_Logout.Click += (sender, e) => MouseInteract.Logout_Click(sender, e, tela, this);

            Icone_Cadastro.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Icone_Cadastro.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Icone_Cadastro.Click += (sender, e) => MouseInteract.Cadastro_Click(sender, e, this, ref janelaAberta, ref iconeAtivo);

            Icone_Calendario.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Icone_Calendario.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Icone_Calendario.Click += (sender, e) => MouseInteract.Calendario_Click(sender, e, this, ref janelaAberta, ref iconeAtivo);

            Icone_Registro.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Icone_Registro.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Icone_Registro.Click += (sender, e) => MouseInteract.Registro_Click(sender, e, this, ref janelaAberta, ref iconeAtivo);

            Icone_Msg.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Icone_Msg.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Icone_Msg.Click += (sender, e) => MouseInteract.Mensagem_Click(sender, e, this, ref janelaAberta, ref iconeAtivo);

            Icone_Menu.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Icone_Menu.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Icone_Menu.Click += (sender, e) => MouseInteract.Menu_Click(sender, e, label1, Timer_SideBarExpand);

            Icone_Notificacao.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Icone_Notificacao.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Icone_Notificacao.Click += (sender, e) => MouseInteract.Notificacao_Click(sender, e, this, ref janelaAberta, ref iconeAtivo);

            Label_Menu.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Label_Menu.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Label_Menu.Click += (sender, e) => MouseInteract.Menu_Click(sender, e, label1, Timer_SideBarExpand);

            Label_Cadastro.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Label_Cadastro.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Label_Cadastro.Click += (sender, e) => MouseInteract.Cadastro_Click(sender, e, this, ref janelaAberta, ref iconeAtivo);

            Label_Calendario.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Label_Calendario.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Label_Calendario.Click += (sender, e) => MouseInteract.Calendario_Click(sender, e, this, ref janelaAberta, ref iconeAtivo);

            Label_Registro.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Label_Registro.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Label_Registro.Click += (sender, e) => MouseInteract.Registro_Click(sender, e, this, ref janelaAberta, ref iconeAtivo);

            Label_Msg.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Label_Msg.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Label_Msg.Click += (sender, e) => MouseInteract.Mensagem_Click(sender, e, this, ref janelaAberta, ref iconeAtivo);

            Label_Notificacao.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Label_Notificacao.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Label_Notificacao.Click += (sender, e) => MouseInteract.Notificacao_Click(sender, e, this, ref janelaAberta, ref iconeAtivo);

            Label_Logout.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Label_Logout.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Label_Logout.Click += (sender, e) => MouseInteract.Logout_Click(sender, e, tela, this);

            Label_Remetente_Notificacao_1.MouseEnter += MouseInteract.Notificacao_MouseEnter;
            Label_Remetente_Notificacao_1.MouseLeave += MouseInteract.Notificacao_MouseLeave;
            Label_Remetente_Notificacao_1.Click += (sender, e) => MouseInteract.Notificacao_Preview_Click(sender, e, 1, this, IUsuarioAtivo);

            Label_Remetente_Notificacao_0.MouseEnter += MouseInteract.Notificacao_MouseEnter;
            Label_Remetente_Notificacao_0.MouseLeave += MouseInteract.Notificacao_MouseLeave;
            Label_Remetente_Notificacao_0.Click += (sender, e) => MouseInteract.Notificacao_Preview_Click(sender, e, 0, this, IUsuarioAtivo);

            Label_Preview_Msg_Notificacao_1.MouseEnter += MouseInteract.Notificacao_MouseEnter;
            Label_Preview_Msg_Notificacao_1.MouseLeave += MouseInteract.Notificacao_MouseLeave;
            Label_Preview_Msg_Notificacao_1.Click += (sender, e) => MouseInteract.Notificacao_Preview_Click(sender, e, 1, this, IUsuarioAtivo);

            Label_Titulo_Notificacao_0.MouseEnter += MouseInteract.Notificacao_MouseEnter;
            Label_Titulo_Notificacao_0.MouseLeave += MouseInteract.Notificacao_MouseLeave;
            Label_Titulo_Notificacao_0.Click += (sender, e) => MouseInteract.Notificacao_Preview_Click(sender, e, 0, this, IUsuarioAtivo);

            Label_Titulo_Notificacao_1.MouseEnter += MouseInteract.Notificacao_MouseEnter;
            Label_Titulo_Notificacao_1.MouseLeave += MouseInteract.Notificacao_MouseLeave;
            Label_Titulo_Notificacao_1.Click += (sender, e) => MouseInteract.Notificacao_Preview_Click(sender, e, 1, this, IUsuarioAtivo);

            Label_Preview_Msg_Notificacao_0.MouseEnter += MouseInteract.Notificacao_MouseEnter;
            Label_Preview_Msg_Notificacao_0.MouseLeave += MouseInteract.Notificacao_MouseLeave;
            Label_Preview_Msg_Notificacao_0.Click += (sender, e) => MouseInteract.Notificacao_Preview_Click(sender, e, 0, this, IUsuarioAtivo);

            Fundo_Notificacao.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Fundo_Notificacao.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Fundo_Notificacao.Click += (sender, e) => MouseInteract.Notificacao_Click(sender, e, this, ref janelaAberta, ref iconeAtivo);

            Fundo_Msg.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Fundo_Msg.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Fundo_Msg.Click += (sender, e) => MouseInteract.Mensagem_Click(sender, e, this, ref janelaAberta, ref iconeAtivo);

            Fundo_Registro.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Fundo_Registro.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Fundo_Registro.Click += (sender, e) => MouseInteract.Registro_Click(sender, e, this, ref janelaAberta, ref iconeAtivo);

            Fundo_Calendario.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Fundo_Calendario.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Fundo_Calendario.Click += (sender, e) => MouseInteract.Calendario_Click(sender, e, this, ref janelaAberta, ref iconeAtivo);

            Fundo_Menu.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Fundo_Menu.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Fundo_Menu.Click += (sender, e) => MouseInteract.Menu_Click(sender, e, label1, Timer_SideBarExpand);

            Fundo_Cadastro.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Fundo_Cadastro.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Fundo_Cadastro.Click += (sender, e) => MouseInteract.Cadastro_Click(sender, e, this, ref janelaAberta, ref iconeAtivo);

            Fundo_Logout.MouseEnter += (sender, e) => MouseInteract.Fundo_MouseEnter(sender, e, janelaAberta);
            Fundo_Logout.MouseLeave += (sender, e) => MouseInteract.Fundo_MouseLeave(sender, e, janelaAberta);
            Fundo_Logout.Click += (sender, e) => MouseInteract.Logout_Click(sender, e, tela, this);

            Fundo_Remetente_Notificacao_0.MouseEnter += MouseInteract.Notificacao_MouseEnter;
            Fundo_Remetente_Notificacao_0.MouseLeave += MouseInteract.Notificacao_MouseLeave;
            Fundo_Remetente_Notificacao_0.Click += (sender, e) => MouseInteract.Notificacao_Preview_Click(sender, e, 0, this, IUsuarioAtivo);

            Fundo_Preview_Msg_Notificacao_0.MouseEnter += MouseInteract.Notificacao_MouseEnter;
            Fundo_Preview_Msg_Notificacao_0.MouseLeave += MouseInteract.Notificacao_MouseLeave;
            Fundo_Preview_Msg_Notificacao_0.Click += (sender, e) => MouseInteract.Notificacao_Preview_Click(sender, e, 0, this, IUsuarioAtivo);

            Fundo_Titulo_Notificacao_1.MouseEnter += MouseInteract.Notificacao_MouseEnter;
            Fundo_Titulo_Notificacao_1.MouseLeave += MouseInteract.Notificacao_MouseLeave;
            Fundo_Titulo_Notificacao_1.Click += (sender, e) => MouseInteract.Notificacao_Preview_Click(sender, e, 1, this, IUsuarioAtivo);

            Fundo_Titulo_Notificacao_0.MouseEnter += MouseInteract.Notificacao_MouseEnter;
            Fundo_Titulo_Notificacao_0.MouseLeave += MouseInteract.Notificacao_MouseLeave;
            Fundo_Titulo_Notificacao_0.Click += (sender, e) => MouseInteract.Notificacao_Preview_Click(sender, e, 0, this, IUsuarioAtivo);

            Fundo_Preview_Msg_Notificacao_1.MouseEnter += MouseInteract.Notificacao_MouseEnter;
            Fundo_Preview_Msg_Notificacao_1.MouseLeave += MouseInteract.Notificacao_MouseLeave;
            Fundo_Preview_Msg_Notificacao_1.Click += (sender, e) => MouseInteract.Notificacao_Preview_Click(sender, e, 1, this, IUsuarioAtivo);

            Fundo_Remetente_Notificacao_1.MouseEnter += MouseInteract.Notificacao_MouseEnter;
            Fundo_Remetente_Notificacao_1.MouseLeave += MouseInteract.Notificacao_MouseLeave;
            Fundo_Remetente_Notificacao_1.Click += (sender, e) => MouseInteract.Notificacao_Preview_Click(sender, e, 1, this, IUsuarioAtivo);

            Preview_Notificacao_1.MouseEnter += MouseInteract.Notificacao_MouseEnter;
            Preview_Notificacao_1.MouseLeave += MouseInteract.Notificacao_MouseLeave;
            Preview_Notificacao_1.Click += (sender, e) => MouseInteract.Notificacao_Preview_Click(sender, e, 1, this, IUsuarioAtivo);

            Preview_Notificacao_0.MouseEnter += MouseInteract.Notificacao_MouseEnter;
            Preview_Notificacao_0.MouseLeave += MouseInteract.Notificacao_MouseLeave;
            Preview_Notificacao_0.Click += (sender, e) => MouseInteract.Notificacao_Preview_Click(sender, e, 0, this, IUsuarioAtivo);

            Botao_Nova_Notificacao.Click += (sender, e) => MouseInteract.Criar_Notificacao(sender, e, Layout_Lista_Notificacao, IUsuarioAtivo);

        }

        private void Fundo_Notificacao_Completa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label_Titulo_Notificacao_Completa_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Inicial_ADM_Load(object sender, EventArgs e)
        {

        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tela_Inicial_ADM_Load_1(object sender, EventArgs e)
        {

        }
    }
}
