using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa;
namespace Empresa
{
     class Empleados
    {
        public int id { get; set; }
        public string? genero { get; set; }
        public int sueldo { get; set; }
        public float valor_hora { get; set; }
        public string? nombre { get; set; }
        public float antiguedad_años { get; set; }
        public float horas_mes { get; set; }
        public float importe_cobrarbruto { get; set; }
        public float descuento { get; set; }
        public float importe_total { get; set; }

       public Empleados(int Id, string? Nombre, string? IsMale, int Sueldo)
            {
                id = Id;
                nombre = Nombre;
                sueldo = Sueldo;
                genero = IsMale;
       }
        public Empleados (int _id, string? _genero, int _sueldo, float _valor_hora, string? _nombre, float _antiguedad_años, float _horas_mes, float _importe_cobrarbruto, float _descuento, float _importe_total)
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
        }
        public Empleados() { }

        public int getSueldo()
            {
                return sueldo;
            }
            public string? getGenero()
            {
                return genero;
            }
            public string? getNombre()
            {
                return nombre;
            }
            public void mostrardatos()
            {
                Console.WriteLine("Numero de Legajo: 00" + id);
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Genero: " + genero);
                Console.WriteLine("Sueldo: " + sueldo);
            }
     }
}

