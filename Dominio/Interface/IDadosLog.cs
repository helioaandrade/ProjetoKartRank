 
using System.Collections.Generic;
  
namespace Dominio.Interface
{
    public interface IDadosLog<T> where T : class
    {
        // Simular tabela com dados de log
        IList<DadosLog> Listar();
    }
}
