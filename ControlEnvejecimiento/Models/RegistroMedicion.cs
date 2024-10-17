namespace ControlEnvejecimiento.Models
{
    public class RegistroMedicion
    {
        public int Id { get; set; }
        public int IdRegsitro { get; set; }
        public double ConductividadElectrica { get; set; }
        public double ModuloElasticidad { get; set; }
        public double Dureza { get; set; }
        public double DegradacionCorrosiva { get; set; }
    }
}
