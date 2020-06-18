using Domain.Models;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Services
{
    public class ContatoService : BaseService<Contato>, IContatoService
    {
        public readonly IContatoRepository _contatoRepository;

        public ContatoService(IContatoRepository contatoRepository)
            : base(contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
    }
}
