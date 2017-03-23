using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Dominio.Interface;

namespace Repositorio
{
    public class DadosLogRepositorio : IDadosLog<DadosLog>
    {
        public DadosLogRepositorio()
        {

        }

        public DadosLog Detalhe(DadosLog pDadosLog)
        {
            throw new NotImplementedException();
        }

        public IList<DadosLog> Listar(DadosLog pDadosLog)
        {
            throw new NotImplementedException();
        }

        public bool Salvar(DadosLog pDadosLog)
        {
            throw new NotImplementedException();
        }
    }
}
