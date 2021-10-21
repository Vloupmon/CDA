using NUnit.Framework;

namespace A001 {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void Test_Calc1() {
            int a = 111, b = 222;
            int expected = 333;
            ClassesATester.Calculatrice calc = new();
            Assert.AreEqual(expected, calc.Additionner(a, b));
        }

        [TestCase(0, -10, 10)]
        [TestCase(666, 333, 333)]
        [TestCase(1337, 100, 1237)]
        public void Test_Calc2(int expected, int a, int b) {
            ClassesATester.Calculatrice calc = new();
            Assert.AreEqual(expected, calc.Additionner(a, b));
        }

        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase("123456789012345", false)]
        [TestCase("q1234567890123", false)]   
        [TestCase("83426861700019", false)]
        [TestCase("83426861700018", true)]
        public void Test_Siret1(string siret, bool expected) {
            Assert.AreEqual(expected, ClassesATester.SIRET.VerifierSIRET(siret));
        }

    }
}