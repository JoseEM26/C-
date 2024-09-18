using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_tarea6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            paciente p = new paciente("pepe", "gonzales", 11, 1.3, 55);
            List<paciente> lista = new List<paciente>();
            lista.Add(p);

            Console.WriteLine(lista[0].nombre);
            Console.WriteLine(lista[0].apellido);
            Console.WriteLine(lista[0].edad);
            Console.WriteLine(lista[0].talla);
            Console.WriteLine(lista[0].peso);
            Console.WriteLine(p.MedidorEdad());

            p.edad = 22;

            Console.WriteLine("*************************");
            Console.WriteLine(lista[0].nombre);
            Console.WriteLine(lista[0].apellido);
            Console.WriteLine(lista[0].edad);
            Console.WriteLine(lista[0].talla);
            Console.WriteLine(lista[0].peso);
            Console.WriteLine(p.MedidorEdad());

            Console.ReadKey();
        }
    } 
    }

