using Empresa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Acciones
{
    internal class Menu: IMenu
    {
        public void Menuprincipal()
        {
            
            Console.WriteLine("           <<<<< Bienvenido >>>>>       ");
            Console.WriteLine("              Menu de Opciones");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1: Calcular el Resumen de las ventas");
            Console.WriteLine("2: Calcular el Salario de los empleados");
            Console.WriteLine("3: Comparar los Salarios entre Hombres y Mujeres");
            Console.WriteLine("4: (extra) Evaluar la Cantidad de agua caida");
            Console.WriteLine("0 Finalizar");
            Console.WriteLine(" ");
            Console.Write("Seleccione la funcion deseada: ");
            /*int res = Convert.ToInt16(Console.ReadLine());
            switch (res)
            {
                case 1:
                    Contabilidad ventas = new Contabilidad();
                    ventas.generarconteo();
                    break;
                case 2:
                    Pago_Empleado recibo = new Pago_Empleado();
                    recibo.Iniciar();
                    break;
                case 3:
                    Detallarsalarios resultado = new Detallarsalarios();
                    resultado.Iniciar();
                    break;
                case 4:
                    Agua llovizna = new Agua();
                    llovizna.Evaluar();
                    break;
            }*/
        }
    }
}

