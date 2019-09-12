namespace FizzBuzzOnSteroids.Core.Step3
{
	public class StepThree : IStepThree
	{
		//private int luckyCounter;

		private int fizzCounter;

		private int buzzCounter;

		private int fizzBuzzCounter;

		/// <summary>
		/// 
		/// </summary>
		public StepThree()
		{
			//luckyCounter = 0;
			fizzCounter = 0;
			buzzCounter = 0;
			fizzBuzzCounter = 0;
		}

		/// <summary>
		/// 
		/// </summary>
		//public int LuckyCounter => luckyCounter;

		/// <summary>
		/// 
		/// </summary>
		public int FizzCounter => fizzCounter;

		/// <summary>
		/// 
		/// </summary>
		public int BuzzCounter => buzzCounter;

		/// <summary>
		/// 
		/// </summary>
		public int FizzBuzzCounter => fizzBuzzCounter;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
		public bool HasNumberThree(int val)
		{
			return val.ToString().Contains("3");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
		public bool CheckFizz(int val)
		{
			if (!HasNumberThree(val) && IsMultipleOf(val, 3))
			{
				IncrementFizzCounter();
				return true;
			}

			return false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
		public bool CheckBuzz(int val)
		{
			if (IsMultipleOf(val, 5))
			{
				IncrementBuzzCounter();
				return true;
			}

			return false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
		public bool CheckFizzBuzz(int val)
		{
			if (IsMultipleOf(val, 15))
			{
				IncrementFizzBuzzCounter();
				return true;
			}

			return false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val"></param>
		/// <param name="multiple"></param>
		/// <returns></returns>
		public bool IsMultipleOf(int val, int multiple)
		{
			return val % multiple == 0;
		}

		//private void IncrementLuckyCounter()
		//{
		//	luckyCounter++;
		//}

		private void IncrementFizzCounter()
		{
			fizzCounter++;
		}

		private void IncrementBuzzCounter()
		{
			buzzCounter++;
		}

		private void IncrementFizzBuzzCounter()
		{
			fizzBuzzCounter++;
		}
	}
}
