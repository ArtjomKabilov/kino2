using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace povtor
{
    class Program
    {

        public static int Saali_suurus()
        {
            Console.WriteLine("Razmer Zala [1,2,3]");
            int a = int.Parse(Console.ReadLine());
            return a;
        }
        static int[,] saal = new int[,] { };
        static int kohad, read;
        public static void Saali_taitmine(int a)
        {
            Random rnd = new Random();
            if (a==1)
            {
                kohad = 15;
                read = 10;

            }
            else if (a==2)
            {
                kohad = 30;
                read = 20;
            }
            else
            {
                kohad = 40;
                read = 26;
            }
            saal = new int[read, kohad];

            for (int rida = 0; rida < read; rida++)
            {
                for (int koht = 0; koht < kohad; koht++)
                {
                    saal[rida, koht] = rnd.Next(0, 2);
                }
            }
            
        }
        public static void Saal_ekraanile()
        {
            Console.Write("     ");
            for (int koht = 0; koht < kohad; koht++)
            {
                if (koht.ToString().Length == 2)
                { Console.Write(" {0}", koht + 1); }
                else
                { Console.Write("  {0}", koht + 1); }
            }

            Console.WriteLine();
            for (int rida = 0; rida < read; rida++)
            {
                Console.Write("Rida " + (rida + 1).ToString() + ": ");
                for (int koht = 0; koht < kohad; koht++)
                {

                    Console.Write(saal[rida, koht] + "  ");
                }
                Console.WriteLine();
            }

        }
        static void Muuk()
        {
            Console.WriteLine("sisesta rida");
            int rida1 = int.Parse(Console.ReadLine());
            Console.WriteLine("mitu piletid:");
            int mitu = int.Parse(Console.ReadLine());
            int mitu_veel = mitu;
            int[] ost = new int[mitu];
            int p = (kohad-mitu) / 2;
            bool t = false;
            int k = 0;
                do
                {
                    if (saal[rida1, p] == 0)
                    {
                     ost[k] = p;
                     Console.WriteLine($"Koht {p} on vaba");
                        t = true;
                    }
                    else
                    {
                        Console.WriteLine($"Koht {p} on vaba");
                        t = false;
                        ost = new int[mitu];
                        k = 0;
                        p = (kohad - mitu) / 2;
                        break;
                    }
                    p = p + 1;
                    k++;
                } while (mitu != k);
            if (t==true)
            {
                Console.WriteLine("Sinu kohad on: ");
                foreach (var koh in ost)
                {
                    Console.WriteLine("{0}\n", koh);
                }
            }
            else
            {
                Console.WriteLine("Selles reas ei ole vabu kohti. Kas tahad teises reas otsida?");
            }

        }
        static void Main(string[] args)
        {
            int suurus = Saali_suurus();

            Saali_taitmine(suurus);
            while (true)
            {
                Saal_ekraanile();
                Muuk();
                
            }
        }
    }
}
