using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarterAndHalfDiamond_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            QuarterDiamond(5, '*');
            HalfDiamond(5, '*');
            Console.ReadLine();
        }
        static void QuarterDiamond(int length,char chr)
        {
            Console.WriteLine(string.Format("This is a quarter diamond with max length {0}",length));
            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine(new string(chr, i));
            }
            Console.WriteLine("end of quarter diamond");
            
        }
        static void HalfDiamond(int length, char chr)
        {
            Console.WriteLine(string.Format("This is a half diamond with max length {0}", length));
            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine(new string(chr, i));
            }
            for (int i = length-1; i >= 1; i--)
            {
                Console.WriteLine(new string(chr, i));
            }
            Console.WriteLine("end of half diamond");
            
        }
    }
}
