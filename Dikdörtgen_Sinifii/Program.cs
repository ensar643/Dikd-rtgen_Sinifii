using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dikdörtgen_Sinifii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen(3, 4);
            Console.WriteLine("Dikdörtgenin alanı: {0}", dikdortgen.AlanHesapla());
            Console.WriteLine("Dikdörtgenin çevresi: {0}", dikdortgen.CevreHesapla());
            Console.ReadLine();

        }
    }
    class Dikdortgen
    {
        private int a, b;
        public Dikdortgen(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int AlanHesapla()
        {
            return a * b;
        }
        public int CevreHesapla()
        {
            return 2 * (a + b);
        }
    }
}
