using System;
using System.Collections.Generic;
using System.Linq;
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
        public AcessoDados()
        {

        }

        public IList<DadosLog> ObterDadosLog()
        {
           
            return new List<DadosLog>
          {
              
                /*
                 23:49:08.277 	  038 – F.MASSA		  	  1		1:02.852 			44,275
23:50:11.447 	  038 – F.MASSA		  	  2		1:03.170 			44,053    
23:51:14.216 	  038 – F.MASSA		  	  3		1:02.769 			44,334 (1)
23:52:17.003 	  038 – F.MASSA		  	  4		1:02.787 			44,321
                 */    
 
            // 23:49:08.277 	  038 – F.MASSA		  	  	1		1:02.852 			44.275
            new DadosLog { Hora= new TimeSpan(days: 0 ,hours: 23, minutes: 49, seconds: 8, milliseconds:277),
                           NomePiloto ="038–F.MASSA",
                           NumeroVolta =1,
                           Tempo =new TimeSpan(days:0, hours:0,minutes: 08, seconds: 2,milliseconds:852),
                           VelocidadeMedia =new TimeSpan(hours: 49, minutes: 08, seconds: 277) },
       
               //23:50:11.447      038 – F.MASSA             2       1:03.170            44,053
            new DadosLog{ Hora= new TimeSpan(days:0, hours:23,minutes: 50, seconds: 11,milliseconds:447),
                          NomePiloto ="038–F.MASSA",
                          NumeroVolta =2,
                          Tempo =new TimeSpan(days:0, hours:0,minutes: 1, seconds: 3,milliseconds:170),
                          VelocidadeMedia =new TimeSpan(days:0, hours:0,minutes: 00, seconds: 44,milliseconds:53) },

              //23:51:14.216      038 – F.MASSA             3       1:02.769            44,334
            new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 51, seconds: 14, milliseconds:216),
                          NomePiloto="038–F.MASSA", NumeroVolta=3,
                          Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds:2 , milliseconds:769),
                          VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds:44 , milliseconds:334) },
 
              //23:52:17.003      038 – F.MASSA              4       1:02.787            44,321
             new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes:52, seconds: 17, milliseconds:003),
                           NomePiloto="038–F.MASSA",
                           NumeroVolta=4,
                           Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 2, milliseconds:787),
                           VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds:44 , milliseconds:321) },

             /*
              23:49:10.858 	  033 – R.BARRICHELLO		  1		1:04.352 			43,243   
23:50:14.860 	  033 – R.BARRICHELLO		  2		1:04.002 			43,48    
23:51:18.576 	  033 – R.BARRICHELLO		  3		1:03.716 			43,675 (1)
23:52:22.586 	  033 – R.BARRICHELLO		  4		1:04.010 			43,474
              */

              //23:49:10.858 	  033 – R.BARRICHELLO		1		1:04.352 			43.243
            new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 49, seconds:10 , milliseconds:858),
                           NomePiloto="033–R.BARRICHELLO",
                           NumeroVolta=1, Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds:4 , milliseconds:352),
                           VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds:43 , milliseconds:243) },
             
            //23:50:14.860      033 – R.BARRICHELLO           2       1:04.002            43,48
            new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 50, seconds:14 , milliseconds:860),
                          NomePiloto="033–R.BARRICHELLO",
                          NumeroVolta=2,
                          Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds:4 , milliseconds:003),
                          VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds:43 , milliseconds:48) },

            
            //23:51:18.576      033 – R.BARRICHELLO           3       1:03.716            43,675
            new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 51, seconds:18 , milliseconds:576),
                          NomePiloto="033–R.BARRICHELLO",
                          NumeroVolta=3,
                          Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds:3 , milliseconds:716 ),
                          VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds:43 , milliseconds:675) },
 
              //23:52:22.586      033 – R.BARRICHELLO           4       1:04.010            43,474
             new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 53, seconds: 22, milliseconds:586 ),
                           NomePiloto="033–R.BARRICHELLO",
                           NumeroVolta=4,
                           Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 4, milliseconds:010),
                           VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 42, milliseconds:586) },
            
             /*
              
23:49:11.075 	  002 – K.RAIKKONEN		  1		1:04.108 			43,408    
23:50:15.057 	  002 – K.RAIKKONEN		  2		1:03.982 			43,493
23:51:19.044 	  002 – K.RAIKKONEN		  3		1:03.987 			43,49
23:52:22.120 	  002 – K.RAIKKONEN		  4		1:03.076 			44,118  (1)
              */

            //23:49:11.075     002 – K.RAIKKONEN         1       1:04.108            43,408
            new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 49, seconds:11 , milliseconds:075),
                          NomePiloto="002–K.RAIKKONEN",
                          NumeroVolta=1, Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 4, milliseconds:107),
                          VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds:43 , milliseconds:408) },
          
         
            //23:50:15.057      002 – K.RAIKKONEN         2       1:03.982            43,493
            new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 50, seconds:15 , milliseconds:57 ),
                          NomePiloto="002–K.RAIKKONEN",
                          NumeroVolta=2,
                          Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds:3 , milliseconds:982),
                          VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 43, milliseconds:493) },
 
            // Volta 3
          
            //23:51:19.044      002 – K.RAIKKONEN         3       1:03.987            43,49
            new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 51, seconds:19 , milliseconds:044 ),
                          NomePiloto="002–K.RAIKKONEN",
                          NumeroVolta=3,
                          Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds:3 , milliseconds:987 ),
                          VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds:43 , milliseconds:49) },
 
            //23:52:22.120      002 – K.RAIKKONEN         4       1:03.076            44,118
            new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 52, seconds:22 , milliseconds:120),
                          NomePiloto="002–K.RAIKKONEN",
                          NumeroVolta=4,
                          Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 3, milliseconds:076),
                          VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 44, milliseconds:118) },
 
            //23:49:30.976      015 – F.ALONSO            1       1:18.456            35,47
            new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 49, seconds:30 , milliseconds:976),
                          NomePiloto="015–F.ALONSO",
                          NumeroVolta=1,
                          Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds:18 , milliseconds:456 ),
                          VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 35, milliseconds:47) },
          
               //23:50:37.987      015 – F.ALONSO            2       1:07.011            41,528
            new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 50, seconds:37 , milliseconds:987),
                          NomePiloto="015–F.ALONSO",
                          NumeroVolta=2, Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 7, milliseconds:011),
                          VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 41, milliseconds:528) },
            
              //23:51:46.691      015 – F.ALONSO            3       1:08.704            40,504
            new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 51, seconds: 46, milliseconds:691),
                          NomePiloto="015–F.ALONSO",
                          NumeroVolta=3,
                          Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds:8 , milliseconds:704 ),
                          VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 40, milliseconds:504) },
 
                  //23:53:06.741      015 – F.ALONSO            4       1:20.050            34,763
            new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 53, seconds:6 , milliseconds:741),
                          NomePiloto="015–F.ALONSO",
                          NumeroVolta=4,
                          Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds:20 , milliseconds:050),
                          VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds:34 , milliseconds:763) },
              
            //23:49:12.667      023 – M.WEBBER            1       1:04.414            43,202
             new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 49, seconds: 12, milliseconds:667),
                           NomePiloto="023–M.WEBBER",
                           NumeroVolta=1,
                           Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 4, milliseconds:414),
                           VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 43, milliseconds:202) },
            
            //23:50:17.472      023 – M.WEBBER            2       1:04.805            42,941
            new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes:50, seconds: 17, milliseconds:472),
                          NomePiloto="023–M.WEBBER",
                          NumeroVolta=2,
                          Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 4, milliseconds:805 ),
                          VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 42, milliseconds:472) },
          
            //23:51:21.759      023 – M.WEBBER            3       1:04.287            43,287
             new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 51, seconds: 21, milliseconds:759),
                           NomePiloto="023–M.WEBBER",
                           Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 4, milliseconds:287),
                           NumeroVolta=3,
                           VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 43, milliseconds:287) },
 
            //23:52:25.975      023 – M.WEBBER            4       1:04.216            43,335
            new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 52, seconds: 25, milliseconds:975),
                          NumeroVolta=4,
                          NomePiloto="023–M.WEBBER",
                          Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 4, milliseconds:216),
                          VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 43, milliseconds:335) },
           
            //23:52:01.796      011 – S.VETTEL            1       3:31.315            13,169
            new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 52, seconds: 1, milliseconds:796),
                          NomePiloto="011–S.VETTEL",
                          NumeroVolta=1,
                          Tempo=new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 31, milliseconds:315),
                          VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 13, milliseconds:169) },
           
            //23:53:39.660      011 – S.VETTEL            2       1:37.864            28,435
            new DadosLog{ Hora= new TimeSpan(days: 0, hours: 23, minutes: 53, seconds: 39, milliseconds:660),
                          NomePiloto="011–S.VETTEL",
                          Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 37, milliseconds:864),
                          NumeroVolta=2 ,
                          VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 28, milliseconds:435) },
          
            //23:54:57.757      011 – S.VETTEL            3       1:18.097            35,633
            new DadosLog{ Hora= new TimeSpan(days: 0, hours:23, minutes: 54, seconds:57 , milliseconds:757),
                          NumeroVolta=3,
                          NomePiloto="011–S.VETTEL",
                          Tempo=new TimeSpan(days: 0, hours: 0, minutes: 1, seconds:18 , milliseconds:097),
                          VelocidadeMedia=new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 35, milliseconds:633) },

            };

        }
    }
}
