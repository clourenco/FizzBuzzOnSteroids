using FizzBuzzOnSteroids.Core;
using FizzBuzzOnSteroids.Core.Step1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzOnSteroidsTests.Step1
{
	[TestClass]
	public class StepOneTests
	{
		private IStep sut;

		[TestMethod]
		public void CheckFizzTest_WhenNumberIsMultipleOf3_ReturnsTrue()
		{
			Assert.IsTrue(sut.CheckFizz(15));
		}

		[TestMethod]
		public void CheckBuzzTest_WhenNumberIsMultipleOf5_ReturnsTrue()
		{
			Assert.IsTrue(sut.CheckBuzz(15));
		}

		[TestMethod]
		public void CheckFizzBuzzTest_WhenNumberIsMultipleOf15_ReturnsTrue()
		{
			Assert.IsTrue(sut.CheckFizzBuzz(15));
		}

		[TestInitialize]
		private void InitTestConfig()
		{
			sut = new StepOne();
		}
	}
}
