using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_tarea5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            video v = new video(111, "DeadPool", 1.2, 40, 12.5);
            List<video> lista = new List<video>();
            lista.Add(v);

            Console.WriteLine(lista[0].codigo);
            Console.WriteLine(lista[0].nombre);
            Console.WriteLine(lista[0].duracion);
            Console.WriteLine(lista[0].precio);
            Console.WriteLine(v.precioDolar());

            v.precio = v.precio * 1.55;

            Console.WriteLine("*************************");
            Console.WriteLine(lista[0].codigo);
            Console.WriteLine(lista[0].nombre);
            Console.WriteLine(lista[0].duracion);
            Console.WriteLine(lista[0].precio);
            Console.WriteLine(v.precioDolar());
            Console.ReadKey();
        }
    }
}
