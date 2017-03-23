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
        public string NumeroPiloto { get; set; }
        public string NomePiloto { get; set; }
        public DateTime Hora { get; set; }
        public DateTime Tempo { get; set; }
        public DateTime VelocidadeMedia { get; set; }
    }
}
