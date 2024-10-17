using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlEnvejecimiento.Models
{
    public class Registro
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoMaterial { get; set; }
        public DateTime FechaInicio { get; set; }
        public int Ciclos { get; set; }
        public int IdEstatus { get; set; }
    }
}
