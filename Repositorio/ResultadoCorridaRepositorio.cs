using System;
using System.Collections.Generic;
using Dominio;
using Dominio.Interface;
using System.Linq;

namespace Repositorio
{
    public class ResultadoCorridaRepositorio : IResultadoCorrida<ResultadoCorrida>
    {

        private IList<DadosLog> _DadosLog = new List<DadosLog>();

        public ResultadoCorridaRepositorio()
        {
            // Simular acesso a base de dados de log
            Dominio.Servicos.AcessoDados dados = new Dominio.Servicos.AcessoDados();
            _DadosLog = dados.ObterDadosLog();
        }
         

        public IList<Piloto> TempoGastoPilotoAposVencedor()
        {
            throw new NotImplementedException();
        }

        public IList<ResultadoCorrida> ResultadoFinal()
        {
             IList<Piloto> lstPiloto = new PilotoRepositorio().Listar(new Piloto());
             IList<Volta> lstVolta = new VoltaRepositorio().Listar(new Volta());

            int ultimaVolta = lstVolta.Max(x => x.NumeroVolta);

            // Obter última volta
            lstVolta = lstVolta.Where(x => x.NumeroVolta == ultimaVolta).OrderBy(x => x.Hora).ToList();
  
            IList < ResultadoCorrida > lstResultado = new List<ResultadoCorrida>();
               
            foreach (var piloto in lstPiloto)
            {
                ResultadoCorrida infoResultado = new ResultadoCorrida();
                infoResultado.CodigoPiloto = piloto.NomePiloto.Split('–')[0];
                infoResultado.NomePiloto = piloto.NomePiloto.Split('–')[1];
                infoResultado.QtdeVoltasCompletadas = piloto.Voltas.Count;

                TimeSpan tsTempo = TimeSpan.FromSeconds(piloto.Voltas.Sum(x => x.TempoGasto.TotalMilliseconds) / 1000);

                infoResultado.TempoTotalProva = tsTempo;

                int posicao = 1;
                foreach (var volta in lstVolta)
                {
                    if (volta.NomePiloto.Equals(piloto.NomePiloto))
                    {
                        break;
                    }
                    posicao++;
                }

                infoResultado.Posicao = posicao;
                lstResultado.Add(infoResultado);
               
            }

            return lstResultado.OrderBy(x => x.Posicao).ToList();

        }

        public IList<DadosLog> MelhorVoltaCorrida()
        {
            throw new NotImplementedException();
        }

        public IList<Piloto> MelhorVoltaPiloto()
        {
            throw new NotImplementedException();
        }

        public ResultadoCorrida Detalhe(ResultadoCorrida param)
        {
            throw new NotImplementedException();
        }
    }
}
