using Empresa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Acciones
{
    class Agua: IAcciones
    {
        public int gotas_dia { get; set; }
        public int gotas_promedio { get; set; }
        public int gotas_menor { get; set; }
        public int gotas_mayor { get; set; }
        public int dias_evaluados { get; set; }

        public void Detalle()
        {
            Console.Clear();
            Console.WriteLine("              ===========   RESULTADOS   ==========                    ");
            Console.WriteLine("La Mayor cantidad de Agua registrada en un dia fue de: " + gotas_mayor + " mL");
            Console.WriteLine("La menor cantidad de Agua registradas en un dia fue de: " + gotas_menor + " mL");
            Console.WriteLine("El Promedio entre todos los dias evaluados es " + gotas_promedio + " mL de agua");
            Console.WriteLine("-------------------------------------");
        }
        public void Iniciar()
        {
            Console.Clear();
            Console.WriteLine("Cuantos dias deseas evaluar");
            var dias_evaluados = Convert.ToInt16(Console.ReadLine());
            Agua llovizna = new Agua();

            for (int i = 1; i <= dias_evaluados; i++)
            {
                Console.Clear();
                Console.WriteLine("Dia: " + i);
                Console.WriteLine("-----------");
                Console.WriteLine("Escribe Cuantos mL de agua registraste");
                var gotas_dia = Convert.ToInt32(Console.ReadLine());

                if (i == 1 || gotas_dia > llovizna.gotas_mayor)
                    llovizna.gotas_mayor = gotas_dia;
                if (i == 1 || gotas_dia < llovizna.gotas_menor)
                    llovizna.gotas_menor = gotas_dia;

                llovizna.gotas_promedio += gotas_dia;

            }
            if (dias_evaluados != 0)
            {
                llovizna.gotas_promedio /= dias_evaluados;
            }
            Console.Clear();
            Console.WriteLine("1 Imprimir Resultados / 2 Menu Principal / 0 Finalizar");
            int a = Convert.ToInt16(Console.ReadLine());
            if (a == 1)
            {
                llovizna.Detalle();

                Console.WriteLine("1 Volver a Evaluar / 2 Menu Principal / 0 Finalizar");
                int b = Convert.ToInt16(Console.ReadLine());
                switch (b)
                {
                    case 1:
                        Iniciar();
                        break;
                    case 2:
                        Program.Main();
                        break;
                    case 0:
                        Console.Clear();
                        Fin.Iniciar();
                        break;
                }
            }
            else if (a == 2)
            {
                Program.Main();
            }
            else
            { Fin.Iniciar(); }
        }


    }
}
