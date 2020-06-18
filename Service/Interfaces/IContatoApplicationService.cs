using System.Collections.Generic;
using DTO;

namespace Service.Interfaces
{
    public interface IContatoApplicationService
    {
        void Add(ContatoDTO obj);

        ContatoDTO GetById(long id);

        IEnumerable<ContatoDTO> GetAll();

        void Update(ContatoDTO obj);

        void Remove(ContatoDTO obj);

        void Dispose();
    }
}
