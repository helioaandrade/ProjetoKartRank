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
      
        public IList<ResultadoCorrida> ResultadoFinal()
        {
            return repositorio.ResultadoFinal();
        }
         #endregion
    }
}
