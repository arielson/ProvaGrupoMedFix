using System;
using Domain.Models;

namespace DTO
{
    public class ContatoDTO
    {
        public ContatoDTO() {}
        public ContatoDTO(Contato item) 
        {
            if(item != null) 
            {
                Id = item.Id;
                Nome = item.Nome;
                DataNascimento = item.DataNascimento;
            }
        }
        public long Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Domain.Enumerators.Sexo Sexo { get; set; }
        public int Idade 
        { 
            get 
            {
                var hoje = DateTime.Today;
                var idade = hoje.Year - DataNascimento.Year;
                if (DataNascimento.Date > hoje.AddYears(-idade)) idade--;

                return idade;
            } 
        }
    }
}
