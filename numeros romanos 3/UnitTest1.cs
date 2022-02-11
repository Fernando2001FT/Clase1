using FluentAssertions;
using Mecanica;
using Xunit;

namespace Mecanica
{
    public class UnitTestmecanica 
    {


        [Theory]
        [InlineData("PCQ0111", "Toyota Yaris 2010")]
        [InlineData("PBX0211", "Dfsk C37 2016 ")]
        [InlineData("PXZ0311", "Ford Ranger 2010")]
        [InlineData("PYZ0411", "Nissan Sentra 2007")]

        public void PlacaVehiculo (string Placa_Vehiculo, string resultadoEsperado)
        {
            
            //Arrange
            //  const string resultadoEsperado = "I";
            //const int numeroaconvertir = 1;
            //Act
            var resultado = Convertidor.PlacaVehiculo(Placa_Vehiculo);

            //Aspect
            resultado.Should().Be(resultadoEsperado);
        }
        [Theory]
        [InlineData(05,02,2020 ,"Si debe realizar mantenimiento")]
        [InlineData(06,05,2015, "Si debe realizar mantenimiento")]
        [InlineData(29,05,2016, "Si debe realizar mantenimiento")]
        [InlineData(10,02,2022, "no debe realizar mantenimiento ")]
        [InlineData(16,05,2005, "Si debe realizar mantenimiento")]

        public void Mantenimiento(int dia ,int mes,int anio,string resultadoEsperado)
        {

            //Arrange
            //  const string resultadoEsperado = "I";
            //const int numeroaconvertir = 1;
            //Act
            var resultado = Convertidor.MantenimientoVehiculo(dia,mes,anio);

            //Aspect
            resultado.Should().Be(resultadoEsperado);
        }

        [Theory]
        [InlineData(05, 02, 2020, "no cambiar pieza ")]
        [InlineData(06, 05, 2015, "Realizar cambio de pieza")]
        [InlineData(29, 01, 2016, "Realizar cambio de pieza")]
        [InlineData(10, 02, 2022, "no cambiar pieza ")]
        [InlineData(16, 05, 2005, "Realizar cambio de pieza")]

        public void Cambiopiezas(int dia, int mes, int anio, string resultadoEsperado)
        {

            //Arrange
            //  const string resultadoEsperado = "I";
            //const int numeroaconvertir = 1;
            //Act
            var resultado = Convertidor.Cambiopiezasvehiculo(dia, mes, anio);

            //Aspect
            resultado.Should().Be(resultadoEsperado);
        }

    }
}