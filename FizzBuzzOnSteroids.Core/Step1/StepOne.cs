using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzOnSteroids.Core.Step1
{
	public class StepOne : IStep
	{
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
