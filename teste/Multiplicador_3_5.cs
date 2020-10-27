using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace teste
{
    [TestClass]
    public class Multiplicador_3_5
    {
        #region TestesTrue
        [TestMethod]
        public void Multiplicador3_5_15_True()
        {
            var dividendo = 15;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, 3);
            Assert.IsTrue(resultado);

            resultado = FizzBuzzHelper.EhMultiplicador(dividendo, 5);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Multiplicador3_5_30_True()
        {
            var dividendo = 30;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, 3);
            Assert.IsTrue(resultado);

            resultado = FizzBuzzHelper.EhMultiplicador(dividendo, 5);
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void Multiplicador3_5_45_True()
        {
            var dividendo = 45;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, 3);
            Assert.IsTrue(resultado);

            resultado = FizzBuzzHelper.EhMultiplicador(dividendo, 5);
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void Multiplicador3_5_90_True()
        {
            var dividendo = 90;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, 3);
            Assert.IsTrue(resultado);

            resultado = FizzBuzzHelper.EhMultiplicador(dividendo, 5);
            Assert.IsTrue(resultado);

        }

        #endregion

        #region TestesFalse
        [TestMethod]
        public void Multiplicador3_5_10_False()
        {
            var dividendo = 10;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, 3);
            Assert.IsFalse(resultado);

            resultado = FizzBuzzHelper.EhMultiplicador(dividendo, 5);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Multiplicador3_5_13_False()
        {
            var dividendo = 13;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, 3);
            Assert.IsFalse(resultado);

            resultado = FizzBuzzHelper.EhMultiplicador(dividendo, 5);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Multiplicador3_5_50_False()
        {
            var dividendo = 50;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, 3);
            Assert.IsFalse(resultado);

            resultado = FizzBuzzHelper.EhMultiplicador(dividendo, 5);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Multiplicador3_5_100_False()
        {
            var dividendo = 100;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, 3);
            Assert.IsFalse(resultado);

            resultado = FizzBuzzHelper.EhMultiplicador(dividendo, 5);
            Assert.IsTrue(resultado);
        }
        #endregion

    }
}
