using Microsoft.VisualStudio.TestTools.UnitTesting;
using teste_fizzbuzz;

namespace teste
{
    [TestClass]
    public class Multiplicador_6
    {
        #region TestesTrue
        [TestMethod]
        public void Multiplicador3_3_True()
        {
            var dividendo = 3;
            var divisor = 3;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void Multiplicador6_3_True()
        {
            var dividendo = 6;
            var divisor = 3;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void Multiplicador9_3_True()
        {
            var dividendo = 9;
            var divisor = 3;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void Multiplicador12_3_True()
        {
            var dividendo = 12;
            var divisor = 3;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsTrue(resultado);

        }
        #endregion

        #region TestesFalse
        [TestMethod]
        public void Multiplicador1_3_False()
        {
            var dividendo = 1;
            var divisor = 3;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsFalse(resultado);

        }

        [TestMethod]
        public void Multiplicador4_3_False()
        {
            var dividendo = 4;
            var divisor = 3;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsFalse(resultado);

        }

        [TestMethod]
        public void Multiplicador5_3_False()
        {
            var dividendo = 5;
            var divisor = 3;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsFalse(resultado);

        }

        [TestMethod]
        public void Multiplicador10_3_False()
        {
            var dividendo = 10;
            var divisor = 3;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsFalse(resultado);

        }

        [TestMethod]
        public void Multiplicador11_3_False()
        {
            var dividendo = 11;
            var divisor = 3;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsFalse(resultado);

        }

        [TestMethod]
        public void Multiplicador13_3_False()
        {
            var dividendo = 13;
            var divisor = 3;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsFalse(resultado);

        }

         [TestMethod]
        public void Multiplicador100_3_False()
        {
            var dividendo = 100;
            var divisor = 3;

            var resultado = FizzBuzzHelper.EhMultiplicador(dividendo, divisor);
            Assert.IsFalse(resultado);

        }
        #endregion

    }
}
