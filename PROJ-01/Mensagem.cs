using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJ_01
{
    internal class Mensagem
    {
        private int id;
        internal int ID
        {
            get 
            {
                return id;
            }
            set 
            {
                if(value >= 0)
                {
                    id = value;
                }
                else
                    throw new ArgumentException("ID Inválido");
            }
        }
        private string remetente = "Remetente Não Definido";
        internal string Remetente
        {
            get
            {
                return remetente;
            }
            set
            {
            Usuario usuario_input = Tela_Login.valid_users.FirstOrDefault(_usuario => _usuario.Nome == value);
                if (usuario_input != null)
                    remetente = value;
                else
                    throw new ArgumentException("Remetente Inválido");
            }
        }
        private string destinatario = "Destinatario Não Definido";
        internal string Destinatario
        {
            get
            {
                return destinatario;
            }
            set
            {
                Usuario usuario_input = Tela_Login.valid_users.FirstOrDefault(_usuario => _usuario.Nome == value);
                if (usuario_input != null)
                    destinatario = value;
                else
                    throw new ArgumentException("Destinatário Inválido");
            }
        }
        private string titulo = "Titulo Não Definido";
        internal string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                
                if (value.Length <= 20)
                    titulo = value;
                else
                    throw new ArgumentException("Título Muito Grande");
            }
        }
        private string texto = "Mensagem Não Definida";
        internal string Texto
        {
            get
            {
                return texto;
            }
            set
            {

                if (value.Length <= 940)
                    texto = value;
                else
                    throw new ArgumentException("Mensagem Muito Grande");
            }
        }

    }
}
