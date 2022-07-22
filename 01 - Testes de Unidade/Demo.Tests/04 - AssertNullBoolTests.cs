namespace Demo.Tests
{
    public class AssertNullboolTests
    {
        [Fact]
        public void Funcionario_Nome_NaoDeveSerNuloOuVazio()
        {
            //Arrange
            var funcionario = new Funcionario("", 50000);

            //Assert
            Assert.False(string.IsNullOrEmpty(funcionario.Nome));
        }

        [Fact]
        public void Funcionario_Apelido_NaoDeveTerApelido()
        {
            //Arrange & Act
            var funcionario = new Funcionario("Karen", 50000);

            //Assert
            Assert.Null(funcionario.Apelido);
            Assert.True(string.IsNullOrEmpty(funcionario.Apelido));
            Assert.False(funcionario.Apelido?.Length > 0);
        }   
    }
}
