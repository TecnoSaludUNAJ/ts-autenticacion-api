using TP_Domain.Entities;

namespace TP_Domain.DTOs
{
    public class ResponseUserDto
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int RolId { get; set; }
    }
}
