﻿namespace Demo.Tests
{
    public class AssertingExceptionsTests
    {
        [Fact]
        public void Calculdora_Dividir_DeveRetornarErroDivisaoPorZero()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act & Assert 
            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
        }

        [Fact]
        public void Funcionario_Salario_DeveRetornarErroSalarioInferiorAoPermitido()
        {
            //Arrange & Act & Assert
            var exception = Assert.Throws<Exception>(()=> FuncionarioFactory.Criar("Karen", 300));

            
            Assert.Equal("Salario inferior ao permitido", exception.Message);
        }
    }
}
