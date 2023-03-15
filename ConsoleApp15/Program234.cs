using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int yazilacakrakam;
            Console.Write("Girilecek sayiyi yaziniz: ");
            sayi= Convert.ToInt32(Console.ReadLine());  
            while(sayi > 10)
            {
                yazilacakrakam = sayi % 10;
                Console.Write(yazilacakrakam);
                sayi /= 10;
            }
            Console.WriteLine(sayi);
            Console.ReadKey();

        }
    }
}
