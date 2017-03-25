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
        public bool Salvar(Piloto param)
        {
            return repositorio.Salvar(param);
        }
 
        public IList<Piloto> Listar(Piloto param)
        {
            return repositorio.Listar(param);
        }

        public Piloto Detalhe(Piloto param)
        {
            return repositorio.Detalhe(param);
        }
        #endregion
    }
}
