using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa;
namespace Empresa
{
    class Detallarsalarios
    {
        int Mujeres = 0;
        int Hombres = 0;
        public void imprimirdetalle()
        {
            Console.WriteLine("Hay " + Mujeres + " Mujeres ganando mas de 500 dolares en la empresa");
            Console.WriteLine("Hay " + Hombres + " Hombres ganando menos de 400 dolares en la empresa");
        }
        public void Registrar()
        {
            Console.Write("Cuantos Empleados desea registrar?");
            int Respuesta = Convert.ToInt32(Console.ReadLine());
            Empleados[] e = new Empleados[Respuesta];
            for (int i = 0; i < Respuesta; i++)
            {
                Console.WriteLine("Empleado N/" + (1 + i));
                Console.WriteLine("---------------------");
                int id = (01 + i);
                Console.WriteLine("Ingrese el Nombre");
                var nombre = Console.ReadLine();
                Console.WriteLine("Es Hombre?");
                var genero = Console.ReadLine();
                if (genero == "no")
                {
                    genero = "Mujer";
                }
                else if (genero == "si")
                {
                    genero = "Hombre";
                }
                Console.WriteLine("Ingrese el Sueldo");
                var sueldo = Convert.ToInt32(Console.ReadLine());
                e[i] = new Empleados(id, nombre, genero, sueldo);
                Console.WriteLine("                                    ");
                //e[i].mostrar();
            }

            for (int i = 0; i < Respuesta; i++)
            {
                if (e[i].getSueldo() >= 500 && e[i].getGenero() == "Mujer")
                {
                    Mujeres++;

                }

                if (e[i].getSueldo() <= 400 && e[i].getGenero() == "Hombre")
                {
                    Hombres++;

                }

              
            }
             imprimirdetalle();
        }
    }
}
