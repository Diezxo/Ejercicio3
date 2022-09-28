using Empresa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Acciones
{
    internal class Fin: IAcciones
    {

       public static void Iniciar()
        {
            Console.Clear();
            Console.WriteLine("All Done");
        }
    }
}
