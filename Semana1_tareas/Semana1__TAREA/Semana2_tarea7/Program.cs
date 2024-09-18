using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_tarea7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado e = new Empleado(1111,"pedro",123213,3500);
            List<Empleado> lista = new List<Empleado>();
            lista.Add(e);

            Console.WriteLine(lista[0].codigo);
            Console.WriteLine(lista[0].nombre);
            Console.WriteLine(lista[0].celular);
            Console.WriteLine(lista[0].sueldo);
            Console.WriteLine(e.medidorSueldo());

            e.celular = 999888777;
            e.sueldo = e.sueldo + 200;

            Console.WriteLine("*************************");
            Console.WriteLine(lista[0].codigo);
            Console.WriteLine(lista[0].nombre);
            Console.WriteLine(lista[0].celular);
            Console.WriteLine(lista[0].sueldo);
            Console.WriteLine(e.medidorSueldo());
            Console.ReadKey();
        }
    }
}
