using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Domain.Enumerators;
using Domain.Models;
using DTO;
using FluentAssertions;
using Xunit;

namespace IntegrationTests
{
    public class ContatoControllerTest : BaseTest
    {
        [Fact]
        public async Task GetAll_ReturnsEmpty() 
        {
            // Arrange

            // Act
            var response = await TestClient.GetAsync("api/v1/Contato");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            (await response.Content.ReadAsAsync<List<Contato>>()).Should().BeEmpty();
        }

        [Fact]
        public async Task GetAll_MaiorIdade() 
        {
            // Arrange

            // Act
            var response = await TestClient.GetAsync("api/v1/Contato");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var contatos = (await response.Content.ReadAsAsync<List<Contato>>());
            contatos.ForEach(x => x.Idade.Should().BeGreaterOrEqualTo(18));
        }

        [Fact]
        public async Task Cadastro_Contato_MenorIdade_ReturnsError()
        {
            // Arrange
            ContatoDTO contatoDeMenor = new ContatoDTO 
            {
                Nome = "Teste",
                DataNascimento = new DateTime(2000, 1, 1),
                Sexo = Sexo.Masculino
            };

            // Act 
            var response = await TestClient.PostAsJsonAsync("api/v1/Contato", contatoDeMenor);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }
    }
}
