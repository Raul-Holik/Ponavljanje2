using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje4.D._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica;
            Console.WriteLine("Upišite rečenicu sa razmacima");
            recenica= Console.ReadLine();

            Console.WriteLine(recenica.Replace(" ","_"));
            Console.ReadKey();
        }
    }
}
