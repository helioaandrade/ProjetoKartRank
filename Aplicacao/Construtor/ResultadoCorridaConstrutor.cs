using Repositorio;

namespace Aplicacao.Construtor
{
    public class ResultadoCorridaConstrutor
    {

        public static ResultadoCorridaAplicacao ResultadoCorridaAplicacao()
        {
            //Encapsula o construtor do ResultadoCorridaRepositorio
            return new ResultadoCorridaAplicacao(new ResultadoCorridaRepositorio());
        }
    }
}
