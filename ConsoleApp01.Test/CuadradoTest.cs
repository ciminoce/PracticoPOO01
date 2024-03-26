using ConsoleApp01.Entidades;

namespace ConsoleApp01.Test
{
    [TestClass]
    public class CuadradoTest
    {
        [TestMethod]
        public void CalcularPerimetro_DeberiaCalcularOK()
        {
            //arrange
            double medidaLado = 5;
            Cuadrado c=new Cuadrado(medidaLado);
            //act
            var perimetroCalculado = c.CalcularPerimetro();
            //assert
            Assert.AreEqual(20, perimetroCalculado);
        }
        [TestMethod]
        public void CalcularArea_DeberiaCalcularOK()
        {
            //arrange
            double medidaLado = 5;
            Cuadrado c = new Cuadrado(medidaLado);
            //act
            var areaCalculada = c.CalcularArea();
            //assert
            Assert.AreEqual(25, areaCalculada);

        }
        [TestMethod]
        public void Validar_DeberiaDevolverTrue()
        {
            //arrange
            double medidaLado = 5;

            //act
            Cuadrado c = new Cuadrado(medidaLado);
            //assert
            Assert.IsTrue(c.Validar());

        }
        [TestMethod]
        public void Validar_DeberiaDevolverFalse()
        {
            //arrange
            double medidaLado = -5;

            //act
            Cuadrado c = new Cuadrado(medidaLado);
            //assert
            Assert.IsFalse(c.Validar());

        }
        [TestMethod]
        public void MostrarInformacion_DeberiaMostrarOK()
        {
            //arrange
            double medidaLado = 5;
            Cuadrado c = new Cuadrado(medidaLado);

            //act
            var info = c.MostrarInformacion();
            //assert
            StringAssert.Contains(info, "Cuadrado de lado 5");

            StringAssert.Contains(info, "Perímetro: 20");
            StringAssert.Contains(info, "Área: 25");


        }
    }
}