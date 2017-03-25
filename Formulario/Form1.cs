using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacao;
using Aplicacao.Construtor;
using Dominio;

namespace Formulario
{
    public partial class Form1 : Form
    {
        const string traco = "--------------------------------------------------------------------------------------------";

        public Form1()
        {

            InitializeComponent();
            
        }
 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region Métodos que chamam os serviços


        /// <summary>
        /// Descobrir a melhor volta de cada piloto
        /// </summary>

        public static string MelhorVoltaPiloto(IList<Piloto> lsPiloto)
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
                sb.AppendFormat("Piloto:{0,-20} - Melhor Volta da Corrida:{1}{2}", piloto.NomePiloto, piloto.NumeroVolta, Environment.NewLine);

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

                double media = piloto.Voltas.Average(x => x.TempoGasto.TotalMilliseconds / 1000);

                TimeSpan ts = TimeSpan.FromSeconds(media);

                sb.AppendFormat("Piloto:{0,-20} - Velocidade Média:{1}{2}", piloto.NomePiloto, ts.ToString(), Environment.NewLine);

            }
 
            return sb.ToString();

        }

        /// <summary>
        /// Descobrir quanto tempo cada piloto chegou após o vencedor
        /// </summary>

        public static string TempoGastodoPilotoAposVencedor(IList<Piloto> lsPiloto)
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }


        public static string ObterListaVoltas(IList<Volta> lsVolta)
        {
            StringBuilder sb = new StringBuilder();

            lsVolta = lsVolta.Where(x => x.NumeroVolta == 4).OrderBy(x => x.Hora).ToList();

            TimeSpan p1 = lsVolta[0].Hora;  // Hora de chegada do vencedor

            sb.AppendLine("Posição     Nome Piloto         Tempo Após Vencedor");
            sb.AppendLine(traco);

            int posicao = 1;
            foreach (Volta volta in lsVolta)
            {
                 TimeSpan tsTempo = TimeSpan.FromSeconds(volta.TempoGasto.TotalMilliseconds / 1000);

                TimeSpan tsHora = TimeSpan.FromSeconds(volta.Hora.TotalMilliseconds / 1000);

                TimeSpan tsAposVencedor = TimeSpan.FromSeconds(tsHora.Subtract(p1).TotalMilliseconds / 1000);

                sb.AppendFormat("{0,-10} {1,-20} {2,-15}", 
                                 posicao ,
                                 volta.NomePiloto,
                                 posicao > 1 ? tsAposVencedor.ToString() : string.Empty);
                sb.AppendLine();

                posicao++;
            }

            return sb.ToString();

        }

        #endregion

        #region Botões


        /// <summary>
        /// Melhor volta de cada piloto na corrida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            DadosLogAplicacao appDadosLog;
            PilotoAplicacao appPiloto;

            appDadosLog = DadosLogAplicacaoConstrutor.DadosLogAplicacao();
            appPiloto = PilotoAplicacaoConstrutor.PilotoAplicacao();

            var lsDadosLog = appDadosLog.Listar();

            StringBuilder sb = new StringBuilder();

            // Obter lista de pilotos com suas respectivas voltas
            var lstPiloto = appPiloto.Listar(new Piloto());

            string resultado = MelhorVoltaPiloto(lstPiloto);

            txtResultado.Text = resultado;
        }


        /// <summary>
        /// Melhor volta da corrida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            txtResultado.Text = "";
            DadosLogAplicacao appDadosLog;
            PilotoAplicacao appPiloto;
         
            appDadosLog = DadosLogAplicacaoConstrutor.DadosLogAplicacao();
            appPiloto = PilotoAplicacaoConstrutor.PilotoAplicacao();
         

            var lsDadosLog = appDadosLog.Listar();
                
            // Descobrir a melhor volta da corrida	
            string resultado = MelhorVoltaCorrida(lsDadosLog);

            txtResultado.Text = resultado;
            txtResultado.Refresh();
            
        }

        /// <summary>
        /// Velocidade média de cada piloto na corrida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";

            DadosLogAplicacao appDadosLog;
            PilotoAplicacao appPiloto;
            
            appDadosLog = DadosLogAplicacaoConstrutor.DadosLogAplicacao();
            appPiloto = PilotoAplicacaoConstrutor.PilotoAplicacao();

            // Obter lista de pilotos com suas respectivas voltas
            var lstPiloto = appPiloto.Listar(new Piloto());
   
            // Calcular a velocidade média de cada piloto durante toda corrida	
            string resultado = CalcularMediaVelocidadeCorrida(lstPiloto);
            txtResultado.Text = resultado;

        }


        /// <summary>
        /// Tempo de cada piloto após a chegada do vencedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {

            txtResultado.Text = "";
      
        }

        #endregion

        /// <summary>
        /// Limpar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {

            txtResultado.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            VoltaAplicacao appVolta;

            appVolta = VoltaAPlicacaoConstrutor.VoltaAplicacao();

            var lsVolta = appVolta.Listar(new Volta());

            string resultado = ObterListaVoltas(lsVolta);

            txtResultado.Text = resultado;
        }

        /// <summary>
        /// Ordenar por ordem de chegada em cada volta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            VoltaAplicacao appVolta;

            appVolta = VoltaAPlicacaoConstrutor.VoltaAplicacao();

            var lsVolta = appVolta.Listar(new Volta());

            string resultado = ObterListaVoltas(lsVolta);

            txtResultado.Text = resultado;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string aux = @"Resultado esperado
     A partir de um input de um arquivo de log do formato acima, montar o resultado da corrida com as seguintes informações:
    -Posição Chegada,
    -Código Piloto,
    -Nome Piloto, 
    -Qtde Voltas Completadas e
    -Tempo Total de Prova.

 Observações
     A primeira linha do arquivo pode ser desconsiderada(Hora, Piloto, Nº Volta, Tempo Volta, Velocidade média da volta).
     A corrida termina quando o primeiro colocado completa 4 voltas

 Bônus
Não obrigatório. Faça apenas caso se identifique com o problema ou se achar que há algo interessante a ser mostrado na solução

    Descobrir a melhor volta de cada piloto
    Descobrir a melhor volta da corrida
    Calcular a velocidade média de cada piloto durante toda corrida";

            txtResultado.Text = aux;
        }

        /// <summary>
        /// Resultado da corrida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            /***************************************************************************************
              Resultado esperado
             -------------------------------------------------------------------------------------
                A partir de um input de um arquivo de log do formato acima, montar o resultado da
                corrida com as seguintes informações:
                -Posição Chegada
                -Código Piloto
                -Nome Piloto
                -Qtde Voltas Completadas
                -Tempo Total de Prova
              ***********************************************************************************/

    
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
            txtResultado.Text = sb.ToString();
        }
 
   }
}
