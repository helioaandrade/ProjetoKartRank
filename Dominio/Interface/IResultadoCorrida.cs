using System;
using System.Collections.Generic;
 
namespace Dominio.Interface
{
  
    public interface IResultadoCorrida<T> where T : class
    {
        bool Salvar(ResultadoCorrida param);
        IList<ResultadoCorrida> Listar(ResultadoCorrida param);
        ResultadoCorrida Detalhe(ResultadoCorrida param);
    }
}
