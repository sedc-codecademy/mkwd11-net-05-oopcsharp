//Unhandeled exceptions
//I exapme divide by zero
//Console.WriteLine("Enter the first numer");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the second number");
//int number2 = Convert.ToInt32(Console.ReadLine());
//int result = number1 / number2;

using System.Security.Cryptography.X509Certificates;

//try
//{

//    Console.WriteLine("Enter the first number");
//    int number1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Enter the second number");
//    int number2 = Convert.ToInt32(Console.ReadLine());
//    int result = number1 / number2;
//    Console.WriteLine($"The result is: {result}");
//}

////catch {

////    Console.WriteLine("An error happend: Please contact the support team");
////}


////We can use more than one exception!!!!!
////Using system class exception
////catch (Exception ex) 
////{
////    Console.WriteLine("An error happend: Please contact the support team");
////    Console.WriteLine("An error occured: " + ex.Message);
////    Console.WriteLine(ex.StackTrace);
////}


////Specific exception divide by zero
//catch (DivideByZeroException ex)
//{

//    Console.WriteLine("An error happend: Please contact the support team");
//    Console.WriteLine("Divide error occured: " + ex.Message);
//    Console.WriteLine(ex.StackTrace);

//}

////Specific exception - > Invalid format
//catch (FormatException ex)
//{
//    Console.WriteLine("An error happend: Please contact the support team");
//    Console.WriteLine("Format error occured: " + ex.Message);
//    Console.WriteLine(ex.StackTrace);

//}
//catch (Exception ex)
//{
//    Console.WriteLine("An error happend: Please contact the support team");
//    Console.WriteLine("An error occured: " + ex.Message);
//    Console.WriteLine(ex.StackTrace);
//}

//finally
//{
//    Console.WriteLine("Thank you for inserting the numbers, have a great day");

//}


//II example with array

//try
//{
//    string[] colors = { "Red", "Blue", "Green" };
//    Console.WriteLine(colors[4]);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//    Console.WriteLine(ex.StackTrace);

//}
//finally
//{
//    Console.WriteLine("Thank you");
//}


//Custom Exception
//try {

//    Console.WriteLine("Please insert number between 1 and 5");
//    int num = Convert.ToInt32(Console.ReadLine());

//    if (num > 0 && num < 6)
//    {

//        Console.WriteLine("You entered the number :" + num);
//    }

//    else

//    {
//        throw new Exception("Oops, you entered invalid number, please be carefull");
//    }

//}

//catch(Exception ex) {

//    Console.WriteLine("Custom exception happend " + ex.Message);
//}

//finally {

//    Console.WriteLine("Press enter to exit");
//    Console.ReadLine();
//}


////Method with handeled exception
//void AccessWithAge (int age)
//{
//    try
//    {
//        if (age > 18)
//        {
//            Console.WriteLine("Access approved");
//        }
//        else
//        {
//            throw new Exception("You don't have access, you need to be above 18");
//        }

//    }

//    catch (Exception ex)
//    {

//        Console.WriteLine("Error happend: " + ex.Message);
//        Console.WriteLine(ex.StackTrace);
//    }

//    finally
//    {

//        Console.WriteLine("Press enter to exit");
//        Console.ReadLine();
//    }

//}

//Console.WriteLine("Please enter your age");
//int UserAge = Convert.ToInt32(Console.ReadLine());
//AccessWithAge(UserAge);


//Excercise calculator
void Calculator()
{

    try
    {
        Console.WriteLine("Please insert one number");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please insert second number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please insert operation : + , -, / , *");
        char operant = Convert.ToChar(Console.ReadLine());

        int result = 0;

        switch (operant)
        {

            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                //.WriteLine("Invalid operand");
                throw new Exception("Invalid operand");
                break;

        }
        Console.WriteLine("The result is:" + result);
    }

    catch (FormatException ex)
    {
        Console.WriteLine("Format error : " + ex.Message);
        Console.WriteLine(ex.StackTrace);
    }

    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Divide error : " + ex.Message);
        Console.WriteLine(ex.StackTrace);

    }

    catch (Exception ex)
    {
        Console.WriteLine("Exception happend: " + ex.Message);
        Console.WriteLine(ex.StackTrace);
    }

    finally
    {
        Console.WriteLine("Thank you, have a great day");

    }

}

Calculator();

//Unhandled exception

//void UnhandeledException()
//{
//    string[] color = { "Red", "Blue", "Yellow" };
//    Console.WriteLine(color[4]);

//}

////UnhandeledException();

//try {
//    UnhandeledException();
//}

//catch (Exception ex) {


//    Console.WriteLine("Error: " + ex.Message);
//    Console.WriteLine(ex.StackTrace);
//}

//finally {
//    Console.WriteLine("Have a nice day");

//}