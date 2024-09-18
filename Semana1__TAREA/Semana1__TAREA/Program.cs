using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Semana1__TAREA
{
    internal class Program
    {
        static void Main(string[] args)
        {
             celular c = new celular(111,"jose",100,50);

            List<celular> lista = new List<celular>();
            lista.Add(c);

            Console.WriteLine("numero : " + lista[0].numero);
            Console.WriteLine("Usuario : " + lista[0].usuario);
            Console.WriteLine("P unidad : " + c.p_unidad);
            Console.WriteLine("S consumidos : " + c.s_consumidos);
            Console.WriteLine(c.CostoConsumo());
            Console.WriteLine(c.impuesto());
            Console.WriteLine(c.impuestoTotal());

            c.s_consumidos = c.s_consumidos + 20;
            c.p_unidad = c.p_unidad * 0.95;

            Console.WriteLine("*******************************");
            Console.WriteLine("numero : " + lista[0].numero);
            Console.WriteLine("Usuario : " + lista[0].usuario);
            Console.WriteLine("P unidad : " + c.p_unidad);
            Console.WriteLine("S consumidos : " + c.s_consumidos);
            Console.WriteLine(c.CostoConsumo());
            Console.WriteLine(c.impuesto());
            Console.WriteLine(c.impuestoTotal());
            Console.ReadKey();
        }
    }
}
