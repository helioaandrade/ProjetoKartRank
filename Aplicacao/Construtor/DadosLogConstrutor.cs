 
using Repositorio;

namespace Aplicacao.Construtor
{
    public class DadosLogAplicacaoConstrutor
    {
         public static DadosLogAplicacao DadosLogAplicacao()
        {
            //Encapsula o construtor do DadosLogRepositorio
            return new DadosLogAplicacao(new DadosLogRepositorio());
        }
    }

}
