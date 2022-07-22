namespace Demo.Tests
{
    public class AssertingObjectTypesTests
    {
        [Fact]
        public void FuncionarioFactory_Criar_DeveRetornarTipoFuncionario()
        {
            //Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Karen", 50000);

            //Assert
            Assert.IsType<Funcionario>(funcionario);
        }

        [Fact]
        public void FuncionarioFactory_Criar_DeveRetornarTipoDerivadoPessoa()
        {
            //Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Karen", 50000);

            //Assert
            Assert.IsAssignableFrom<Pessoa>(funcionario);
        }
    }
}
