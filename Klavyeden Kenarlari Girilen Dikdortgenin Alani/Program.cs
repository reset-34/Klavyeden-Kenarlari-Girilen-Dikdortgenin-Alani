using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_Kenarlari_Girilen_Dikdortgenin_Alani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kisaKenar, uzunKenar, alan;

            Console.WriteLine("dikdörtgenin Kısa Kenarını Girin");
            kisaKenar = Int32.Parse(Console.ReadLine());

            Console.WriteLine("dikdörtgenin Uzun Kenarını Girin");
           uzunKenar = Int32.Parse(Console.ReadLine());

            alan = kisaKenar * uzunKenar;

            Console.WriteLine("Dikdörtgenin Alanı = " + alan);
            Console.ReadLine();
        }
    }
}
