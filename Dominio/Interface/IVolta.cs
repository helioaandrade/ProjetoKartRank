using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interface
{
    public interface IVolta<T> where T : class
    {
        bool Salvar(Volta pVolta);
        IList<Volta> Lista(Volta pVolta);
        Volta Detalhe(Volta pVolta);
    }
}
