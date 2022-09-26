
/*Por teclado se ingresa el valor hora de un empleado.Posteriormente se ingresa el nombre del empleado,
la antigüedad y la cantidad de horas trabajadas en el mes. Se pide calcular el importe a cobrar 
teniendo en cuenta que,al total que resulta de multiplicar el valor hora por la cantidad de horas trabajadas,
hay que sumarle la cantidad de años trabajados multiplicados por $30, y al total de todas 
esas operaciones restarle el 13% en concepto de descuentos. Imprimir el recibo correspondiente-
con el nombre, la antigüedad,el valor hora, el total a cobrar en bruto, 
el total de descuentos y el valor neto a cobrar.*/
using Empresa;
using System;

namespace Empresa
{

    class Program : Funciones
    {
        private Funciones? funciones;

        public Program() { }

        public void Getfunciones(Funciones? _funciones)
        {
            funciones = _funciones;
        }
        public void Iniciar()
        {
            if(funciones != null)
            {
                funciones.Iniciar();
            }
        }
       /* public void Menuprincipal()
        {
            Console.Clear();
            Console.WriteLine("           <<<<< Bienvenido >>>>>       ");
            Console.WriteLine("              Menu de Opciones");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1: Calcular el Resumen de las ventas");
            Console.WriteLine("2: Calcular el Salario de los empleados");
            Console.WriteLine("3: Comparar los Salarios entre Hombres y Mujeres");
            Console.WriteLine("4: (extra) Evaluar la Cantidad de agua caida");
            Console.WriteLine("0 Finalizar");
            int res = Convert.ToInt16(Console.ReadLine());
            switch (res)
            {
                case 1:
                    Contabilidad ventas = new Contabilidad();
                    ventas.generarconteo();
                    break;
                case 2:
                    Pago_Empleado recibo = new Pago_Empleado();
                    recibo.Generarrecibo();
                    break;
                case 3:
                    Detallarsalarios resultado = new Detallarsalarios();
                    resultado.comparar_sueldos();
                    break;
                case 4:
                    Agua llovizna = new Agua();
                    llovizna.Evaluar();
                    break;
            }
        }*/
        public static void Main()
        {
            Funciones detallarsalario = new Detallarsalarios();
            Program iniciador = new Program();
            iniciador.Getfunciones(detallarsalario);
            iniciador.Iniciar();
            //iniciador.Menuprincipal();
        }
    }
    
}

