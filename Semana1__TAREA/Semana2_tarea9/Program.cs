using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_tarea9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pelota e = new pelota("walon",10,222,10.2,100);
            List<pelota> lista = new List<pelota>();
            lista.Add(e);

            Console.WriteLine(lista[0].marca);
            Console.WriteLine(lista[0].peso);
            Console.WriteLine(lista[0].presion);
            Console.WriteLine(lista[0].diametro);
            Console.WriteLine(lista[0].precio);
            Console.WriteLine(e.radio());
            Console.WriteLine(e.volumen());
            Console.WriteLine(e.descuento());
            Console.WriteLine(e.importe());

            e.precio = e.precio * 0.75;
            e.diametro = e.diametro + 1;

            Console.WriteLine("*************************");
            Console.WriteLine(lista[0].marca);
            Console.WriteLine(lista[0].peso);
            Console.WriteLine(lista[0].presion);
            Console.WriteLine(lista[0].diametro);
            Console.WriteLine(lista[0].precio);
            Console.WriteLine(e.radio());
            Console.WriteLine(e.volumen());
            Console.WriteLine(e.descuento());
            Console.WriteLine(e.importe());
            Console.ReadKey();
        }
    }
}
