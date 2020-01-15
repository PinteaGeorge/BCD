using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCD
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rep = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001" };
            int nr = 0;
            Console.Write("Introduceti un numar: ");
            nr = int.Parse(Console.ReadLine());
            bool neg = nr >= 0 ? false : true;
            nr *= neg ? -1 : 1;
            int k = 10;
            int nn = 9;
            int revn = nr % 10;
            while (nr / k > 0)
            {
                revn = revn * 10 + (nr / k) % 10;
                nn = nn * 10 + 9;
                k *= 10;
            }
            nr = neg ? nn - revn : revn;
            Console.Write((neg ? rep[9] : rep[0]) + " ");
            while (nr > 0)
            {
                Console.Write(rep[nr % 10] + " ");
                nr /= 10;
            }
            Console.ReadLine();
        }
    }
}