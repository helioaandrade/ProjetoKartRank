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
  
namespace Console
{
    public class Program
    {
      const string traco= "----------------------------------------------------------------------";

        static void Main(string[] args)
        {

                     //    string nomeArquivo = ConfigurationManager.AppSettings["NomeArquivoLog"].ToString();

                         ResultadoCorridaAplicacao appResultadoCorrida;

                        appResultadoCorrida = ResultadoCorridaConstrutor.ResultadoCorridaAplicacao();
                      
                        DadosLogAplicacao appDadosLog;
                        PilotoAplicacao appPiloto;
                        VoltaAplicacao appVolta;

                        appDadosLog = DadosLogAplicacaoConstrutor.DadosLogAplicacao();
                        appPiloto = PilotoAplicacaoConstrutor.PilotoAplicacao();
             
                        var lsDadosLog = appDadosLog.Listar();

                        StringBuilder sb= new StringBuilder();


                        // Obter lista de pilotos com suas respectivas voltas
                        var lstPiloto = appPiloto.Listar(new Piloto());
             
                        #region Exibição de resultados
                         
                        // Descobrir a melhor volta de cada piloto		
                          string result1 = MelhorVoltaPiloto(lstPiloto);

                        // Descobrir a melhor volta da corrida	
                         string result2 =MelhorVoltaCorrida(lsDadosLog);

                        // Calcular a velocidade média de cada piloto durante toda corrida	
                         string result3 = CalcularMediaVelocidadeCorrida(lstPiloto);

                       
              
                        // Montar resultado
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
               
                        appVolta = VoltaAPlicacaoConstrutor.VoltaAplicacao();

                        var lsVolta = appVolta.Listar(new Volta());


                        // Descobrir quanto tempo cada piloto chegou após o vencedor
                        string result4 =TempoGastodoPilotoAposVencedor(lsVolta);

                        sb.AppendLine(traco);
                        sb.AppendLine("Tempo que cada piloto gastou após a chegada do Vencedor" );
                        sb.AppendLine(traco);
                        sb.AppendLine(result4);

                         // Resultado Final (Código/Nome Piloto, Posição, Qtde VoltasCompletadas, Tempo total gasto)

                        var lsResultado = appResultadoCorrida.ResultadoFinal();

                        string result5 = ResultadoFinal(lsResultado);

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

        #region Métodos

     
        /// <summary>
        /// Descobrir a melhor volta de cada piloto
        /// </summary>

        public static string MelhorVoltaPiloto(IList<Piloto> lsPiloto )
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nome Piloto        Melhor Volta");
            sb.AppendLine(traco);
            foreach (var piloto in lsPiloto)
            {
                var myPiloto = piloto.Voltas.OrderBy(x => x.TempoGasto).FirstOrDefault();

                if (myPiloto != null)
                {
                    sb.AppendFormat("{0,-20} {1}{2}", piloto.NomePiloto, myPiloto.NumeroVolta, Environment.NewLine);
                  
                 }
            }

            sb.AppendLine(traco);
            return sb.ToString();
        }

        /// <summary>
        /// Descobrir a melhor volta da corrida
        /// </summary>
      
        public static string MelhorVoltaCorrida(IList<DadosLog> lsDadosLog)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nome Piloto        Volta");
            sb.AppendLine(traco);

            var piloto = lsDadosLog.OrderBy(x => x.Tempo).FirstOrDefault();
             
            if (piloto != null)
                sb.AppendFormat("{0,-20} {1,-10}{2}", piloto.NomePiloto, piloto.NumeroVolta, Environment.NewLine);

            sb.AppendLine(traco);
            return sb.ToString();
        }


        /// <summary>
        /// Calcular a velocidade média de cada piloto durante toda corrida
        /// </summary>
       
        public static string CalcularMediaVelocidadeCorrida(IList<Piloto> lsPiloto)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nome Piloto          Velocidade Média");
            sb.AppendLine(traco);

