namespace ControlEnvejecimiento.Models
{
    public class ParametrosMedidos
    {
        public int Id { get; set; }
        public int IdRegistro { get; set; }
        public long FechaEpoch { get; set; }
        public double Temperatura { get; set; }
        public double Humedad { get; set; }
        public double IntensidadCorriente { get; set; }
    }
}
