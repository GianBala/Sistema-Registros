using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PROJ_01
{
    internal class CriarInstancia 
    {
        public static void CriarNotificacao(FlowLayoutPanel Layout_Lista_Notificacao, Usuario usuarioAtivo)
        {
            // Encontra o maior número já usado nas instâncias anteriores
            int maxId = 0; // Default para 1 caso não haja instâncias anteriores
            int id = 0;
            Mensagem notificacao = new Mensagem
            {
                Remetente = "Deivison",
                Destinatario = "Herlan",
                Titulo = "Festinha de Ano Novo",
                //Texto = "Saiba que voce vai subir no tigrinho herlan...",
                Texto = "Levem seus filhos vestidos de branco"
            };

            foreach (Control ctrl in Layout_Lista_Notificacao.Controls)
            {
                if (ctrl.Name.StartsWith("Preview_Notificacao_"))
                {
                    // Extrai o número da última parte do nome
                    id = int.Parse(ctrl.Name.Split('_').Last());
                    maxId = Math.Max(maxId, id + 1); // Pega o maior número e aumenta 1
                }
            }

            using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
            {
                Font fonte = new Font("Cambria", 9F, FontStyle.Regular);

                // Instanciando o painel principal com o novo número
                Panel Preview_Notificacao = new Panel
                {
                    BackColor = Color.FromArgb(37, 45, 95),
                    Cursor = Cursors.Hand,
                    Location = new Point(3, 109),
                    Name = $"Preview_Notificacao_{maxId}",
                    Size = new Size(197, 100),
                    TabIndex = 0
                };

                // Instanciando os subpainéis
                Panel Fundo_Titulo_Notificacao = new Panel
                {
                    BackColor = Color.FromArgb(59, 66, 108),
                    Cursor = Cursors.Hand,
                    Location = new Point(5, 32),
                    Name = $"Fundo_Titulo_Notificacao_{maxId}",
                    Size = new Size(186, 22)
                };

                Panel Fundo_Remetente_Notificacao = new Panel
                {
                    BackColor = Color.FromArgb(59, 66, 108),
                    Cursor = Cursors.Hand,
                    Location = new Point(5, 5),
                    Name = $"Fundo_Remetente_Notificacao_{maxId}",
                    Size = new Size(186, 22)
                };

                Panel Fundo_Preview_Msg_Notificacao = new Panel
                {
                    BackColor = Color.FromArgb(59, 66, 108),
                    Cursor = Cursors.Hand,
                    Location = new Point(5, 58),
                    Name = $"Fundo_Preview_Msg_Notificacao_{maxId}",
                    Size = new Size(186, 36)
                };

                SizeF tamanhoTituloMsg = g.MeasureString(notificacao.Titulo, fonte);
                Debug.WriteLine(tamanhoTituloMsg);
                // Instanciando os labels
                Label Titulo_Notificacao = new Label
                {
                    AutoSize = true,
                    Font = new Font("Cambria", 9F, FontStyle.Regular),
                    ForeColor = SystemColors.Window,
                    Location = new Point(4, 3),
                    Name = $"Label_Titulo_Notificacao_{maxId}",
                    Size = new Size(89, 15),
                    Text = tamanhoTituloMsg.Width > 175
                     ? notificacao.Titulo.Substring(0, 15) + "..."
                     : notificacao.Titulo
                };

                Label Label_Remetente = new Label
                {
                    AutoSize = true,
                    BackColor = Color.Transparent,
                    Font = new Font("Cambria", 9F, FontStyle.Bold),
                    ForeColor = SystemColors.Window,
                    Location = new Point(5, 3),
                    Name = $"Label_Remetente_Notificacao_{maxId}",
                    Size = new Size(71, 15),
                    Text = notificacao.Remetente
                };

                SizeF tamanhoTextoMsg = g.MeasureString(notificacao.Texto, fonte);
                Label Preview_Msg_Notificacao = new Label
                {
                    AutoSize = true,
                    Font = new Font("Cambria", 9F, FontStyle.Regular),
                    ForeColor = SystemColors.Window,
                    Location = new Point(4, 3),
                    MaximumSize = new Size(181, 30),
                    Name = $"Label_Preview_Msg_Notificacao_{maxId}",
                    Size = new Size(172, 30),
                    Text = tamanhoTextoMsg.Width > 346
                     ? notificacao.Texto.Substring(0, 30) + "..."
                     : notificacao.Texto
                };

                // Adicionando os labels aos painéis
                Fundo_Titulo_Notificacao.Controls.Add(Titulo_Notificacao);
                Fundo_Remetente_Notificacao.Controls.Add(Label_Remetente);
                Fundo_Preview_Msg_Notificacao.Controls.Add(Preview_Msg_Notificacao);

                // Adicionando os subpainéis ao painel principal
                Preview_Notificacao.Controls.Add(Fundo_Titulo_Notificacao);
                Preview_Notificacao.Controls.Add(Fundo_Remetente_Notificacao);
                Preview_Notificacao.Controls.Add(Fundo_Preview_Msg_Notificacao);

                usuarioAtivo.ListaNotificacao.Add(notificacao);

                // Adicionando o painel principal ao FlowLayoutPanel
                Layout_Lista_Notificacao.Controls.Add(Preview_Notificacao);
                MouseInteract.AdicionarEventosDeMouseNotificacao(Preview_Notificacao, maxId);

                
            }
        }
    }
}
