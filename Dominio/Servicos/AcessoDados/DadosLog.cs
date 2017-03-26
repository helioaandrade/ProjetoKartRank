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

        public IList<DadosLog> ObterDadosLog()
        {
            string path = string.Empty;

            string[] linhas = null;

            try
            {
                path = Path.Combine("../../ArquivosLog/", nomeArquivo);

                linhas = File.ReadAllLines(path);

                return MontarObjetoDadosLog(linhas);

            }
            catch (Exception ex)
            {

                 
            }

            return DadosTestesUnitarios();

        }

        public IList<DadosLog> DadosTestesUnitarios()
        {
              IList<DadosLog> DadosLog = new List<DadosLog>();

             
                DadosLog.Add(new DadosLog()
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 49, seconds: 10, milliseconds: 858),
                    NomePiloto = "033–R.BARRICHELLO",
                    NumeroVolta = 1,
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 4, milliseconds: 352),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 43, milliseconds: 243)
                });

                //23:50:14.860      033 – R.BARRICHELLO           2       1:04.002            43,48
                DadosLog.Add(new DadosLog()
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 50, seconds: 14, milliseconds: 860),
                    NomePiloto = "033–R.BARRICHELLO",
                    NumeroVolta = 2,
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 4, milliseconds: 2),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 43, milliseconds: 48)
                });

                //23:51:18.576      033 – R.BARRICHELLO           3       1:03.716            43,675
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 51, seconds: 18, milliseconds: 576),
                    NomePiloto = "033–R.BARRICHELLO",
                    NumeroVolta = 3,
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 3, milliseconds: 716),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 43, milliseconds: 675)
                });

                //23:52:22.586      033 – R.BARRICHELLO           4       1:04.010            43,474
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 53, seconds: 22, milliseconds: 586),
                    NomePiloto = "033–R.BARRICHELLO",
                    NumeroVolta = 4,
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 4, milliseconds: 10),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 43, milliseconds: 474)
                });

                //23:49:11.075     002 – K.RAIKKONEN         1       1:04.108            43,408
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 49, seconds: 11, milliseconds: 075),
                    NomePiloto = "002–K.RAIKKONEN",
                    NumeroVolta = 1,
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 4, milliseconds: 108),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 43, milliseconds: 408)
                });
 
                //23:50:15.057      002 – K.RAIKKONEN         2       1:03.982            43,493
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 50, seconds: 15, milliseconds: 57),
                    NomePiloto = "002–K.RAIKKONEN",
                    NumeroVolta = 2,
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 3, milliseconds: 982),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 43, milliseconds: 493)
                });

                // Volta 3

                //23:51:19.044      002 – K.RAIKKONEN         3       1:03.987            43,49
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 51, seconds: 19, milliseconds: 044),
                    NomePiloto = "002–K.RAIKKONEN",
                    NumeroVolta = 3,
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 3, milliseconds: 987),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 43, milliseconds: 49)
                });

                //23:52:22.120      002 – K.RAIKKONEN         4       1:03.076            44,118
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 52, seconds: 22, milliseconds: 120),
                    NomePiloto = "002–K.RAIKKONEN",
                    NumeroVolta = 4,
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 3, milliseconds: 76),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 44, milliseconds: 118)
                });

                //23:49:30.976      015 – F.ALONSO            1       1:18.456            35,47
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 49, seconds: 30, milliseconds: 976),
                    NomePiloto = "015–F.ALONSO",
                    NumeroVolta = 1,
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 18, milliseconds: 456),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 35, milliseconds: 47)
                });

                //23:50:37.987      015 – F.ALONSO            2       1:07.011            41,528
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 50, seconds: 37, milliseconds: 987),
                    NomePiloto = "015–F.ALONSO",
                    NumeroVolta = 2,
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 7, milliseconds: 11),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 41, milliseconds: 528)
                });

                //23:51:46.691      015 – F.ALONSO            3       1:08.704            40,504
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 51, seconds: 46, milliseconds: 691),
                    NomePiloto = "015–F.ALONSO",
                    NumeroVolta = 3,
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 8, milliseconds: 704),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 40, milliseconds: 504)
                });

                //23:53:06.741      015 – F.ALONSO            4       1:20.050            34,763
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 53, seconds: 6, milliseconds: 741),
                    NomePiloto = "015–F.ALONSO",
                    NumeroVolta = 4,
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 20, milliseconds: 50),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 34, milliseconds: 763)
                });

                //23:49:12.667      023 – M.WEBBER            1       1:04.414            43,202
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 49, seconds: 12, milliseconds: 667),
                    NomePiloto = "023–M.WEBBER",
                    NumeroVolta = 1,
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 4, milliseconds: 414),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 43, milliseconds: 202)
                });

                //23:50:17.472      023 – M.WEBBER            2       1:04.805            42,941
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 50, seconds: 17, milliseconds: 472),
                    NomePiloto = "023–M.WEBBER",
                    NumeroVolta = 2,
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 4, milliseconds: 805),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 42, milliseconds: 941)
                });

                //23:51:21.759      023 – M.WEBBER            3       1:04.287            43,287
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 51, seconds: 21, milliseconds: 759),
                    NomePiloto = "023–M.WEBBER",
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 4, milliseconds: 287),
                    NumeroVolta = 3,
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 43, milliseconds: 287)
                });

                //23:52:25.975      023 – M.WEBBER            4       1:04.216            43,335
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 52, seconds: 25, milliseconds: 975),
                    NumeroVolta = 4,
                    NomePiloto = "023–M.WEBBER",
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 4, milliseconds: 216),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 43, milliseconds: 335)
                });

                //23:52:01.796      011 – S.VETTEL            1       3:31.315            13,169
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 52, seconds: 1, milliseconds: 796),
                    NomePiloto = "011–S.VETTEL",
                    NumeroVolta = 1,
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 31, milliseconds: 315),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 13, milliseconds: 169)
                });

                //23:53:39.660      011 – S.VETTEL            2       1:37.864            28,435
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 53, seconds: 39, milliseconds: 660),
                    NomePiloto = "011–S.VETTEL",
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 37, milliseconds: 864),
                    NumeroVolta = 2,
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 28, milliseconds: 435)
                });

                //23:54:57.757      011 – S.VETTEL            3       1:18.097            35,633
                DadosLog.Add(new DadosLog
                {
                    Hora = new TimeSpan(days: 0, hours: 23, minutes: 54, seconds: 57, milliseconds: 757),
                    NumeroVolta = 3,
                    NomePiloto = "011–S.VETTEL",
                    Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 18, milliseconds: 97),
                    VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 35, milliseconds: 633)
                });

             //23:49:30.976      015 – F.ALONSO            1       1:18.456            35,47
            DadosLog.Add(new DadosLog
            {
                Hora = new TimeSpan(days: 0, hours: 23, minutes: 49, seconds: 30, milliseconds: 976),
                NomePiloto = "015–F.ALONSO",
                NumeroVolta = 1,
                Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 18, milliseconds: 456),
                VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 35, milliseconds: 47)
            });
 
            //23:50:37.987      015 – F.ALONSO            2       1:07.011            41,528
            DadosLog.Add(new DadosLog
            {
                Hora = new TimeSpan(days: 0, hours: 23, minutes: 50, seconds: 37, milliseconds: 987),
                NomePiloto = "015–F.ALONSO",
                NumeroVolta = 2,
                Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 7, milliseconds: 11),
                VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 41, milliseconds: 528)
            });

            //23:51:46.691      015 – F.ALONSO            3       1:08.704            40,504
            DadosLog.Add(new DadosLog
            {
                Hora = new TimeSpan(days: 0, hours: 23, minutes: 51, seconds: 46, milliseconds: 691),
                NomePiloto = "015–F.ALONSO",
                NumeroVolta = 3,
                Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 8, milliseconds: 704),
                VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 40, milliseconds: 504)
            });

            //23:53:06.741      015 – F.ALONSO            4       1:20.050            34,763
            DadosLog.Add(new DadosLog
            {
                Hora = new TimeSpan(days: 0, hours: 23, minutes: 53, seconds: 6, milliseconds: 741),
                NomePiloto = "015–F.ALONSO",
                NumeroVolta = 4,
                Tempo = new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 20, milliseconds: 50),
                VelocidadeMedia = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 34, milliseconds: 763)
            });

            return DadosLog;
            
        }

        public IList<DadosLog> MontarObjetoDadosLog(string[] linhas)
        {
            IList<DadosLog> lsDados = new List<DadosLog>();

            try
            {
                foreach (var linha in linhas)
                {
                    string myLinha = linha.Replace(" – ", "–");

                    char[] sepTabulacao = { '\t' };

                    string[] aux = myLinha.Split(sepTabulacao);

                    string hora = aux[0];

                    string nomePiloto = aux[1];
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

                    // Montar objeto DadosLog
                    lsDados.Add(new DadosLog()
                    {
                        Hora =
                            new TimeSpan(days: 0, hours: hoursHora, minutes: minutesHora, seconds: secondsHora,
                                milliseconds: millisecondsHora),
                        NomePiloto = nomePiloto,
                        NumeroVolta = Convert.ToInt32(numeroVolta),
                        Tempo =
                            new TimeSpan(days: 0, hours: 0, minutes: minutesTempo, seconds: secondsTempo,
                                milliseconds: millisecondsTempo),
                        VelocidadeMedia = new TimeSpan(hours: 0, minutes: secondsMedia, seconds: millisecondsMedia)
                    });
                }

            }
            catch (Exception ex)
            {

                string err = ex.Message;
            }

            return lsDados;
        }


    }




}
