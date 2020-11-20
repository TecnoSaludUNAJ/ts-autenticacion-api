using TP_Domain.Entities;

namespace TP_Domain.Queries
{
    public interface IAutenticationQuery
    {
        public Usuario GetUserByEmail(string email);
        public Usuario GetUserByDNI(string dni);
    }
}
