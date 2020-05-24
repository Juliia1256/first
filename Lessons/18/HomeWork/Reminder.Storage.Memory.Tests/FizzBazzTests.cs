using NUnit.Framework;

namespace Reminder.Storage.Memory.Tests
{
	public class Logic
	{
		// Switch Expressions, available from C# 8.0
		public string FizzBaz(int number) =>
			(number % 3 == 0, number % 5 == 0) switch
			{
				(true, true) => "FizzBaz",
				(true, _) => "Fizz",
				(_, true) => "Baz",
				_ => number.ToString()
			};
	}

	public class FizzBazzTests
	{
		private Logic _logic;

		[SetUp]
		public void Setup()
		{
			_logic = new Logic();
		}

		[Test]
		[TestCase(1)]
		[TestCase(7)]
		[TestCase(41)]
		public void WhenNumberNotDivided_ThenResultWillBeNumber(int number)
		{
			var result = _logic.FizzBaz(number);
			Assert.AreEqual(number.ToString(), result);
		}

		[Test]
		public void WhenNumberDivideBy3_ThenResultWillBeFizz()
		{
			// Act
			var result = _logic.FizzBaz(3);

			// Assert
			Assert.AreEqual("Fizz", result);
		}

		[Test]
		public void WhenNumberDivideBy5_ThenResultWillBeBaz()
		{
			var result = _logic.FizzBaz(5);
			Assert.AreEqual("Baz", result);
		}

		[Test]
		public void WhenNumberDivideBy15_ThenResultWillBeFizzBaz()
		{
			var result = _logic.FizzBaz(45);
			Assert.AreEqual("FizzBaz", result);
		}
	}
}