            foreach (Piloto piloto in lsPiloto)
            {
                var voltas = piloto.Voltas;
 
                double totalMiliSegundos = piloto.Voltas.Sum(x => x.TempoGasto.TotalMilliseconds);

                double media = piloto.Voltas.Average(x => x.TempoGasto.TotalMilliseconds/1000);
                
                TimeSpan ts = TimeSpan.FromSeconds(media);
  
                sb.AppendFormat("{0,-20} {1}{2}", piloto.NomePiloto, ts.ToString(), Environment.NewLine);
 
            }

            sb.AppendLine(traco);
            return sb.ToString();

        }

        /// <summary>
        /// Descobrir quanto tempo cada piloto chegou após o vencedor
        /// </summary>

        public static string  TempoGastodoPilotoAposVencedor(IList<Volta> lsVolta)
        {
            StringBuilder sb = new StringBuilder();
 
            lsVolta = lsVolta.Where(x => x.NumeroVolta == 4).OrderBy(x => x.Hora).ToList();

            TimeSpan p1 = lsVolta[0].Hora;  // Hora de chegada do vencedor

            sb.AppendLine("Posição  Nome Piloto  Tempo Após Vencedor");
            sb.AppendLine(traco);

            int posicao = 1;
            foreach (Volta volta in lsVolta)
            {
                TimeSpan tsTempo = TimeSpan.FromSeconds(volta.TempoGasto.TotalMilliseconds / 1000);

                TimeSpan tsHora = TimeSpan.FromSeconds(volta.Hora.TotalMilliseconds / 1000);

                TimeSpan tsAposVencedor = TimeSpan.FromSeconds(tsHora.Subtract(p1).TotalMilliseconds / 1000);

                sb.AppendFormat("{0,-10} {1,-20} {2,-15}",
                                 posicao,
                                 volta.NomePiloto,
                                 posicao > 1 ? tsAposVencedor.ToString() : string.Empty);
                sb.AppendLine();

                posicao++;
            }

            return sb.ToString();

            return sb.ToString();
        }
 
        public static string ResultadoFinal(IList<ResultadoCorrida> lsResultado)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Posição   Código/Piloto   Qtde Voltas     Tempo Gasto");
            sb.AppendLine(traco);
 
            foreach (var resultado in lsResultado)
            {
                 sb.AppendFormat("{0,-10} {1}-{2,-15} {3,-10} {4,-10}",
                                 resultado.Posicao + "° Lugar",
                                 resultado.CodigoPiloto,
                                 resultado.NomePiloto,
                                 resultado.QtdeVoltasCompletadas,
                                 resultado.TempoTotalProva
                                 );
                sb.AppendLine();

            }
            sb.AppendLine(traco);
            return sb.ToString();
        }


        public static string ObterListaVoltas(IList<Volta> lsVolta)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nome Piloto                Hora          Volta       Tempo Gasto");
            sb.AppendLine(traco);

            foreach (Volta volta in lsVolta)
            {
                TimeSpan tsTempo = TimeSpan.FromSeconds(volta.TempoGasto.TotalMilliseconds / 1000);

                TimeSpan tsHora = TimeSpan.FromSeconds(volta.Hora.TotalMilliseconds / 1000);

                sb.AppendFormat("{0,-20} {1,-20} {2,-10} {3,10}",
                                 volta.NomePiloto,
                                 tsHora.ToString(),
                                 volta.NumeroVolta,
                                 tsTempo.ToString());
                sb.AppendLine();

            }

            return sb.ToString();

        }
        public static void GravarArquivoLog(string nomeArquivo, string pMensagem)
        {
            var encoding = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier: false); //Encoding.ASCII
  
 
            using (StreamWriter writer = new StreamWriter(nomeArquivo, true, encoding))
            {
                writer.WriteLine(pMensagem);
                writer.Close();
                writer.Dispose();
            }

        }

        #endregion
    }
}
