using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Models;
using DTO;
using Service.Interfaces;

namespace Service.Services
{
    public class ContatoApplicationService : IContatoApplicationService
    {
        private readonly IContatoService _contatoService;
     
        public ContatoApplicationService(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }

        public void Add(ContatoDTO obj)
        {
            if (obj.Idade > 18)
                    _contatoService.Add(new Contato
                    {
                        Nome = obj.Nome,
                        DataNascimento = obj.DataNascimento,
                        Sexo = obj.Sexo,
                        Idade = obj.Idade
                    });
                else
                    throw new Exception("Proibido cadastro para menor de idade");
        }

        public void Dispose()
        {
            _contatoService.Dispose();
        }

        public IEnumerable<ContatoDTO> GetAll()
        {
            return _contatoService.GetAll().Select(x => new ContatoDTO(x));
        }

        public ContatoDTO GetById(long id)
        {
            return new ContatoDTO(_contatoService.GetById(id));
        }

        public void Remove(ContatoDTO obj)
        {
            _contatoService.Remove(new Contato 
            {
                Id = obj.Id,
                Nome = obj.Nome,
                DataNascimento = obj.DataNascimento,
                Idade = obj.Idade
            });
        }

        public void Update(ContatoDTO obj)
        {
            _contatoService.Update(new Contato 
            {
                Id = obj.Id,
                Nome = obj.Nome,
                DataNascimento = obj.DataNascimento,
                Idade = obj.Idade
            });
        }
    }
}