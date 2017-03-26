using Repositorio;
using Dominio;
using Dominio.Interface;
using System.Collections.Generic;

namespace Aplicacao
{
    public class ResultadoCorridaAplicacao
    {
       
        private readonly IResultadoCorrida<ResultadoCorrida> repositorio;
   

        #region Construtor

        public ResultadoCorridaAplicacao(ResultadoCorridaRepositorio repo)
        {
            repositorio= repo;
        }


        #endregion
        
        #region Métodos
        public IList<Piloto> TempoGastoPilotoAposVencedor()
        {
           return repositorio.TempoGastoPilotoAposVencedor();
        }

        public IList<ResultadoCorrida> ResultadoFinal()
        {
            return repositorio.ResultadoFinal();
        }

        public IList<Piloto> MelhorVoltaPiloto()
        {
             
            return repositorio.MelhorVoltaPiloto();
        }


        public IList<DadosLog> MelhorVoltaCorrida()
        {
            return repositorio.MelhorVoltaCorrida();
        }
        #endregion
    }
}
