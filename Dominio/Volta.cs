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

        public string   NomePiloto      { get; set; }
        public int      NumeroVolta     { get; set; }
        public TimeSpan Hora            { get; set; }
        public TimeSpan TempoGasto      { get; set; }
        public TimeSpan VelocidadeMedia { get; set; }

      
    }
      
}

