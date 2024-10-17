namespace ControlEnvejecimiento.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public int RolId { get; set; }
        public String? Nombre { get; set; }
        public String? HashContraseña { get; set; }
        public String? Correo { get; set; }
    }
    public class UsuarioDTO
    {
        public int RolId { get; set; }
        public String? Nombre { get; set; }
        public String? HashContraseña { get; set; }
        public String? Correo { get; set; }
    }
}
