using NUnit.Framework;

namespace Reminder.Storage.Memory.Tests
{
    public class Logic
    {
        public string FizzBazz(int number) =>
            (number % 3 == 0, number % 5 == 0) switch
            {
                (true, true) => "FizzBazz",
                (true, _) => "Fizz",
                (_, true) => "Bazz",
                _ => number.ToString()
            };
        //{
            //if ((number % 5 == 0) && (number % 3 == 0))
            //{
            //    return "FizzBazz";
            //}

            //if (number % 3 == 0)
            //{
            //    return "Fizz";
            //}
            //if (number % 5 == 0)
            //{
            //    return "Bazz";
            //}
            //else
            //{
            //    return number.ToString();
            //}
            

        //}
    }

    public class FizzBazzTests
    {
        private Logic _logic;
        [SetUp]
        public void SetUp()
        {
            _logic = new Logic();
        }

        [Test]
        [TestCase(1)]
        [TestCase(7)]
        [TestCase(41)]
        public void WhenNumberNotDivided_ThenResultWillBeNumber(int number)
        { 
            var result = _logic.FizzBazz(number);
            Assert.AreEqual(number.ToString(), result);
        }
        [Test]
        public void WhenNumberDivideBy3_ThenResultWillBeFizz()
        {

            var result = _logic.FizzBazz(3);
            Assert.AreEqual("Fizz", result);
        }
        [Test]
        public void WhenNumberDivideBy5_ThenResultWillBeBazz()
        {

            var result = _logic.FizzBazz(5);
            Assert.AreEqual("Bazz", result);
        }
        [Test]
        public void WhenNumberDivideBy3and5_ThenResultWillBeFizzBazz()
        {

            var result = _logic.FizzBazz(45);
            Assert.AreEqual("FizzBazz", result);
        }

    }
}