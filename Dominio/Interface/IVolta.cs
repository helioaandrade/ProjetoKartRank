using System;
using System.Collections.Generic;
 

namespace Dominio.Interface
{
    public interface IVolta<T> where T : class
    {
        bool Salvar(Volta param);
        IList<Volta> Listar(Volta param);
        Volta Detalhe(Volta param);
    }
}
