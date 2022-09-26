using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa;
namespace Empresa
{
    class Detallarsalarios : Funciones
    {
        int Mujeres = 0;
        int Hombres = 0;
        public void imprimirdetalle()
        {
            Console.Clear();
            Console.WriteLine("                 >>>>   Resultado   <<<<");
            Console.WriteLine("En la Empresa hay "+Mujeres+" Mujeres con sueldos arriba de 500 Dolares");
            Console.WriteLine("Hay " + Hombres + " Hombres ganando menos de 400 Dolares en la empresa");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("1 Recalcular / 2 Menu Principal / 0 Finalizar");

            int resp = Convert.ToInt16(Console.ReadLine());
            switch (resp)
            {
                case 1:
                    Iniciar();
                    break;
                case 2:
                    Program.Main();
                    break;
                case 0:
                    break;

            }
        }
        public void Iniciar()
        {
            Console.Clear();
            Console.WriteLine("Cuantos Empleados desea comparar?");
            int Respuesta = Convert.ToInt32(Console.ReadLine());
            Empleados[] e = new Empleados[Respuesta];
            for (int i = 0; i < Respuesta; i++)
            {   Console.Clear();
                Console.WriteLine("Empleado N/" + (1 + i));
                Console.WriteLine("---------------------");
                int id = (01 + i);
                Console.WriteLine("Ingrese el Nombre");
                var nombre = Console.ReadLine();
                Console.WriteLine("----------------");
                Console.WriteLine("Ingrese el Sexo");
                Console.WriteLine("1 Hombre / 2 Mujer");
                var genero = Console.ReadLine();
                if (genero == "2")
                {
                    genero = "Mujer";
                }
                else if (genero == "1")
                {
                    genero = "Hombre";
                }
                Console.WriteLine("-----------------");
                Console.WriteLine("Ingrese el Sueldo");
                var sueldo = Convert.ToInt32(Console.ReadLine());
                e[i] = new Empleados(id, nombre, genero, sueldo);
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
