using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJ_01
{
    public interface IUsuarioAtivo
    {
        Usuario IUsuarioAtivo { get; set; }
    }
    public interface IClosingProgrammatically
    {
        bool IClosingProgrammatically { get; set; }
    }
    public interface INotificacaoAberta
    {
        Control INotificacaoAberta { get; set; }
    }
}
