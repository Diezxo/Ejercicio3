namespace Factura
{
    class Empleado
    {
        public float valor_hora { get; set; }   
        public string? nombre { get; set; }
        public float antiguedad_años { get; set; }
        public float horas_mes { get; set; }

 
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            for(int i = 0; i < 1; i++)
            {
                Console.WriteLine("Cuanto es el valor por hora que devenga el empleado");
                empleado.valor_hora= (float)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Cual es el nombre del empleado?");
                empleado.nombre=Console.ReadLine();
                Console.WriteLine("Cuantos años lleva en la empresa");
                empleado.antiguedad_años=(float)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Cuantas horas trabajo en el mes?");
                empleado.horas_mes=(float)Convert.ToDouble(Console.ReadLine());
            } 
            double importe_subtotal = empleado.valor_hora * empleado.horas_mes;
            double liquidacion = empleado.antiguedad_años * 30;
            double importe_cobrarbruto = importe_subtotal * liquidacion;
            const double cons = 0.13;
            double descuento= importe_cobrarbruto * cons;
            double importe_total = importe_cobrarbruto - descuento;

            Console.WriteLine(importe_total);
        }
    }
}