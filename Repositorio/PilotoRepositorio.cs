using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Dominio.Interface;

namespace Repositorio
{
    public class PilotoRepositorio : IPiloto<Piloto>
    {
        public PilotoRepositorio()
        {

        }

        public Piloto Detalhe(Piloto pPiloto)
        {
            throw new NotImplementedException();
        }

        public IList<DadosLog> Piloto(Piloto pPiloto)
        {
            throw new NotImplementedException();
        }

        public bool Salvar(Piloto pPiloto)
        {
            throw new NotImplementedException();
        }
    }
}
