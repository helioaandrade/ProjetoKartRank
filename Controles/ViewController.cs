using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacao;
using Aplicacao.Construtor;
using Dominio;

namespace Controles
{
    public class ViewController
    {
        const string traco = "----------------------------------------------------------------------";

        public ViewController()
        {
                
        }

        public string ResultadoFinal()
        {
            StringBuilder sb = new StringBuilder();

            ResultadoCorridaAplicacao appResultadoCorrida;

            appResultadoCorrida = ResultadoCorridaConstrutor.ResultadoCorridaAplicacao();

            var lsResultado = appResultadoCorrida.ResultadoFinal();

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


        public string MelhorVoltaCorrida()
        {
            StringBuilder sb = new StringBuilder();

            DadosLogAplicacao appDadosLog;

            appDadosLog = DadosLogAplicacaoConstrutor.DadosLogAplicacao();
            var lsDadosLog = appDadosLog.Listar();

            sb.AppendLine("Nome Piloto        Volta");
            sb.AppendLine(traco);

            var piloto = lsDadosLog.OrderBy(x => x.Tempo).FirstOrDefault();

            if (piloto != null)
                sb.AppendFormat("{0,-20} {1,-10}{2}", piloto.NomePiloto, piloto.NumeroVolta, Environment.NewLine);

            sb.AppendLine(traco);
            return sb.ToString();
        }

        public string MelhorVoltaPiloto()
        {
            StringBuilder sb = new StringBuilder();

            PilotoAplicacao appPiloto;

            appPiloto = PilotoAplicacaoConstrutor.PilotoAplicacao();
 
            var lsPiloto = appPiloto.Listar(new Piloto());

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


        public string TempoGastoPilotoAposVencedor()
        {
            StringBuilder sb = new StringBuilder();
             
            VoltaAplicacao appVolta;

            appVolta = VoltaAPlicacaoConstrutor.VoltaAplicacao();
             
            IList<Volta> lsVolta = appVolta.Listar(new Volta());

            int ultimaVolta = lsVolta.Max(x => x.NumeroVolta);
            lsVolta = lsVolta.Where(x => x.NumeroVolta == ultimaVolta).OrderBy(x => x.Hora).ToList();

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

        }

        public string CalcularMediaVelocidadeCorrida()
        {
            StringBuilder sb = new StringBuilder();

            PilotoAplicacao appPiloto;

            appPiloto = PilotoAplicacaoConstrutor.PilotoAplicacao();
             
            IList<Piloto> lsPiloto = appPiloto.Listar(new Piloto());
            
            sb.AppendLine("Nome Piloto          Velocidade Média");
            sb.AppendLine(traco);

            foreach (Piloto piloto in lsPiloto)
            {
                var voltas = piloto.Voltas;

                double media = piloto.Voltas.Average(x => x.VelocidadeMedia.TotalMilliseconds / 1000);

                TimeSpan ts = TimeSpan.FromSeconds(media);

                sb.AppendFormat("{0,-20} {1}{2}", piloto.NomePiloto, ts.ToString(), Environment.NewLine);
             }

            sb.AppendLine(traco);
            return sb.ToString();
         }
    }
}
