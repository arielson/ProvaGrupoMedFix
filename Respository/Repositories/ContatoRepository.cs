using System;
using Domain.Models;
using DTO;
using Repository.Interfaces;

namespace Repository.Repositories
{
    public class ContatoRepository : BaseRepository<Contato>, IContatoRepository
    {
        private readonly MedyCorpDbContext _context;
        public ContatoRepository(MedyCorpDbContext context) : base(context)
        {
            _context = context;
        }

        void IContatoRepository.AddContato(ContatoDTO contatoDTO)
        {
            try
            {
                if (contatoDTO.Idade > 18)
                    Add(new Contato
                    {
                        Nome = contatoDTO.Nome,
                        DataNascimento = contatoDTO.DataNascimento,
                        Sexo = contatoDTO.Sexo,
                        Idade = contatoDTO.Idade
                    });
                else
                    throw new Exception("Proibido cadastro para menor de idade");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
