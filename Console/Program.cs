using System;
using System.Collections.Generic;
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
      
        static void Main(string[] args)
        {
               
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

                        // Descobrir quanto tempo cada piloto chegou após o vencedor
                            TempoGastodoPilotoAposVencedor(lstPiloto);

                        // Montar resultado
                         sb.AppendLine(result1);
                         sb.AppendLine(result2);
                         sb.AppendLine(result3);

                        // Exivir no console ou gravar em uma arquivo

                        string resultado = sb.ToString();

                        GravarArquivoLog("resultado.txt", resultado);

            #endregion

        }
 

        /// <summary>
        /// Descobrir a melhor volta de cada piloto
        /// </summary>

        public static string MelhorVoltaPiloto(IList<Piloto> lsPiloto )
        {
            StringBuilder sb = new StringBuilder();

            foreach (var piloto in lsPiloto)
            {
                var myPiloto = piloto.Voltas.OrderBy(x => x.TempoGasto).FirstOrDefault();

                if (myPiloto != null)
                {
                    sb.AppendFormat("Piloto: {0,-20} - Melhor Volta: {1}{2}", piloto.NomePiloto, myPiloto.NumeroVolta, Environment.NewLine);
                  
                 }
            }
            
            return sb.ToString();
        }

        /// <summary>
        /// Descobrir a melhor volta da corrida
        /// </summary>
      
        public static string MelhorVoltaCorrida(IList<DadosLog> lsDadosLog)
        {
            StringBuilder sb = new StringBuilder();

            var piloto = lsDadosLog.OrderBy(x => x.Tempo).FirstOrDefault();
             
            if (piloto != null)
                sb.AppendFormat("Piloto:{0,-20}-Melhor Volta da Corrida:{1}{2}", piloto.NomePiloto, piloto.NumeroVolta, Environment.NewLine);

           return sb.ToString();
        }


        /// <summary>
        /// Calcular a velocidade média de cada piloto durante toda corrida
        /// </summary>
       
        public static string CalcularMediaVelocidadeCorrida(IList<Piloto> lsPiloto)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Piloto piloto in lsPiloto)
            {
                var voltas = piloto.Voltas;
 
                double totalMiliSegundos = piloto.Voltas.Sum(x => x.TempoGasto.TotalMilliseconds);

                double media = piloto.Voltas.Average(x => x.TempoGasto.TotalMilliseconds/1000);
                
                TimeSpan ts = TimeSpan.FromSeconds(media);
  
                sb.AppendFormat("Piloto:{0,-20} - Velocidade Média:{1}{2}", piloto.NomePiloto, ts.ToString(), Environment.NewLine);
 
            }


            return sb.ToString();

        }

        /// <summary>
        /// Descobrir quanto tempo cada piloto chegou após o vencedor
        /// </summary>

        public static string  TempoGastodoPilotoAposVencedor(IList<Piloto> lsPiloto)
        {
            StringBuilder sb = new StringBuilder();

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
    }
}
