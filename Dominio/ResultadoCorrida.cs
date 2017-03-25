using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ResultadoCorrida
    {
        public ResultadoCorrida()
        {
                
        }
        public string   Posicao { get; set; }
        public string   CodigoPiloto{ get; set; }
        public string   NomePiloto { get; set; }
        public int      QtdeVoltasCompletadas{ get; set; }
        public DateTime TempoTotalProva { get; set; }
    }
}
