using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Dominio.Interface;
using Dominio.Servicos;

namespace Repositorio
{
    public class DadosLogRepositorio  : IDadosLog<DadosLog>
    {
        private IList<DadosLog> _DadosLog = new List<DadosLog>();

        public DadosLogRepositorio()
        {
             
        }
        public IList<DadosLog> Listar()
        {
            Dominio.Servicos.AcessoDados dados = new Dominio.Servicos.AcessoDados();

            return dados.ObterDadosLog();
        }

    }
}
