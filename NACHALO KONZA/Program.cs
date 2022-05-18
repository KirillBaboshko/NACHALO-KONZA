using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NACHALO_KONZA
{
    class Program
    {
        static double def(double r)
        {
            return r * 2;
        }
        static void Main(string[] args)
        {
            //int x = 7;
            //int y;
            //WriteLine("");
            //y = Convert.ToInt16(ReadLine());
            //y = x * y;
            //Write(y);
          

            double i =  1.0/3;
            decimal j =(decimal) 8/3;
            WriteLine($"i={i} \n j={j}");
            WriteLine($"i*3={i*3} , j*3={j*3}");
            ReadKey();
            i=def(i);
            WriteLine($"i={i}");
        }

      
    }
}
