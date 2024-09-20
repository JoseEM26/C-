using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana2_practicasExamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cerveza c = new cerveza(111,324,"Pilsen" );
            Console.WriteLine(c.id);
            Console.WriteLine(c.marca);
            Console.WriteLine(c.nombre);
            Console.ReadKey();
        }
    }
}
