namespace Calculadora_GitActions.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Sumar()
        {
            /// Arrange
            Funciones funciones = new();

            /// Act
            var suma = funciones.Sumar(5, 5);

            /// Assert
            Assert.Equal(10, suma);
        }

        [Fact]
        public void Test_Restar()
        {
            /// Arrange
            Funciones funciones = new();
            /// Act
            var resta = funciones.Restar(5, 5);
            ///            
            /// Assert
            Assert.Equal(0, resta);
        }

        [Fact]
        public void Test_Multiplicar()
        {
            /// Arrange
            Funciones funciones = new();
            /// Act
            var multiplicacion = funciones.Multiplicar(5, 5);
            /// Assert
            Assert.Equal(25, multiplicacion);

        }

        [Fact]
        public void Test_Dividir()
        {
            /// Arrange
            Funciones funciones = new();
            /// Act
            var division = funciones.Dividir(5, 5);
            ///                                             /// Assert
            Assert.Equal(1, division);

        }
    }
}