namespace Demo.Tests
{
    public class AssertingCollectionsTests
    {
        [Fact]
        public void Funcionario_Habilidades_NaoDevePossuirHabilidadesVazias()
        {
            //Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Karen", 50000);

            //Assert
            Assert.All(funcionario.Habilidades, habilidade => Assert.False(string.IsNullOrEmpty(habilidade)));
        }

        [Fact]
        public void Funcionario_Habilidades_JuniorDevePossuirHabilidadeBasica()
        {
            //Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Karen", 50000);

            //Assert
            Assert.Contains("OOP", funcionario.Habilidades);
        }

        [Fact]
        public void Funcionario_Habilidades_JuniorNaoDevePossuirHabilidadeAvancada()
        {
            //Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Karen", 50000);

            //Assert
            Assert.Contains("Microservice", funcionario.Habilidades);
        }

        [Fact]
        public void Funcionario_Habilidades_SeniorDevePossuirTodasHabilidades()
        {
            //Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Karen", 50000);

            var habilidades = new[]
            {
                "Logica de Programacao",
                "OOP",
                "Testes",
                "Microservices"
            };

            //Assert
            Assert.Equal(habilidades, funcionario.Habilidades);
        }
    }
}
