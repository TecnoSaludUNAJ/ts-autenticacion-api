namespace TP_Domain.DTOs
{
    public class RequestRegisterDto
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string Password { get; set; }
    }
}
