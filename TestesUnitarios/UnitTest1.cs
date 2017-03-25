using Aplicacao;
using Aplicacao.Construtor;
using Dominio;
 
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestesUnitarios
{
    [TestClass()]
    public class UnitTestClass
    {

        private readonly DadosLogAplicacao appDadosLog;
        private readonly PilotoAplicacao appPiloto;
        private readonly VoltaAplicacao appVolta;
        
        public UnitTestClass()
        {
            appDadosLog = DadosLogAplicacaoConstrutor.DadosLogAplicacao();
            appPiloto = PilotoAplicacaoConstrutor.PilotoAplicacao();
            appVolta = VoltaAPlicacaoConstrutor.VoltaAplicacao();
       
        }

      

        /// <summary>
        /// Descobrir a melhor volta de cada piloto
        /// </summary>
        [TestMethod()]
        public void MelhorVoltaPiloto()
        {
        
        }

        /// <summary>
        /// Descobrir a melhor volta da corrida
        /// </summary>
        [TestMethod()]
        public void MelhorVoltaCorrida()
        {

        }


        /// <summary>
        /// Calcular a velocidade média de cada piloto durante toda corrida
        /// </summary>
        [TestMethod()]
        public void CalcularMediaVelocidadeCorrida()
        {

        }

        /// <summary>
        /// Descobrir quanto tempo cada piloto chegou após o vencedor
        /// </summary>
        [TestMethod()]
        public void TempoGastodoPiloto()
        {

        }

       }
    }
