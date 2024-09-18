using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_tarea8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            asesor e = new asesor(1111,"ana",100,2330);
            List<asesor> lista = new List<asesor>();
            lista.Add(e);

            Console.WriteLine(lista[0].codigo);
            Console.WriteLine(lista[0].nombre);
            Console.WriteLine(lista[0].horas);
            Console.WriteLine(lista[0].tarifa);
            Console.WriteLine(e.sueldoBruto());
            Console.WriteLine(e.Descuento());
            Console.WriteLine(e.SueldoNeto());

            e.horas = e.horas+10;
            e.tarifa = e.tarifa * 0.85;

            Console.WriteLine("*************************");
            Console.WriteLine(lista[0].codigo);
            Console.WriteLine(lista[0].nombre);
            Console.WriteLine(lista[0].horas);
            Console.WriteLine(lista[0].tarifa);
            Console.WriteLine(e.sueldoBruto());
            Console.WriteLine(e.Descuento());
            Console.WriteLine(e.SueldoNeto());
            Console.ReadKey();
        }
    }
}
