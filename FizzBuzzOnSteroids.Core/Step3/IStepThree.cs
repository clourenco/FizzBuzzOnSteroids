using FizzBuzzOnSteroids.Core.Step2;

namespace FizzBuzzOnSteroids.Core.Step3
{
	public interface IStepThree : IStepTwo
	{
		int LuckyCounter { get; }

		int FizzCounter { get; }

		int BuzzCounter { get; }

		int FizzBuzzCounter { get; }
	}
}
