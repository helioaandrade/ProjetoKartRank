using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Aplicacao;
using Aplicacao.Construtor;
using Dominio;
using Controles;
  
namespace Console
{
    public class Program
    {
      const string traco= "----------------------------------------------------------------------";

        static void Main(string[] args)
        {

            #region Chamar camada de view controller para obter os resultados
            // Descobrir a melhor volta de cada piloto	
            string result1 = new ViewController().MelhorVoltaPiloto();

            //// Descobrir a melhor volta da corrida	
            string result2 = new ViewController().MelhorVoltaCorrida();

            // Calcular a velocidade média de cada piloto durante toda corrida	
            string result3 = new ViewController().CalcularMediaVelocidadeCorrida();

            // Descobrir quanto tempo cada piloto chegou após o vencedor
            string result4 = new ViewController().TempoGastoPilotoAposVencedor();

            string result5 = new ViewController().ResultadoFinal();

            #endregion

            #region Exibição de resultados
             
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(traco);
            sb.AppendLine("Melhor Volta de Cada Piloto");
            sb.AppendLine(traco);
            sb.AppendLine(result1);

            sb.AppendLine(traco);
            sb.AppendLine("Melhor Volta da Corrida");
            sb.AppendLine(traco);
            sb.AppendLine(result2);

            sb.AppendLine(traco);
            sb.AppendLine("Velocidade Média de cada Piloto durante toda corrida");
            sb.AppendLine(traco);

            sb.AppendLine(result3);
              
            sb.AppendLine(traco);
            sb.AppendLine("Tempo que cada piloto gastou após a chegada do Vencedor");
           sb.AppendLine(traco);
            sb.AppendLine(result4);

            sb.AppendLine(traco);
            sb.AppendLine("RESULTADO FINAL DA CORRIDA");
            sb.AppendLine(traco);

            sb.AppendLine(result5);

            string resultado = sb.ToString();

             // Exibir no console ou gravar em uma arquivo
              System.Console.WriteLine(resultado);

              System.Console.ReadKey();

             // Gravar resultado em arquivo
              GravarArquivoLog("resultado.txt", resultado);

            #endregion

        }
            
        public static void GravarArquivoLog(string nomeArquivo, string pMensagem)
        {
            var encoding = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier: false);  
   
            using (StreamWriter writer = new StreamWriter(nomeArquivo, true, encoding))
            {
                writer.WriteLine(pMensagem);
                writer.Close();
                writer.Dispose();
            }

        }

         
    }
}
