using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJ_01
{
    internal class FormFechar
    {
        public static void Tela_FormClosing(object sender, FormClosingEventArgs e, Form tela, bool isClosingProgrammatically)
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
