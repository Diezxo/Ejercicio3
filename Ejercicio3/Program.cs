
/*Por teclado se ingresa el valor hora de un empleado.Posteriormente se ingresa el nombre del empleado,
la antigüedad y la cantidad de horas trabajadas en el mes. Se pide calcular el importe a cobrar 
teniendo en cuenta que,al total que resulta de multiplicar el valor hora por la cantidad de horas trabajadas,
hay que sumarle la cantidad de años trabajados multiplicados por $30, y al total de todas 
esas operaciones restarle el 13% en concepto de descuentos. Imprimir el recibo correspondiente-
con el nombre, la antigüedad,el valor hora, el total a cobrar en bruto, 
el total de descuentos y el valor neto a cobrar.*/
namespace Factura
{
    class Empleado
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
            Console.WriteLine("Nombre del Empleado: "+nombre);
            Console.WriteLine("Tiempo laborando: "+antiguedad_años+ " Años");
            Console.WriteLine("Valor Monetario: "+valor_hora+" dolares por hora");
            Console.WriteLine("Salario del Mes: "+importe_cobrarbruto+" dolares");
            Console.WriteLine("Total de Descuentos aplicados: "+descuento);
            Console.WriteLine("Salario neto del Mes: " + importe_total+" dolares");
        }
    
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Cuanto es el valor por hora que devenga el empleado");
                empleado.valor_hora = (float)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Cual es el nombre del empleado?");
                empleado.nombre = Console.ReadLine();
                Console.WriteLine("Cuantos años lleva en la empresa");
                empleado.antiguedad_años = (float)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Cuantas horas trabajo en el mes?");
                empleado.horas_mes = (float)Convert.ToDouble(Console.ReadLine());
                
            }
            float importe_subtotal = empleado.valor_hora * empleado.horas_mes;
            float liquidacion = empleado.antiguedad_años * 30;
            empleado.importe_cobrarbruto = importe_subtotal + liquidacion;
            const float cons = 0.13F;
            empleado.descuento = empleado.importe_cobrarbruto * cons;
            empleado.importe_total = empleado.importe_cobrarbruto - empleado.descuento;

            Console.WriteLine("Presione: 1 Imprimir el Recibo / 0 Ingresar otro empleado");
            int Res=Convert.ToInt32(Console.ReadLine());
            if (Res == 1)
            {
                empleado.Getrecibo();
            }
            else if(Res == 0)
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Fin");
            }
            

        }
    }
}

