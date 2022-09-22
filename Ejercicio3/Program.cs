
/*Por teclado se ingresa el valor hora de un empleado.Posteriormente se ingresa el nombre del empleado,
la antigüedad y la cantidad de horas trabajadas en el mes. Se pide calcular el importe a cobrar 
teniendo en cuenta que,al total que resulta de multiplicar el valor hora por la cantidad de horas trabajadas,
hay que sumarle la cantidad de años trabajados multiplicados por $30, y al total de todas 
esas operaciones restarle el 13% en concepto de descuentos. Imprimir el recibo correspondiente-
con el nombre, la antigüedad,el valor hora, el total a cobrar en bruto, 
el total de descuentos y el valor neto a cobrar.*/
using Empresa;
namespace Empresa
{

    class Program
    {


        public static void Main(string[] args)
        {
            Pago_Empleado menu1= new Pago_Empleado();
            Contabilidad menu2=new Contabilidad();
            Detallarsalarios menu3=new Detallarsalarios();
            // menu2.generarconteo();
            //menu1.Generarrecibo();
            menu3.Registrar();
            
        }
    }
    
}

