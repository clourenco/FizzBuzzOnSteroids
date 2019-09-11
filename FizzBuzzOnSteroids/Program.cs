using FizzBuzzOnSteroids.Core;
using FizzBuzzOnSteroids.Core.Step1;
using FizzBuzzOnSteroids.Core.Step2;
using FizzBuzzOnSteroids.Core.Step3;
using System;
using System.Text;

namespace FizzBuzzOnSteroids
{
	class Program
	{
		private const string Fizz = "fizz";

		private const string Buzz = "buzz";

		private const string FizzBuzz = "fizzbuzz";

		private const string Lucky = "lucky";

		private const string Integer = "integer";

		private static int integerCounter;

		static void Main(string[] args)
		{
			integerCounter = 0;

			//Step 1 use case
			//args = new string[] { "2", "16" };

			//Step 1 use case
			//args = new string[] { "-3", "-1" };

			//Step 2 use case
			//args = new string[] { "2", "14" };

			//Step 3 use case
			args = new string[] { "1", "20" };



			//---------------------------------------------------------------------------------------------------
			//int min = 0;
			//while (!int.TryParse(Console.ReadLine(), out min))
			//{
			//	Console.WriteLine("The lower bound of the range is invalid.");
			//}
			//---------------------------------------------------------------------------------------------------



			int min, max;
			ValidateInput(args, out min, out max);
			
			StringBuilder sOut = new StringBuilder();

			//Step 1 execution
			//RunStepOne(min, max, sOut);

			//Step 2 execution
			//RunStepTwo(min, max, sOut);

			//Step 3 execution
			RunStepThree(min, max, sOut);

			Console.WriteLine(sOut.ToString());
			Console.ReadLine();
		}

		private static void RunStepOne(int min, int max, StringBuilder sOut)
		{
			string output = "";
			IStep stepOne = new StepOne();

			for (int i = min; i <= max; i++)
			{
				output = RunChecks(stepOne, i);

				sOut.AppendFormat("{0} ", output);
			}
		}

		private static void RunStepTwo(int min, int max, StringBuilder sOut)
		{
			string output = "";
			IStepTwo stepTwo = new StepTwo();

			for (int i = min; i <= max; i++)
			{
				output = RunChecks(stepTwo, i);
				output = RunCheckForNumberThree(output, stepTwo, i);

				sOut.AppendFormat("{0} ", output);
			}
		}

		private static void RunStepThree(int min, int max, StringBuilder sOut)
		{
			string output = "";
			IStepThree stepThree = new StepThree();

			for (int i = min; i <= max; i++)
			{
				output = RunChecks(stepThree, i);
				output = RunCheckForNumberThree(output, stepThree, i);
				
				sOut.AppendFormat("{0} ", output);
			}

			sOut.AppendFormat("\n {0} ", RunReport(stepThree));
		}

		private static string RunReport(IStepThree stepThree)
		{
			StringBuilder report = new StringBuilder();
			
			report.AppendFormat("{0}: {1}   ", Fizz, stepThree.FizzCounter);
			report.AppendFormat("{0}: {1}   ", Buzz, stepThree.BuzzCounter);
			report.AppendFormat("{0}: {1}   ", FizzBuzz, stepThree.FizzBuzzCounter);
			report.AppendFormat("{0}: {1}   ", Lucky, stepThree.LuckyCounter);
			report.AppendFormat("{0}: {1}   ", Integer, integerCounter);

			return report.ToString();
		}

		private static string RunCheckForNumberThree(string output, IStepTwo stepTwo, int val)
		{
			if (stepTwo.HasNumberThree(val))
			{
				output = Lucky;
			}

			return output;
		}

		private static string RunChecks(IStep stepOne, int i)
		{
			string output;

			if (stepOne.CheckFizzBuzz(i))
			{
				output = FizzBuzz;
			}
			else if (stepOne.CheckBuzz(i))
			{
				output = Buzz;
			}
			else if (stepOne.CheckFizz(i))
			{
				output = Fizz;
			}
			else
			{
				output = i.ToString();
				IncrementIntegerCounter();
			}

			return output;
		}

		private static void IncrementIntegerCounter()
		{
			integerCounter++;
		}

		private static void ValidateInput(string[] args, out int min, out int max)
		{
			min = -1;
			max = -1;

			int.TryParse(args[0], out min);

			if (min == 0)
			{
				Console.WriteLine("The lower bound of the range is invalid.");
				Console.ReadLine();
			}

			int.TryParse(args[1], out max);

			if (max == 0)
			{
				Console.WriteLine("The upper bound of the range is invalid.");
				Console.ReadLine();
			}
		}
	}
}
