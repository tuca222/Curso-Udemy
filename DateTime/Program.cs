using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime d1 = DateTime.Now; // Data do dia de hoje e horario local
            //DateTime d5 = DateTime.Today; // Data do dia de hoje as 00:00:00
            //DateTime d6 = DateTime.UtcNow; //Data do da de hoje e horario em UTC

            //DateTime d2 = new DateTime(2020, 12, 27); // Data: Ano/ Mes / Dia / => Hora: 00:00:00
            //DateTime d3 = new DateTime(2020, 12, 27, 18, 35, 30); // Data: Ano/ Mes/ Dia / hora/ Minutos/ Segundos
            //DateTime d4 = new DateTime(2020, 12, 27, 18, 35, 30, 500); // Data: Ano/ Mes/ Dia / hora/ Minutos/ Segundos/ Milisegundos

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);
            //Console.WriteLine(d5);
            //Console.WriteLine(d6);



            // Convertendo string para DateTime
            //DateTime d1 = DateTime.Parse("2019-12-31");
            //DateTime d2 = DateTime.Parse("2019-12-31 14:30:55");

            //DateTime d3 = DateTime.Parse("27/12/1999");
            //DateTime d4 = DateTime.Parse("27/12/1999 18:05:33");

            //// Convertendo com Parse Exact - Você formata o modelo
            //DateTime d5 = DateTime.ParseExact("1999-12-27", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //DateTime d6 = DateTime.ParseExact("27/12/1999 18:05:45", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);
            //Console.WriteLine(d5);
            //Console.WriteLine(d6);


            //// TimeSpan: Armazena uma duração

            //TimeSpan t1 = new TimeSpan(0, 1, 30); // 0 horas - 1 minuto - 30 segundos
            //TimeSpan t2 = new TimeSpan(900000000L); // 900 000 000 de nano segundos Convertido em tempo => 00:01:30
            //TimeSpan t3 = new TimeSpan(); // Duração 0:00:00
            //TimeSpan t4 = new TimeSpan(1, 4, 30, 50); // 1 dia 4hrs 40 minutos 50 segundos
            //TimeSpan t5 = new TimeSpan(1, 4, 30, 50, 300000); // 1 dia 4hrs 40 minutos 50 segundos 300000 milisegundos => 300000 milisegundos vira 5 minutos


            //Console.WriteLine(t1);
            //Console.WriteLine(t1.Ticks); // Nano segundos em t1
            //Console.WriteLine(t2);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);


            //Usando TimeSpan.From:

            //TimeSpan t1 = TimeSpan.FromDays(1.5);
            //TimeSpan t2 = TimeSpan.FromHours(1.5);
            //TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            //TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            //TimeSpan t5 = TimeSpan.FromMilliseconds(1);
            //TimeSpan t6 = TimeSpan.FromTicks(900000000L);




            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);
            //Console.WriteLine(t6);


            //DateTime d1 = new DateTime(1999, 12, 27);

            //DateTime d2 = new DateTime(2021, 12, 27);

            //TimeSpan t = d1.Subtract(d2);


            //Console.WriteLine(t);


            DateTime d1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(d1);






            Console.ReadLine();
        }
    }
}
