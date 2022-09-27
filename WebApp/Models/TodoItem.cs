namespace WebApp.Models
{
    public class TodoItem
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
        public int gotas_dia { get; set; }
        public int gotas_promedio { get; set; }
        public int gotas_menor { get; set; }
        public int gotas_mayor { get; set; }
        public int dias_evaluados { get; set; }
        public int precio { get; set; }
    }
}
