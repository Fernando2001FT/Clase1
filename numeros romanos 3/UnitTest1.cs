using FluentAssertions;
using numeros_romanos_2;
using Xunit;

namespace numeros_romanos_3
{
    public class UnitTest1
    {


        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]

        public void Deberiadevolveracodigoromano (int numeroaconvertir, string resultadoEsperado)
        {
            
            //Arrange
            //  const string resultadoEsperado = "I";
            //const int numeroaconvertir = 1;
            //Act
            var resultado = convertidor.convertirarabicoaromano(numeroaconvertir);

            //Aspect
            resultado.Should().Be(resultadoEsperado);
        }
    }
}