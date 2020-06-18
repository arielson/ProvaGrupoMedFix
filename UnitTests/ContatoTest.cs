using System;
using Domain.Enumerators;
using DTO;
using FluentAssertions;
using Repository.Repositories;
using Xunit;

namespace UnitTests
{
    public class ContatoTest
    {
        [Fact]
        public void Verifica_Cadastro_Contato_MaiorDeIdade()
        {
            // Arrange
            ContatoDTO contatoDeMenor = new ContatoDTO 
            {
                Nome = "Teste",
                DataNascimento = new DateTime(2010, 1, 1),
                Sexo = Sexo.Masculino
            };

            // Act  // Assert
            contatoDeMenor.Idade.Should().BeGreaterOrEqualTo(18);
        }
    }
}