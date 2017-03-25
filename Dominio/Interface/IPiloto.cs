using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interface
{
   
    public interface IPiloto<T> where T : class
    {
        bool Salvar(Piloto param);
        IList<Piloto> Listar(Piloto param);
        Piloto Detalhe(Piloto param);
    }
}
