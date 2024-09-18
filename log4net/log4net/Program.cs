using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace log4net
{

    internal class Program
    {
        private static readonly ILog LOG = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {

            LOG.Info("bienvenidos a log4net");
            

                int numero = 10;
                int denominador = 0;

            try
            {

                if (numero == 10)
                {
                    throw new Exception("error Exception");
                }

            }catch(Exception e)
            {
                LOG.Error(e);
                LOG.Error(e.Message);
                Console.WriteLine(e.ToString());
               
            }

            Console.ReadKey();
        }
    }
}




//aca puedes encontrar los datos necesarios
//https://notepad.pw/KEB5J0c6HMLmf9Ks6IV9
