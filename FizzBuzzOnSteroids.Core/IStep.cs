namespace FizzBuzzOnSteroids.Core
{
	public interface IStep
	{
		bool CheckFizzBuzz(int val);

		bool CheckBuzz(int val);

		bool CheckFizz(int val);

		bool IsMultipleOf(int val, int multiple);
	}
}
