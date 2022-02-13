using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NE DODELANO ULESANNE 3
            //Console.WriteLine("Tere! Palun sisestage 4 arvu!");
            //Console.WriteLine("Palun esimene");
            //int count = 1;
            //int k = Convert.ToInt32(Console.ReadLine());
            //int i = int.Parse(Console.ReadLine());
            //while (count <= 4)
            //{
            //if (i == k)
            //{
                
            //}
            //else
            //{
            //    count++;
            //    if (count == 5)
            //    {
            //        Console.WriteLine("Aitäh! Suurim arv on: ");
            //        break;
            //    }
            //    Console.WriteLine("Palun veel uks arv " + k + "! Arv № " + count + ":");
            //    k = Convert.ToInt32(Console.ReadLine());
            //}
            //}

            ////ULESANNE 1
            //Console.WriteLine("Tere! Kas soovite elevanti osta?");
            //int a = 0;//nuzno postavit luboe zna4enie, neobyazatelno 0
            //do
            //{
            //    Console.Write("Palun osta elevanti! ");//1,2,3,4,5
            //    try
            //    {
            //        string vastus = Console.ReadLine();
            //        if (vastus.ToLower() == "elevant")
            //        {
            //            a = 1;
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //    }

            //} while (a != 1);//nepodhodyashie usloviya
            //Console.WriteLine("Oled tubli! Aitäh ostu eest!");

            ////ULESANNE 4
            //int j, i, n;
            //Console.Write("See on korrutis tabel 10x10");
            //n = 10;
            //Console.Write("Korrutis tabel \n", n);
            //for (i = 1; i <= 10; i++)
            //{
            //    for (j = 1; j <= n; j++)
            //    {
            //        if (j <= n - 1)
            //            Console.Write("{2}, ", j, i, i * j);
            //        else
            //            Console.Write("{2}", j, i, i * j);
            //    }
            //    Console.Write("\n");
            //}
            ////ULESANNE 2
            //Random rand = new Random();
            //int i = rand.Next(100);
            //int count = 1;
            //Console.WriteLine("Arvuti mõeldis välja arv 0-100. Sul on 5 katset!");
            //Console.WriteLine("Esimine katse:");
            //int k = Convert.ToInt32(Console.ReadLine());
            //while (count <= 5)
            //{
            //    if (i == k)
            //    {
            //        Console.WriteLine("Jah! Oled õige! See on " + k + "!");
            //        break;
            //    }
            //    else
            //    {
            //        count++;
            //        if (count == 6)
            //        {
            //            Console.WriteLine("Kahjuks see ei ole õige vastus. Õige vastus on " + i + "!");
            //            break;
            //        }
            //        Console.WriteLine("Ei, see ei ole " + k + "! Katse № " + count + ":");
            //        k = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            Console.ReadKey();


        }
    }
}
