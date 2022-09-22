using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion;
namespace Aplicacion
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
    class Contabilidad
    {
        public void generarconteo()
        {
            Console.WriteLine("Cuantos productos deseas agregar a la lista?");
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

            float ventas_brutas = 0;
            float ventas_con_descuentos = 0;
            float ventas_totales = 0;
            const float impuesto = 0.18f;
            float valor_impuesto = ventas_brutas * impuesto;
            float descuento = 0;

            for (int i = 0; i < cantidadproductos; i++)
            {
                ventas_brutas += ventas[i].GetPrecio();
            }

            Console.WriteLine("se aplico algun descuento?");

            string? Respuesta = Console.ReadLine();
            if (Respuesta == "si")
            {
                Console.WriteLine("De cuanto fue el descuento en porcentaje?");
                Console.WriteLine("Referencia: 10%=0.10");
                descuento = ventas_brutas * (float)Convert.ToDouble(Console.ReadLine());
                ventas_con_descuentos = ventas_brutas - (descuento);
                ventas_totales = ventas_con_descuentos + (ventas_con_descuentos * impuesto);
                Console.Clear();
            }
            else if (Respuesta == "no")
            {
                descuento = 0;
                ventas_totales = ventas_brutas + (ventas_brutas * impuesto);
            }
            Console.WriteLine("1 Imprimir Detalle / 2 Menu Principal / 0 Finalizar");
            int r = Convert.ToInt16(Console.ReadLine());
            if (r == 1)
            {
                Console.Clear();
                Console.WriteLine("  ======       DETALLE       ======");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("El descuento de la venta fue: " + descuento);
                Console.WriteLine("Tus ventas brutas fueron: " + ventas_brutas);
                Console.WriteLine("Tus ventas generaron un impuesto del 18%");
                Console.WriteLine("Tus ventas finales fueron de: " + ventas_totales);
                Console.WriteLine("1 Finalizar / 0 Menu Principal");
            }
            else if (r == 2)
            {
                //Menu();
            }


        }

    }
}
