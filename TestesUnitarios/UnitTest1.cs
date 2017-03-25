using System;
using Aplicacao;
using Aplicacao.Construtor;
using Dominio;
 
 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestesUnitarios
{

    [TestFixture]
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
        /// Obter dados do log que é usado como entrada de dados
        /// </summary>
        [Test]
        public void ObterDadosLog()
        {
            bool result = false;
 
            // Cenário
 
            PilotoAplicacao appPiloto;
    
            appPiloto = PilotoAplicacaoConstrutor.PilotoAplicacao();

            // Ação

            // Obter lista de pilotos com suas respectivas voltas
            var lstPiloto = appPiloto.Listar(new Piloto());
 
            // Validação
            result = lstPiloto.Count > 0;

            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Obter lista de pilotos
        /// </summary>
        [Test]
        public void ObterListaPilotos()
        {
             bool result = false;

            // Cenário
         
            PilotoAplicacao appPiloto;
            
            appPiloto = PilotoAplicacaoConstrutor.PilotoAplicacao();

            // Ação
            // Obter lista de pilotos com suas respectivas voltas
            var lstPiloto = appPiloto.Listar(new Piloto());

            // Validação
            result = lstPiloto.Count > 0;

            Assert.AreEqual(true, result);
        }
           

        /// <summary>
        ///  Obter resultado da corrida
        /// </summary>
        [Test]
        public void ObterResultado()
        {
             bool result = true;

            // Cenário

            // Ação

            // Validação

            Assert.AreEqual(true, result);
        }
 
    }

}

         
 


  
 
