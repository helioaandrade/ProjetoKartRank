using System;
using System.Collections.Generic;
 
namespace Dominio.Interface
{
  
    public interface IResultadoCorrida<T> where T : class
    {
        IList<Piloto> TempoGastoPilotoAposVencedor();
        IList<ResultadoCorrida> ResultadoFinal( );
        IList<DadosLog> MelhorVoltaCorrida();
        IList<Piloto> MelhorVoltaPiloto();
     }
}
