using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Volta
    {
        public Volta()
        {
        }

        public int      NumeroVolta     { get; set; }
        public DateTime Hora            { get; set; }
        public DateTime TempoGasto      { get; set; }
        public DateTime VelocidadeMedia { get; set; }
    }
      
}
