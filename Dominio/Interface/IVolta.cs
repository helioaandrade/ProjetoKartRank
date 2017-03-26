using System;
using System.Collections.Generic;
 

namespace Dominio.Interface
{
    public interface IVolta<T> where T : class
    {
         IList<Volta> Listar(Volta param);
     }
}
