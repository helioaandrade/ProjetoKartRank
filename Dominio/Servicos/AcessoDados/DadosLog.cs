using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Dominio.Servicos
{
    /// <summary>
    /// Camada para simular acesso a um serviço para obter Dados do log
    /// </summary>
    public class AcessoDados
    {
        private string nomeArquivo;

        public AcessoDados()
        {

         nomeArquivo = ConfigurationManager.AppSettings["NomeArquivoLog"].ToString();

        }
         
        public IList<DadosLog> LerArquivoLog()
        {
           
            string path = Path.Combine("../../ArquivosLog/", nomeArquivo);

            string[] linhas= File.ReadAllLines(path);

            IList<DadosLog> lsDados = new List<DadosLog>();

          
            try
            {
                // Montar objeto DadosLog
                foreach (var linha in linhas)
                {
                    // Desprezar 1a linha 

                    string myLinha = linha.Replace(" – ", "–");

                    char[] sepTabulacao = { '\t' };
  
                    string[] aux = myLinha.Split(sepTabulacao);
                   
                    //Hora			  Piloto	      		Nº Volta     Tempo Volta	   Velocidade média da volta
                  
                    string hora = aux[0];

                    string nomePiloto = aux[1] ;
                    string numeroVolta = aux[2];
                    string tempoVolta = aux[3];
                    string velocidadeMedia = aux[4];

                    char[] separador = { ':', '.', ',' };

                    string[] auxHora = hora.Split(separador);

                    int hoursHora = Convert.ToInt32(auxHora[0]);
                    int minutesHora = Convert.ToInt32(auxHora[1]);
                    int secondsHora = Convert.ToInt32(auxHora[2]);
                    int millisecondsHora = Convert.ToInt32(auxHora[3]);

                    string[] auxTempo = tempoVolta.Split(separador);
                     
                    int minutesTempo = Convert.ToInt32(auxTempo[0]);
                    int secondsTempo = Convert.ToInt32(auxTempo[1]);
                    int millisecondsTempo = Convert.ToInt32(auxTempo[2]);
                      
                    string[] auxVelocMedia = velocidadeMedia.Split(separador);

                    int secondsMedia = Convert.ToInt32(auxVelocMedia[0]);
                    int millisecondsMedia = Convert.ToInt32(auxVelocMedia[1]);
                      
                    lsDados.Add(new DadosLog()
                    {
                        Hora = new TimeSpan(days: 0, hours: hoursHora, minutes: minutesHora, seconds: secondsHora, milliseconds: millisecondsHora),
                        NomePiloto = nomePiloto,
                        NumeroVolta = Convert.ToInt32(numeroVolta),
                        Tempo = new TimeSpan(days: 0, hours: 0, minutes: minutesTempo, seconds: secondsTempo, milliseconds: millisecondsTempo),
                        VelocidadeMedia = new TimeSpan(hours: 0, minutes: secondsMedia, seconds: millisecondsMedia)
                    });
                }
           
            }
            catch (Exception ex)
            {

                string err = ex.Message ;
            }
        
             return  lsDados;
        }

        public IList<DadosLog> ObterDadosLog()
        {
             
            return LerArquivoLog();


        }
    }
}
