using Exceptions;

try
{
    Console.WriteLine("Enter a number");
    string input = Console.ReadLine();

    int number = int.Parse(input);

    //This line will be executed only if the lines above don't throw an Exception
    //Otherwise ww will be redirected to the catch block
    Console.WriteLine($"You entered {number}");
}
catch (Exception e)
{
    //write to file the message
    //write the StackTrace to file
    Console.WriteLine("error");
}
finally
{
    Console.WriteLine("This message will be written anyway!");
}

Console.WriteLine("This will be executed always");



//Throwing an exception
try
{
    Console.WriteLine("Enter a or b");
    string character = Console.ReadLine();

    if (character.ToLower() == "a" || character.ToLower() == "b")
    {
        Console.WriteLine("Correct input");
    }
    else
    {
        throw new Exception("User didn't enter a or b");
    }
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

//Only one catch block can be executed!
//We have specific catch blocks, that catch only certain types of Exceptions (FormatException, OverflowException..)
//We have a general exception Exception catch block, that will catch the rest of the Exceptions
Console.WriteLine("Handling specific exceptions");
try
{
    Console.WriteLine("Enter number");
    string inputNumber = Console.ReadLine();

    int num = int.Parse(inputNumber);

    //NULLREFERENCE EXCEPTION, WILL BE CAUGHT FROM THE LAST CATCH BLOCK !!!!
    //string test = null;
    //Console.WriteLine(test.Length);
}
catch (OverflowException e)
{
    Console.WriteLine("We have more data than what could fit in an int");
}
catch(FormatException e)
{
    Console.WriteLine("Invalid input");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


//Methods and handling exceptions


void PrintSkills(Human human)
{
    foreach(Skill skill in human.Skills)
    {
        Console.WriteLine(skill.Name);
    }
}

//FIRST OPTION - CALL TO METHOD TO BE IN A TRY-CATCH
try
{
    //PrintSkills(null);
    //PrintSkills(new Human { Name = "Bob" });

    Console.WriteLine("Test message");
}
catch (Exception e)
{
    Console.WriteLine("We are here because PrintSkills threw an exception");
}


//SECOND OPTION - Handle exceptions in the method

//This method won't propagate exception to the outside (to the line where it was called)
void PrintHumanSkills(Human human)
{
    try
    {
        foreach (Skill skill in human.Skills)
        {
            Console.WriteLine(skill.Name);
        }
    }
    catch(NullReferenceException e)
    {
        Console.WriteLine("Human or human.Skills was null");
    }
    catch(Exception e)
    {
        Console.WriteLine("An error occurred");
    }
}

PrintHumanSkills(new Human { Name = "Bob" });

Console.WriteLine("This will be executed. We are protected from exceptions :)");

