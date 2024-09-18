using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_tarea4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obreros o = new Obreros(1000, "pepe", 12, 124);
            List<Obreros> lista = new List<Obreros>();
            lista.Add(o);

            Console.WriteLine(lista[0].codigo);
            Console.WriteLine(lista[0].nombre);
            Console.WriteLine(lista[0].horas);
            Console.WriteLine(lista[0].tarifas);
            Console.WriteLine(o.sueldoBruto());
            Console.WriteLine(o.DescuentoAFP());
            Console.WriteLine(o.DescuentoEPS());
            Console.WriteLine(o.sueldoNeto());


            o.horas = o.horas+8;
            o.tarifas = o.tarifas * 8.5;

            Console.WriteLine("*************************");
            Console.WriteLine(lista[0].codigo);
            Console.WriteLine(lista[0].nombre);
            Console.WriteLine(lista[0].horas);
            Console.WriteLine(lista[0].tarifas);
            Console.WriteLine(o.sueldoBruto());
            Console.WriteLine(o.DescuentoAFP());
            Console.WriteLine(o.DescuentoEPS());
            Console.WriteLine(o.sueldoNeto());
            Console.ReadKey();
        }
    }
}
