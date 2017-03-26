using Repositorio;
using Dominio;
using Dominio.Interface;
using System.Collections.Generic;

namespace Aplicacao
{
    public class VoltaAplicacao
    {
        private readonly IVolta<Volta> repositorio;

        #region Construtor
        public VoltaAplicacao(VoltaRepositorio repo)
        {
            repositorio = repo;
        }

        #endregion

        #region Métodos
       
        public IList<Volta> Listar(Volta param)
        {
            return repositorio.Listar(param);
        }
          
        #endregion
    }
}
