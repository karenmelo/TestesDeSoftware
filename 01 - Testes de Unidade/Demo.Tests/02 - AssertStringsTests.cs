namespace Demo.Tests
{
    public class AssertStringsTests
    {
        [Fact]
        public void StringsTools_UnirNomes_RetornarNomeCompleto()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nomeCompleto = sut.Unir("Karen", "Melo");

            //Assert
            Assert.Equal("Karen Melo", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveIgnorarCase()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nomeCompleto = sut.Unir("Karen", "Melo");

            //Assert
            Assert.Equal("karen melo", nomeCompleto, true);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveConterTrecho()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nomeCompleto = sut.Unir("Karen", "Melo");

            //Assert
            Assert.Contains("aren", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveComecarCom()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nomeCompleto = sut.Unir("Karen", "Melo");

            //Assert
            Assert.StartsWith("Kar", nomeCompleto);

        }

        [Fact]
        public void StringsTools_UnirNomes_DeveAcabarCom()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nomeCompleto = sut.Unir("Karen", "Melo");

            //Assert
            Assert.EndsWith("elo", nomeCompleto);

        }


        [Fact]
        public void StringsTools_UnirNomes_ValidarExpressaoRegular()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nomeCompleto = sut.Unir("Karen", "Melo");

            //Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", nomeCompleto);

        }
    }
}
