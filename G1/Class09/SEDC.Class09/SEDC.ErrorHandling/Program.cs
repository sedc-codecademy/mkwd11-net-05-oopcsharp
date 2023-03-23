using SEDC.ErrorHandling.Models;


#region Try/Catch simple example
//try
//{
//    Console.WriteLine("Please enter a number");
//    int number = int.Parse(Console.ReadLine());
//    Console.WriteLine(number);
//}
//catch (Exception ex)
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("An error occured! Please contact help@gmail.com");
//    Console.WriteLine(ex.Message);
//    Console.WriteLine(ex.StackTrace);
//}
//finally
//{
//    // finally is executed in both cases
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.WriteLine("End of entering number!");
//}
#endregion


#region Throw exception

//try
//{
//    string letter = Console.ReadLine();
//    if(letter != "a" && letter != "b")
//    {
//        // excplicitly throwing an exception
//        // this is kind of our own exception
//        throw new Exception("An error occured! You have not inserted a or b!");
//    }
//}catch(Exception ex)
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine(ex.Message);
//    Console.WriteLine(ex.StackTrace);
//}
//finally
//{
//    Console.WriteLine("End of entering a and b");
//}

#endregion


#region Specific types of exception


//try
//{
//Console.WriteLine("Please enter a number");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine($"Number: {num}");


//User user = null;
//Console.WriteLine(user.Name);


//int[] numbers = new int[] { 1, 2, 3, };
//Console.WriteLine(numbers[4]);

//    int a = 10;
//    int b = 0;
//    int res = a / b;
//    Console.WriteLine(res);
//}
//catch (FormatException ex)
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Ooops. Something went wrong!");
//    Console.WriteLine(ex.Message);
//    Console.WriteLine(ex.StackTrace);
//}
//catch (NullReferenceException ex)
//{
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    Console.WriteLine(ex.Message);
//    Console.WriteLine(ex.StackTrace);
//}
//catch(IndexOutOfRangeException ex)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine(ex.Message);
//    Console.WriteLine(ex.StackTrace);
//}
//catch(Exception ex)
//{
//    Console.WriteLine("This is the general exception handler");
//    Console.WriteLine(ex.Message);
//    Console.WriteLine(ex.StackTrace);
//}


//Console.WriteLine("This is at the end of the application");


#endregion




// Unhandled exceptions in Methods

//try
//{
// If the exception is not handled it is propagated in Program.cs
//    UnhandledException();
//}
//catch (NullReferenceException ex)
//{
//    Console.WriteLine("Empty object!");
//    Console.WriteLine(ex.StackTrace);
//}
//catch(Exception ex)
//{
//    Console.WriteLine("An error occured!");
//}


HandledException();







void UnhandledException()
{
    User user = null;
    Console.WriteLine(user.Name);
}


void HandledException()
{
    Console.WriteLine("Enter HandledException()");
    try
	{
		int[] numbers = new int[] { 1, 2, 3, 4 };
        Console.WriteLine(numbers[4]);
    }
	catch (IndexOutOfRangeException ex)
	{
        Console.WriteLine("Index out of range!");
        Console.WriteLine(ex.StackTrace);
    }
    catch(Exception ex)
    {
        Console.WriteLine("An error occured");
        Console.WriteLine(ex.StackTrace);
    }
    finally
    {
        Console.WriteLine("End of HandledException()");
    }
}