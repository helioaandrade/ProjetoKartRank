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
 
using Controles;

namespace Formulario
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
             InitializeComponent();
         }
 
        private void label1_Click(object sender, EventArgs e)
        {

        }
 
        #region Botões
         
        /// <summary>
        /// Melhor volta de cada piloto na corrida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = new ViewController().MelhorVoltaPiloto();
        }
 
        /// <summary>
        /// Melhor volta da corrida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
             txtResultado.Text = new ViewController().MelhorVoltaCorrida();
         }

        /// <summary>
        /// Velocidade média de cada piloto na corrida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
             txtResultado.Text = new ViewController().CalcularMediaVelocidadeCorrida();
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
             
        }

        /// <summary>
        /// Tempo que cada piloto chegou após o vencedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = new ViewController().TempoGastoPilotoAposVencedor();

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
             txtResultado.Text = new ViewController().ResultadoFinal();
        }
 
   }
}
