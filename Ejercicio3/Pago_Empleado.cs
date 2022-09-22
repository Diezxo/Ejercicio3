using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Pago_Empleado: Empleados
    {
        public Pago_Empleado(){}
        /*public void Empleados(int _id, string? _genero, int _sueldo, float _valor_hora, string? _nombre, float _antiguedad_años, float _horas_mes, float _importe_cobrarbruto, float _descuento, float _importe_total)
        {
            id = _id;
            genero = _genero;
            sueldo = _sueldo;
            valor_hora = _valor_hora;
            nombre = nombre;
            antiguedad_años = _antiguedad_años;
            horas_mes = _horas_mes;
            importe_cobrarbruto = _importe_cobrarbruto;
            descuento = _descuento;
            importe_total = _importe_total;
        }*/
        public void Getrecibo()
        {
            Console.Clear();
            Console.WriteLine("         =======       RECIBO       =======");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Nombre del Empleado: " + nombre);
            Console.WriteLine("Tiempo laborando: " + antiguedad_años + " Años");
            Console.WriteLine("Valor Monetario: " + valor_hora + " dolares por hora");
            Console.WriteLine("Salario del Mes: " + importe_cobrarbruto + " dolares");
            Console.WriteLine("Total de Descuentos aplicados: " + descuento);
            Console.WriteLine("Salario neto del Mes: " + importe_total + " dolares");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("1 Recalcular / 2 Menu Principal / 0 Finalizar");
            int resp = Convert.ToInt16(Console.ReadLine());
            switch (resp)
            {
                case 1:
                    Generarrecibo();
                    break;
                case 2:
                    Program.Main();
                    break;
                case 0:
                    Console.Clear();
                    break;

            }
        }
           public void Generarrecibo()
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.Clear();
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
                Console.WriteLine("Presione: 1 Imprimir el Recibo / 2 Menu Principal / 0 Finalizar");
                int Res = Convert.ToInt32(Console.ReadLine());
                if (Res == 1)
                {
                 Getrecibo();
                }
                else if(Res == 2)
                {
                 Program.Main();
                }  
            
        }
    }
}


    

