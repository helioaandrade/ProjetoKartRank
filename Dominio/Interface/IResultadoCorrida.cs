using System;
using System.Collections.Generic;
 
namespace Dominio.Interface
{
  
    public interface IResultadoCorrida<T> where T : class
    {
         IList<ResultadoCorrida> ResultadoFinal( );
     }
}
