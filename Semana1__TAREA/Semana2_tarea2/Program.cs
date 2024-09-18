using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora c = new Computadora(111, "ASUS", "negro", 111111);

            List<Computadora> lista = new List<Computadora>();
            lista.Add(c);

            Console.WriteLine(lista[0].codigo);
            Console.WriteLine(lista[0].marca);
            Console.WriteLine(lista[0].color);
            Console.WriteLine(lista[0].precioDolares);
            Console.WriteLine(c.PrecioSoles());
            Console.WriteLine(c.precioEurps());

            c.precioDolares = c.precioDolares * 0.90;

            Console.WriteLine("*************************");
            Console.WriteLine(lista[0].precioDolares);
            Console.WriteLine(c.PrecioSoles());
            Console.WriteLine(c.precioEurps()); 
            Console.ReadKey();
        }
    }
}
