using Decorator;
using Decorator.Decorators;
using Assert = NUnit.Framework.Assert;

namespace TestCakeKata
{
    public class Tests
    {
        const string expectedCupCakeName = "CupCake";
        const decimal expectedCupCakePrice = 10m;
        const string expectedCookieName = "Cookie";
        const decimal expectedCookiePrice = 2m;
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestCupCakeShouldReturnValidName()
        {
            var cupCake = new CupCake();
            
            Assert.That(cupCake.GetName(), Is.EqualTo(expectedCupCakeName));
            Assert.That(cupCake.GetPrice(), Is.EqualTo(expectedCupCakePrice));
        }

        [Test]
        public void TestCookieShouldReturnValidName()
        {
            var cupCake = new Cookie();
            
            Assert.That(cupCake.GetName(), Is.EqualTo(expectedCookieName));
            Assert.That(cupCake.GetPrice(), Is.EqualTo(expectedCookiePrice));
        }
        
        [Test]
        public void TestCookieWithChololateToppingShouldReturnValidName()
        {
            var cookie = new Cookie();
            var topping = new ToppingChololate();
            topping.InitCakeType(cookie);

            Assert.That(topping.GetName(), Is.EqualTo("Cookie with Chocolate"));
            Assert.That(topping.GetPrice(), Is.EqualTo(7m));
        }

        private static IEnumerable<TestCaseData> InitTestCases
        {
            get
            {
                yield return new TestCaseData(new Cookie(), "Cookie with Sugar", 2.5m);
                yield return new TestCaseData(new CupCake(), "CupCake with Sugar", 10.5m);
            }
        }

        [Test]
        [TestCaseSource(nameof(InitTestCases))]
        public void TestCakesWithOneToppingShouldReturnValidName(Cake cake, string expectedName, decimal expectedPrice)
        {
            var topping = new ToppingSugar();
            topping.InitCakeType(cake);

            Assert.That(topping.GetName(), Is.EqualTo(expectedName));
            Assert.That(topping.GetPrice(), Is.EqualTo(expectedPrice));
        }

        private static IEnumerable<TestCaseData> InitTestCasesToppings
        {
            get
            {
                yield return new TestCaseData(new Cookie()
                    , new List<Cake>() { 
                         new ToppingSugar()
                        , new ToppingNuts()
                        , new ToppingChololate()}
                    , "Cookie with Sugar with Nuts with Chocolate"
                    , 8.1m);
                //yield return new TestCaseData(new CupCake(), "CupCake with Sugar", 10.5m);
            }
        }
        [Test]
        [TestCaseSource(nameof(InitTestCasesToppings))]
        public void TestCakeWithManyToppingsShouldReturnValidName(Cake cake, List<Cake> listTopping
            , string expectedName, decimal expectedPrice)
        {
            var cakeWithTopping = cake;
            foreach(CakeDecorator topping in listTopping)
            {
                topping.InitCakeType(cakeWithTopping);
                cakeWithTopping = topping;
            }

            Assert.That(cakeWithTopping.GetName(), Is.EqualTo(expectedName));
            Assert.That(cakeWithTopping.GetPrice(), Is.EqualTo(expectedPrice));
        }

    }
}