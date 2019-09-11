namespace FizzBuzzOnSteroids.Core.Step2
{
	public class StepTwo : IStepTwo
	{
		public bool HasNumberThree(int val)
		{
			return val.ToString().Contains("3");
		}

		public bool CheckFizz(int val)
		{
			return IsMultipleOf(val, 3);
		}

		public bool CheckBuzz(int val)
		{
			return IsMultipleOf(val, 5);
		}

		public bool CheckFizzBuzz(int val)
		{
			return IsMultipleOf(val, 15);
		}

		public bool IsMultipleOf(int val, int multiple)
		{
			return val % multiple == 0;
		}
	}
}
