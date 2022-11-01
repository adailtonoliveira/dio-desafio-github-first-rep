using System;
//using System.IO;
//using System.Collections.Generic;
//using Desafio1.Modelos;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, raio, volume;
            pi = 3.14159;
            //TODO: Complete os espaços em branco com uma possível solução para o desafio     
            raio = double.Parse(Console.ReadLine());
            volume = pi * (4/3.0) * Math.Pow(raio, 3);

            Console.WriteLine($"VOLUME = " + volume.ToString("0.000"));
        }
    
    }

}




/*

            DateTime dtEvento = Convert.ToDateTime("2022-11-25 00:00:00");
            int count = 0, ch = 0;
            // "2023-12-31 00:00:00"
            Parametro param1 = new Parametro()
            {
                DtIni = Convert.ToDateTime("2022-10-26 00:00:00"),
                DtFim = Convert.ToDateTime(null),
                CHMaxMensal = 168
            };

            Parametro param2 = new Parametro()
            {
                DtIni = Convert.ToDateTime("2022-08-01 00:00:00"),
                DtFim = Convert.ToDateTime("2022-10-25 00:00:00"),
                CHMaxMensal = 200
            };

            Parametro param3 = new Parametro()
            {
                DtIni = Convert.ToDateTime("2022-05-01 00:00:00"),
                DtFim = Convert.ToDateTime("2022-07-31 00:00:00"),
                CHMaxMensal = 180
            };

            List<Parametro> list = new List<Parametro>();
            list.Add(param1);
            list.Add(param2);
            list.Add(param3);

            foreach (var item in list)
            {
                if (dtEvento >= item.DtIni)
                {
                    Console.WriteLine("O item {0} tem uma carga horária mensal de {1}", count+1, item.CHMaxMensal);
                    ch = item.CHMaxMensal;
                    break;
                } else
                {
                    count++;
                    ch = item.CHMaxMensal;
                }

            }
            Console.WriteLine("Final: O item {0} tem uma carga horária mensal de {1}", count+1, ch); 

*/



//        }




//        public void Desafio_1()
//        {
//            int n = int.Parse(Console.ReadLine());
//            int p = 1, s = 0;
//            while (n > 0)
//            {
//                int l = n % 10;

//                // TODO: Crie as outras condições necessárias para a resolução do desafio:
//                p *= l;
//                s += l;
//                n /= 10;
//            }

//            Console.WriteLine(p - s);
//        }
//    }
//}
/*
 * DESAFIO 2
static void Main(string[] args)
{
    int qt = int.Parse(Console.ReadLine());
    string[] v = new string[2];

    // TODO: Crie as outras condições necessárias para a resolução do desafio:
    for (int i = 0; i < qt; ++i)
    {
        v = Console.ReadLine().Split(" ");

        string a = v[0];
        string b = v[1];

        if (b.Length > a.Length)
            Console.WriteLine("nao encaixa");
        else if (a.EndsWith(b))
            Console.WriteLine("encaixa");
        else
            Console.WriteLine("nao encaixa");

    }
}
 * DESAFIO 3
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                // TODO: Crie as outras condições necessárias para a resolução do desafio:
                if (n % i == 0)
                {
                    count++;
                }
                if (count > i)
                {
                    Console.WriteLine(false);
                }
            }
            Console.WriteLine(count == 3);
        }
*/