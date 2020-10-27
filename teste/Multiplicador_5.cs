using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace teste
{
    [TestClass]
    public class Multiplicador_5
    {
        #region TestesTrue
        [TestMethod]
        public void Multiplicador5_5_True()
        {
            var dividendo = 5;
            var divisor = 5;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void Multiplicador10_5_True()
        {
            var dividendo = 10;
            var divisor = 5;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void Multiplicador15_5_True()
        {
            var dividendo = 15;
            var divisor = 5;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void Multiplicador25_5_True()
        {
            var dividendo = 25;
            var divisor = 5;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void Multiplicador100_5_True()
        {
            var dividendo = 100;
            var divisor = 5;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsTrue(resultado);

        }

        #endregion

        #region TestesFalse
        [TestMethod]
        public void Multiplicador1_5_False()
        {
            var dividendo = 1;
            var divisor = 5;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsFalse(resultado);

        }

        [TestMethod]
        public void Multiplicador4_5_False()
        {
            var dividendo = 4;
            var divisor = 5;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsFalse(resultado);

        }

        [TestMethod]
        public void Multiplicador6_5_False()
        {
            var dividendo = 6;
            var divisor = 5;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsFalse(resultado);

        }

        [TestMethod]
        public void Multiplicador12_5_False()
        {
            var dividendo = 12;
            var divisor = 5;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsFalse(resultado);

        }

        [TestMethod]
        public void Multiplicador31_5_False()
        {
            var dividendo = 31;
            var divisor = 5;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsFalse(resultado);

        }

        [TestMethod]
        public void Multiplicador59_5_False()
        {
            var dividendo = 59;
            var divisor = 5;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsFalse(resultado);

        }

        [TestMethod]
        public void Multiplicador99_5_False()
        {
            var dividendo = 99;
            var divisor = 5;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsFalse(resultado);

        }
        #endregion

    }
}
