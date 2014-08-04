using System.Collections.Generic;
using System.Linq;
using System.Text;

using Agile;

using Console = System.Console;

namespace ConsoleApplication7
{
    public class Monstruo
    {
        public string nombre = Faker.NameFaker.FirstName();
        public static int creados;

        public int vida;

        public Monstruo()
        {
            vida = Randomizer.GetIntBetween(100, 200);
            creados++;
        }
    }

   
    class Program
    {
        private static void QuitarMuertos(List<Monstruo> original)
        {
            List<Monstruo> temporal = new List<Monstruo>();

            int i = 0;
            while (i < original.Count)
            {
                if(original[i].vida <= 0)
                    temporal.Add(original[i]);

                i++;
            }

            i = 0;
            while (i < temporal.Count)
            {
                original.Remove(temporal[i]);
                i++;
            }

        }


        static void Main(string[] args)
        {
         
            List<Monstruo> monstruos = new List<Monstruo>();

            CrearMonstruos(monstruos);

            while (monstruos.Count > 1)
            {
                Console.WriteLine("-----------------------");   
                MostrarVida(monstruos);
                QuitarVida(monstruos);
                QuitarMuertos(monstruos);
            }

            if (monstruos.Count == 1)
                Console.WriteLine("Ha ganado " + monstruos[0].nombre);
            else
                Console.WriteLine("Han muerto todos!!!");
            

        }

        private static void CrearMonstruos(List<Monstruo> monstruos)
        {
            int cantidad = 10;
            int i = 0;
            while (i < cantidad)
            {
                monstruos.Add(new Monstruo());

                i++;
            }
            Console.WriteLine("He creado " + Monstruo.creados + " monstruos");
        }

        private static void QuitarVida(List<Monstruo> monstruos)
        {
            int i = 0;
            while (i < monstruos.Count)
            {
                int daño = Randomizer.GetIntBetween(10, 50);
                Console.WriteLine(monstruos[i].nombre + " recibe " + daño +" puntos de daño.");
                monstruos[i].vida -= daño;
                i++;
            }
    
        }

        private static void MostrarVida(List<Monstruo> monstruos)
        {
            int i;
            i = 0;
            while (i < monstruos.Count)
            {
                Console.WriteLine("Vida del monstruo " + monstruos[i].nombre + ": " + monstruos[i].vida);
                i++;
            }
        }
    }
}
