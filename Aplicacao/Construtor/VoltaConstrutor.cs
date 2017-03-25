using Repositorio;

namespace Aplicacao.Construtor
{
    public class VoltaAPlicacaoConstrutor
    {
        public static VoltaAplicacao VoltaAplicacao()
        {
            //Encapsula o construtor do VoltaRepositorio
            return new VoltaAplicacao(new VoltaRepositorio());
        }
    }
}
