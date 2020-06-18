using System;

namespace Domain.Models
{
    public class Contato : Base
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Enumerators.Sexo Sexo { get; set; }
        public int Idade { get; set; }
    }
}
