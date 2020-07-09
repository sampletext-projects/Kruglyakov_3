using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruglyakov_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Z: ");
            double z = double.Parse(Console.ReadLine().Replace(".", ","));

            Console.Write("X: ");
            double x = double.Parse(Console.ReadLine().Replace(".", ","));

            Console.Write("A: ");
            double a = double.Parse(Console.ReadLine().Replace(".", ","));

            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            double sinz = Math.Sin(z);
            double cosz = Math.Cos(z);

            double sinz_n = sinz;
            double cosz_n = cosz;
            double fact = 2;
            double x_n = x;

            double w = -2.48;
            for (int i = 1; i <= n; i++)
            {
                w += (sinz_n - 2 * i * a) / (cosz_n + Math.Sqrt(fact * x_n));
                sinz_n *= sinz;
                cosz_n *= cosz;
                fact *= i + 2;
                x_n *= x * x;
            }

            Console.WriteLine("W: {0}", w);
            Console.ReadKey();
        }
    }
}