using TP_Domain.Entities;

namespace TP_Domain.DTOs
{
    public class ResponseUserLoginDto
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public int RolId { get; set; }
    }
}
