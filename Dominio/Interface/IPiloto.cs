using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interface
{
   
    public interface IPiloto<T> where T : class
    {
        bool Salvar(Piloto pPiloto);
        IList<DadosLog> Piloto(Piloto pPiloto);
        Piloto Detalhe(Piloto pPiloto);
    }
}
