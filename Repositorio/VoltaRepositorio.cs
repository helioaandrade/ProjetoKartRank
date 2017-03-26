using System;
using System.Collections.Generic;
using System.Linq;
using Dominio;
using Dominio.Interface;

namespace Repositorio
{
    public class VoltaRepositorio : IVolta<Volta>
    {
        private IList<DadosLog> _DadosLog = new List<DadosLog>();

        public VoltaRepositorio()
        {
            // Simular acesso a base de dados de log
            Dominio.Servicos.AcessoDados dados = new Dominio.Servicos.AcessoDados();
            _DadosLog = dados.ObterDadosLog();
        }
 

        public IList<Volta> Listar(Volta param)
        {
               IList<Volta> lstVolta = new List<Volta>();
            
                foreach (var dado in _DadosLog)
                {
                        Volta infoVolta = new Volta();
                        infoVolta.NomePiloto = dado.NomePiloto;
                        infoVolta.NumeroVolta = dado.NumeroVolta;
                        infoVolta.TempoGasto = dado.Tempo;
                        infoVolta.Hora = dado.Hora;
                        infoVolta.VelocidadeMedia = dado.VelocidadeMedia;

                        lstVolta.Add(infoVolta);
                 }

            return lstVolta.OrderByDescending(x => x.NumeroVolta).ThenBy(x => x.Hora).ToList();
        }

      
    }
}
