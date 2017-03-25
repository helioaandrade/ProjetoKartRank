
using Repositorio;
using Dominio;
using Dominio.Interface;
using System.Collections.Generic;

namespace Aplicacao
{
    public class DadosLogAplicacao
    {
        private readonly IDadosLog<DadosLog> repositorio;
         
        #region Construtor
        public DadosLogAplicacao(DadosLogRepositorio repo)
        {
            repositorio = repo;
        }

        #endregion
         
        #region Métodos
     
        public IList<DadosLog> Listar()
        {
            return repositorio.Listar();
        }
         
        #endregion
         
    }
}
