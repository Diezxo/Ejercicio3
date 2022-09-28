
/*Por teclado se ingresa el valor hora de un empleado.Posteriormente se ingresa el nombre del empleado,
la antigüedad y la cantidad de horas trabajadas en el mes. Se pide calcular el importe a cobrar 
teniendo en cuenta que,al total que resulta de multiplicar el valor hora por la cantidad de horas trabajadas,
hay que sumarle la cantidad de años trabajados multiplicados por $30, y al total de todas 
esas operaciones restarle el 13% en concepto de descuentos. Imprimir el recibo correspondiente-
con el nombre, la antigüedad,el valor hora, el total a cobrar en bruto, 
el total de descuentos y el valor neto a cobrar.*/
using Empresa.Interfaces;
using System;
using Microsoft.Extensions.DependencyInjection;
using Empresa.Acciones;

namespace Empresa
{

    class Program
    {
       
        public static void Main()
        {
            /* IDetallarSalarios detallarsalario = new Detallarsalarios();
             detallarsalario.Iniciar();*/

            var services= new ServiceCollection();
              services.AddSingleton<IMenu, Menu>();
            
            var serviceProvider = services.BuildServiceProvider();
            var iniciador = serviceProvider.GetService<IMenu>();
             char? o;

            do { iniciador.Menuprincipal();

              o= Convert.ToChar(Console.ReadLine());
                switch (o) // Bucle para implementarle funciones a la Interface
                {
                    case '1':
                        services.AddScoped<IAcciones, Calcular>();
                        break;
                    case '2':
                        services.AddScoped<IAcciones, Pago_Empleado>();
                        break;
                    case '3':
                        services.AddScoped<IAcciones, Detallarsalarios>();
                        break;
                    case '4':
                        services.AddScoped<IAcciones, Agua>();
                        break;
                    default:
                        services.AddScoped<IAcciones, Fin>();
                        break;
                        
                }
                if (o != '1' && o != '2' && o != '3' && o != '4' && o!='0')
                {
                    Console.Clear();
                    Console.WriteLine("         ¡Ingrese una accion Valida!");
                }

            } while (o != '1' && o != '2' && o != '3' && o != '4' && o!='0');

             var serviceProvider2= services.BuildServiceProvider();
            var iniciador2 = serviceProvider2.GetService<IAcciones>();
            iniciador2.Iniciar();
            //services.AddScoped<IAcciones, Detallarsalarios>();          






        }
    }
    
}
