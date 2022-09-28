using Empresa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Acciones
{
    class Producto
    {
        private string? nombre;
        private float precio;
        public Producto(string? _nombre, float _precio)
        {
            nombre = _nombre;
            precio = _precio;
        }

        public float GetPrecio()
        {
            return precio;
        }

        public string? getNombre()
        {
            return nombre;
        }
    }
    class Calcular: IAcciones
    {
        float ventas_brutas = 0;
        float ventas_con_descuentos = 0;
        float ventas_totales = 0;
        const float impuesto = 0.18f;
       
        float descuento = 0;
        public void Detalle()
        {
            Console.Clear();
            Console.WriteLine("    ======       DETALLE       ======");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("El descuento de la venta fue: " + descuento);
            Console.WriteLine("Tus ventas brutas fueron: " + ventas_brutas);
            Console.WriteLine("Tus ventas generaron un impuesto del 18%");
            Console.WriteLine("Tus ventas finales fueron de: " + ventas_totales);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1 Recalcular / 2 Menu Principal / 0 Finalizar");
        }
        public void Iniciar()
        {
            Console.Clear();
            Console.WriteLine("Cuantos productos deseas Registrar");
            int cantidadproductos = Convert.ToInt32(Console.ReadLine());
            Producto[] ventas = new Producto[cantidadproductos];
            for (int i = 0; i < cantidadproductos; i++)
            {
                Console.WriteLine("Ingresa el nombre del producto");
                string? nombre = Console.ReadLine();
                Console.WriteLine("Ingresa su precio");
                float precio = (float)Convert.ToDouble(Console.ReadLine());
                ventas[i] = new Producto(nombre, precio);
                Console.WriteLine();
            }

            float valor_impuesto = ventas_brutas * impuesto;

            for (int i = 0; i < cantidadproductos; i++)
            {
                ventas_brutas += ventas[i].GetPrecio();
            }

            Console.WriteLine("se aplico algun descuento?");
            Console.WriteLine("1 Si / 0 No");
            int Respuesta = Convert.ToInt16(Console.ReadLine());
            if (Respuesta == 1)
            {
                Console.Clear();
                Console.WriteLine("De cuanto fue el descuento en porcentaje?");
                Console.WriteLine("Referencia: 10%=0.10");
                descuento = ventas_brutas * (float)Convert.ToDouble(Console.ReadLine());
                ventas_con_descuentos = ventas_brutas - descuento;
                ventas_totales = ventas_con_descuentos + ventas_con_descuentos * impuesto;
            }
            else if (Respuesta == 0)
            {
                descuento = 0;
                ventas_totales = ventas_brutas + ventas_brutas * impuesto;
            }
            Console.Clear();
            Console.WriteLine("1 Imprimir Detalle / 2 Menu Principal / 0 Finalizar");
            int r = Convert.ToInt16(Console.ReadLine());
            if (r == 1)
            {
               Detalle();
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
                        Fin.Iniciar();
                        break;

                }
            }
            if (r == 2)
            {
                Program.Main();
            }
            else if (r == 0)
            { }



        }

    }
}
