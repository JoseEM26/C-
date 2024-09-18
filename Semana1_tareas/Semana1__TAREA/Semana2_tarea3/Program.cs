using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_tarea3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edificio e = new Edificio(111, 342, 2, 4554.5);

            List<Edificio> lista = new List<Edificio>();
            lista.Add(e);

            Console.WriteLine(lista[0].codigo);
            Console.WriteLine(lista[0].departamento);
            Console.WriteLine(lista[0].cantidad);
            Console.WriteLine(lista[0].precio);
            Console.WriteLine(e.precioDolarEdificio());

            e.precio = e.precio * 1.20;

            Console.WriteLine("*************************");
            Console.WriteLine(lista[0].precio);
            Console.WriteLine(e.precioDolarEdificio());
            Console.ReadKey();
        }
    }
}
