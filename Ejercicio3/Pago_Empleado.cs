using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    class Pago_Empleado
    {
        public float valor_hora { get; set; }
        public string? nombre { get; set; }
        public float antiguedad_años { get; set; }
        public float horas_mes { get; set; }
        public float importe_cobrarbruto { get; set; }
        public float descuento { get; set; }
        public float importe_total { get; set; }
        public void Getrecibo()
        {

            Console.WriteLine(" RECIBO");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Nombre del Empleado: " + nombre);
            Console.WriteLine("Tiempo laborando: " + antiguedad_años + " Años");
            Console.WriteLine("Valor Monetario: " + valor_hora + " dolares por hora");
            Console.WriteLine("Salario del Mes: " + importe_cobrarbruto + " dolares");
            Console.WriteLine("Total de Descuentos aplicados: " + descuento);
            Console.WriteLine("Salario neto del Mes: " + importe_total + " dolares");
        }
           public void Generarrecibo()
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("Cuanto es el valor por hora que devenga el empleado");
                    valor_hora = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Cual es el nombre del empleado?");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Cuantos años lleva en la empresa");
                    antiguedad_años = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Cuantas horas trabajo en el mes?");
                    horas_mes = (float)Convert.ToDouble(Console.ReadLine());

                }
                float importe_subtotal = valor_hora * horas_mes;
                float liquidacion = antiguedad_años * 30;
                importe_cobrarbruto = importe_subtotal + liquidacion;
                const float cons = 0.13F;
                descuento = importe_cobrarbruto * cons;
                importe_total = importe_cobrarbruto - descuento;
                Console.Clear();
                Console.WriteLine("Presione: 1 Imprimir el Recibo / 0 Regresar al menu anterior");
                int Res = Convert.ToInt32(Console.ReadLine());
                if (Res == 1)
                {
                    Getrecibo();
                }
            
        }
    }
}


    

