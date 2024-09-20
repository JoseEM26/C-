using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5] { 1, 2, 3, 4, 5 };

            foreach(int x in numeros)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("**********************************************");

            List<int> lista = new List<int>();

            foreach(int x in numeros)
            {
                lista.Add(x);
            }
            foreach (int x in lista)
            {
                Console.WriteLine(x);
            }


            Console.ReadKey();
             
        }
    }
}
