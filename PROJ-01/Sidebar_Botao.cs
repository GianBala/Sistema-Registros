using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJ_01
{
    internal class Sidebar_Botao
    {
        private Control icone;
        public Control Icone
        {
            get
            {
                return icone;
            }
            set
            {
                icone = value;
            }
        }
        private Control texto;
        public Control Texto
        {
            get
            {
                return texto;
            }
            set
            {
                texto = value;
            }
        }
        private Control fundo;
        public Control Fundo
        {
            get
            {
                return fundo;
            }
            set
            {
                fundo = value;
            }
        }
        public Sidebar_Botao()
        {

        }

    }
}
