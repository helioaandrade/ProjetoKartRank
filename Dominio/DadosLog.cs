using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    /// <summary>
    /// Simular uma tabela de log com os dados da corrida de Kart
    /// </summary>
    public class DadosLog
    {
        public int NumeroVolta { get; set; }
    
        public string NomePiloto { get; set; }
        
        public TimeSpan Hora { get; set; }  

        public TimeSpan Tempo { get; set; }
     
        public TimeSpan VelocidadeMedia { get; set; }

        public List<DadosLog> Listar()
        {
          
            return new List<DadosLog>
          {
                      

          };
        }


    }


}
