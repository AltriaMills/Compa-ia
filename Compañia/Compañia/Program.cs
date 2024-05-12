using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerocifrado
{
    internal class Numerocifrado
    {
        static void Main(string[] args)
        {
            Numerocifrado obj = new Numerocifrado();
            int num, dnum, c, d;

            Console.WriteLine("Escriba un numero entero de 4 digitos");
            num = Convert.ToInt32(Console.ReadLine());
            c= obj.cifrarNumero(num);
            Console.WriteLine("Escriba el numero cifrado de 4 digitos");
            dnum = Convert.ToInt32(Console.ReadLine());
            d = obj.decifrarNumero(dnum);
            Console.ReadKey();

        }
        public int cifrarNumero(int num)
        {
            int d1, d2, d3, d4;

            if (num <= 9999)
            {
                d1 = num % 10;
                num = num / 10;
                d2 = num % 10;
                num = num / 10;
                d3 = num % 10;
                num = num / 10;
                d4 = num;

                d1 = ((d1 + 7) % 10); // * 100;
                d2 = ((d2 + 7) % 10); // * 1000;
                d3 = ((d3 + 7) % 10); // * 1;
                d4 = ((d4 + 7) % 10); // * 10;

                Console.WriteLine("El numero cifrado es: " + d2 + d1 + d4 + d3);
            }
            else
            {
                Console.WriteLine("No es un numero de cuatro digitos");
            }
            return num;

        }
        public int decifrarNumero(int dnum)
        {
            int g1, g2, g3, g4;

            if (dnum <= 9999)
            {
                g1 = dnum % 10;
                dnum = dnum / 10;
                g2 = dnum % 10;
                dnum = dnum / 10;
                g3 = dnum % 10;
                dnum = dnum / 10;
                g4 = dnum;

                g1 = ((g1 + 3)); // * 100;
                g2 = ((g2 + 3)-10); // * 1000;
                g3 = ((g3 + 3)); // * 1;
                g4 = ((g4 + 3)); // * 10;

                Console.WriteLine("El numero decifrado es: " + g2 + g1 + g4 + g3);
            }
            else
            {
                Console.WriteLine("No es un numero de cuatro digitos");
            }
            return dnum;
        }

    }

}




