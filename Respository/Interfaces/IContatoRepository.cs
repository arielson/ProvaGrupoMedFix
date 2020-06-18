using Domain.Models;
using DTO;

namespace Repository.Interfaces
{
    public interface IContatoRepository : IBaseRepository<Contato>
    {
        void AddContato(ContatoDTO contatoDTO);
    }
}
