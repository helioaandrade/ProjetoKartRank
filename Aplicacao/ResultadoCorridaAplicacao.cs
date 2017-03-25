using Repositorio;
using Dominio;
using Dominio.Interface;
using System.Collections.Generic;

namespace Aplicacao
{
    public class ResultadoCorridaAplicacao
    {
       
        private readonly IResultadoCorrida<ResultadoCorrida> repositorio;
        private ResultadoCorridaRepositorio resultadoCorridaRepositorio;

        #region Construtor

        public ResultadoCorridaAplicacao(ResultadoCorrida repo)
        {
             
        }

        public ResultadoCorridaAplicacao(ResultadoCorridaRepositorio resultadoCorridaRepositorio)
        {
            this.resultadoCorridaRepositorio = resultadoCorridaRepositorio;
        }
        #endregion

        #region Métodos
        public bool Salvar(ResultadoCorrida param)
        {
            return repositorio.Salvar(param);
        }

        public IList<ResultadoCorrida> Listar(ResultadoCorrida param)
        {
            return repositorio.Listar(param);
        }

        public ResultadoCorrida Detalhe(ResultadoCorrida param)
        {
            return repositorio.Detalhe(param);
        }
        #endregion
    }
}
