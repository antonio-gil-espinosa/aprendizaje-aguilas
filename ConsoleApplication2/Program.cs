using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (uint i = 1; i < 100; i++)
            {

                Console.WriteLine(i + ":" + (Mates.EsPrimo(i)));
            }
            Console.WriteLine(Mates.EsPrimo(1));
            Console.WriteLine(Mates.Potencia(2, 0));

            Console.WriteLine(Mates.Bisiesto(300));


            Console.WriteLine(Mates.Bisiesto(399)); Console.WriteLine(Mates.Bisiesto(400)); Console.WriteLine(Mates.Bisiesto(100));
            Console.WriteLine(Mates.Bisiesto(4));

        }
    }
    class Mates
    {
        public static decimal Potencia(decimal x, decimal y)
        {
            //return Math.Pow(x, y);

            decimal resultado = 1;

            if (y > 0)
                for (int i = 1; i <= y; i++)
                {
                    resultado = resultado * x;

                }

            else if (y < 0)
                for (int i = 1; i <= -1 * y; i++)
                {
                    resultado = resultado / x;

                }

            return resultado;
        }

        public static decimal Media(params decimal[] asd)
        {
            //return asd.Average();
            decimal resultado = 0;
            for (int i = 0; i < asd.Count(); i++)
            {
                resultado = resultado + asd[i];
            }
            resultado = resultado / asd.Count();
            return resultado;

        }

        public static decimal Mayor(params decimal[] asd2)
        {
            //asd2.Max();
            decimal resultado = decimal.MinValue;
            for (int i = 0; i < asd2.Count(); i++)
            {
                if (resultado < asd2[i])
                    resultado = asd2[i];
            }
            return resultado;
        }


        public static decimal Menor(params decimal[] asd2)
        {
            //asd2.Max();
            decimal resultado = decimal.MaxValue;
            for (int i = 0; i < asd2.Count(); i++)
            {
                if (resultado > asd2[i])
                    resultado = asd2[i];
            }
            return resultado;
        }

        public static decimal Diferencia(params decimal[] asdasd)
        {
            decimal ret = Mayor(asdasd) - Menor(asdasd);
            return ret;
        }

        public static uint Fibonnaci(uint x)
        {

            if (x == 0)
                return 0;
            else if (x == 1)
                return 1;
            else
                return Fibonnaci(x - 1) + Fibonnaci(x - 2);

        }
        public static bool EsPrimo(uint x)
        {
            if (x == 1)
                return false;
            for (int i = 2; i < x; i++)
            {
                if (EsEntero((decimal)x / i))
                    return false;
            }
            return true;
        }

        public static bool EsEntero(decimal ads)
        {
            int capado = (int)ads;
            return ads == capado;

        }


        public static bool Bisiesto(int x)
        { 
            /* return (i%400 == 0 || i%100 != 0) && i%4 == 0); */
            if (x % 400 == 0)
                return true;
            if (x % 100 == 0)
                return false;
            if (x % 4 == 0)
                return true;

            return false;


        }
    }





}
