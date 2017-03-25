using Repositorio;
namespace Aplicacao.Construtor
{
    public class PilotoAplicacaoConstrutor
    {
         public static PilotoAplicacao PilotoAplicacao()
        {
            //Encapsula o construtor do PilotoRepositorio
            return new PilotoAplicacao(new PilotoRepositorio());
        }
    }
}
