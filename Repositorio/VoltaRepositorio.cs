using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Dominio.Interface;

namespace Repositorio
{
    public class VoltaRepositorio : IVolta<Volta>
    {
        public VoltaRepositorio()
        {

        }

        public Volta Detalhe(Volta pVolta)
        {
            throw new NotImplementedException();
        }

        public IList<Volta> Lista(Volta pVolta)
        {
            throw new NotImplementedException();
        }

        public bool Salvar(Volta pVolta)
        {
            throw new NotImplementedException();
        }
    }
}
