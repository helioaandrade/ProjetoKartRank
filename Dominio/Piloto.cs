using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Piloto
    {
        public Piloto()
        {
        }
 
        public string NumeroPiloto { get; set; }
        public string NomePiloto { get; set; }
        public IList<Volta> Voltas { get; set; }
     }
}
