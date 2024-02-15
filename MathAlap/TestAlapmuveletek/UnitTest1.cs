using MathAlap;

namespace TestAlapmuveletek
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(300,200,100)]
        [TestCase(400, 200, 200)]
        [TestCase(700, 400, 300)]
        [TestCase(500.3456788,250.35,250)]
        public void OsszeadasTest(double elvart,double a,double b)
        {
            //H�rom r�sz arrange, act, assert (AAA)

            //arrange: el�k�sz�letek
            //act: m�velet, m�veletek elv�gz�se
            //assert: a kapott eredm�ny ki�rt�kel�se

            //arrange
            Alapmuveletek alapmuveletek = new Alapmuveletek();

            //act
            var eredmeny = alapmuveletek.Osszeadas(a, b);

            //assert
            Assert.AreEqual(elvart, eredmeny,0.01);
        }
    }
}