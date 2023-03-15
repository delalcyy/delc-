using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Sayiyi Giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for(int i = 0; i <= sayi; i++)
           
                if (i % 2 == 0)
                {
                    Console.WriteLine();
                    toplam += i;
                }
            Console.WriteLine("1 den {0} a kadar olan çift sayilarin toplami = {1}", sayi, toplam);
            Console.ReadKey();  
        }
    }
}
