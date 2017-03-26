using Repositorio;
using Dominio;
using Dominio.Interface;
using System.Collections.Generic;

namespace Aplicacao
{
    public class PilotoAplicacao
    {
        private readonly IPiloto<Piloto> repositorio;

        #region Construtor
        public PilotoAplicacao(PilotoRepositorio repo)
        {
            repositorio = repo;
        }

        #endregion

        #region Métodos

        public IList<Piloto> Listar(Piloto param)
        {
            return repositorio.Listar(param);
        }

        #endregion
    }
}
