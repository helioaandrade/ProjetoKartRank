using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Dominio.Interface;

namespace Repositorio
{
    public class PilotoRepositorio : IPiloto<Piloto>
    {

        private IList<DadosLog> _DadosLog = new List<DadosLog>();
           
        public PilotoRepositorio()
        {
            // Simular acesso a base de dados de log
             Dominio.Servicos.AcessoDados dados = new Dominio.Servicos.AcessoDados();
             _DadosLog = dados.ObterDadosLog();
        }
      
        public IList<Piloto> Listar(Piloto param)
        {
            IList<Piloto> lstPiloto = new List<Piloto>();
           
            
            // Agrupar dados do log por Pilotos 
            var grupoPilotos = _DadosLog.GroupBy(x => new { x.NomePiloto}).ToList();

            foreach ( var grupo in grupoPilotos)
            {
                 Piloto infoPiloto = new Piloto {NomePiloto = grupo.Key.NomePiloto};
 
                IList<Volta> lstVolta = new List<Volta>();

                // Carregar Voltas por piloto
                foreach (var dado in _DadosLog)
                {
                    if (dado.NomePiloto == grupo.Key.NomePiloto)
                    {
                         Volta infoVolta = new Volta();
                        infoVolta.NumeroVolta = dado.NumeroVolta;
                        infoVolta.TempoGasto = dado.Tempo;
                        infoVolta.Hora = dado.Hora;
                        infoVolta.VelocidadeMedia = dado.VelocidadeMedia;

                        lstVolta.Add(infoVolta);

                        infoPiloto.Voltas = lstVolta.OrderBy(x => x.TempoGasto).ToList();
                    }

                }
                     lstPiloto.Add(infoPiloto);
                    
            }

            if (param.NomePiloto != null)
                return lstPiloto.Where(x => x.NomePiloto == param.NomePiloto).ToList();
            else
                return lstPiloto;
        }

        public Piloto Detalhe(Piloto param)
        {
            return Listar(param).FirstOrDefault();
        }

        public bool Salvar(Piloto pPiloto)
        {
            throw new NotImplementedException();
        }

      
    }
}
