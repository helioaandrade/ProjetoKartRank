 
using System.Collections.Generic;
  
namespace Dominio.Interface
{
    public interface IDadosLog<T> where T : class
    {
        bool Salvar(DadosLog pDadosLog);
        IList<DadosLog> Listar(DadosLog pDadosLog);
        DadosLog Detalhe(DadosLog pDadosLog);
     }

}
