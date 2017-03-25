using System;
using System.Collections.Generic;
using Dominio;
using Dominio.Interface;


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

       
        public bool Salvar(ResultadoCorrida param)
        {
            throw new NotImplementedException();
        }

        public IList<ResultadoCorrida> Listar(ResultadoCorrida param)
        {
            throw new NotImplementedException();
        }

        public ResultadoCorrida Detalhe(ResultadoCorrida param)
        {
            throw new NotImplementedException();
        }
    }
}
