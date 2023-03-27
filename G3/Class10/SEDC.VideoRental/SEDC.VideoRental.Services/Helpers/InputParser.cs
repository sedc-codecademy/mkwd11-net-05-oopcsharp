using SEDC.VideoRental.Data.Enums;
using System;
using System.Collections.Generic;

namespace SEDC.VideoRental.Services.Helpers
{
	public class InputParser
	{
		private static readonly List<string> _validConfirmInputs = new List<string> { "Y", "y","Yes","1","True" };
		private static readonly List<string> _validDeclineInputs = new List<string> { "N", "n", "No", "0", "False" };

		public static int ToInteger(int min, int max)
        {
			var parsedNumber = 0;
			bool isValid = false;
			while (!isValid)
			{
				try
				{
					parsedNumber = int.Parse(Console.ReadLine());
					if(!(parsedNumber >= min && parsedNumber <= max))
					{
						throw new Exception($"Please selct from the given input range from {min} to {max}.");
					}
					isValid = !isValid;
				}
				catch(ArgumentNullException)
				{
					Console.WriteLine("Please enter argument");
				}
				catch (FormatException)
				{
					Console.WriteLine("Not valid input");
				}
				catch (OverflowException)
				{
					Console.WriteLine("Number is to large or to low.");
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
			return parsedNumber;
        }

		public static bool ToConfirm()
		{
			bool isValidInput;
			while (true)
			{
				var value = Console.ReadLine();
				if(_validConfirmInputs.Contains(value))
				{
					isValidInput = true;
					break;
				}
				else if (_validDeclineInputs.Contains(value))
				{
					isValidInput = false;
					break;
				}
				else
				{
					Console.WriteLine("Please enter valid input");
					Console.WriteLine($"Valid inputs {String.Join(", ", _validConfirmInputs.ToArray())} and {String.Join(", ", _validDeclineInputs.ToArray())}");
				}
			}
			return isValidInput;
		}

		public static DateTime ToDateTime()
		{
			while (true)
			{
                Console.WriteLine("Enter year");
                int year = ToInteger(1900, DateTime.Now.Year - 18);
                Console.WriteLine("Enter Month");
                int month = ToInteger(1, 12);
                Console.WriteLine("Enter Day");
				int day = ToInteger(1, DateTime.DaysInMonth(year, month));
				try
				{
					var dob = new DateTime(year, month, day);
					return dob;
				}
				catch (Exception)
				{
					Console.WriteLine("Not valid input");
				}
            }
		}

		// TODO: PART 2
		public static Genre ToGenre()
		{
			while(true)
			{
				int coutner = 0;
				foreach (var item in Enum.GetNames(typeof(Genre)))
				{
					Console.WriteLine("{0}. {1}", coutner + 1, item);
					coutner++;
				}
				var genreSelection = ToInteger(1, Enum.GetNames(typeof(Genre)).Length);
				var isValid = Enum.TryParse(typeof(Genre), (genreSelection - 1).ToString(), out var genre);

				if (isValid)
				{
					return (Genre)genre;
				}

				Console.WriteLine("Please enter a valid input");
			}
		}
		// TODO: END PART 2
    }
}
