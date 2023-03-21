using SEDC.Class09.Exception.Classes;

#region Method Exception
//Exception handling inside a method
void humanSkill(Human human)
{
    try
    {
        foreach(var item in human.SkillList)
        {
            Console.WriteLine(item.Name);
        }
    }
    // Generic exception. All information are kept in ex variable so we can access them
    catch (Exception ex)
    {
        Console.WriteLine("Catch inside the method: " + ex.Message);
    }
    finally
    {
        Console.WriteLine("Press any key to exit from this method");
        Console.ReadLine();
    }
}

//When we don't have try/catch in the method then the exception will be caught outside
void humanSkillTwo(Human human)
{
    foreach (var item in human.SkillList)
    {
        Console.WriteLine(item.Name);
    }
}

// Selective exception handling
void humanSkillThree(Human human)
{
    // This only catches 2 types of exception. All other exceptions will go to the Expection catch if there is any
    try
    {
        Console.WriteLine("Enter a number:");
        int number = Int32.Parse(Console.ReadLine());
        foreach (var item in human.SkillList)
        {
            Console.WriteLine(item.Name);
        }
    }
    // This will fire only when the exception is OverflowException
    catch (OverflowException)
    {
        Console.WriteLine("Inside the method - Broke the memory");
    }
    //A NullReferenceException exception is thrown when you try to access a member on a type whose value is null.
    catch (NullReferenceException) {
        Console.WriteLine("Inside the method - Null reference");
    }
    // Generic exception
    catch (Exception ex)
    {
        Console.WriteLine("Catch inside the method: " + ex.Message);
    }
}

// Catching exceptions from inside of a function
try
{
    humanSkill(new Human() { FullName = "angel mitrov", SkillList = null });
    humanSkillTwo(new Human() { FullName = "dimitar milkovski", SkillList = null });
    humanSkillThree(new Human() { FullName = "mice karajov", SkillList = null });
}
// Generic exception. All information are kept in ex variable so we can access them
catch (Exception ex)
{
    Console.WriteLine("Catch outside the method: " + ex.Message);
}
#endregion

#region Exceptions
// Exceptions 
Console.WriteLine("Enter the characters a or b: ");

try
{
    string characters = Console.ReadLine().ToLower();
    if (characters == "a" || characters == "b")
    {
        Console.WriteLine("You have entered a or b!");
    }
    else
    {
        // Custom Exception ( Exception with our own logic ), we create new Excetion 
        // If this is not inside a try/catch it will break the application like any other exception
        throw new Exception("You must enterd a or b!");
        //Console.WriteLine("You must enterd a or b!");
    }

    //switch (characters)
    //{
    //    case "a":
    //        Console.WriteLine("You have entered a");
    //        break;
    //    case "b":
    //        Console.WriteLine("You have entered b!");
    //        break;
    //    default:
    //        throw new Exception("You must enterd a or b!");
    //}

}
// Generic exception. All information are kept in ex variable so we can access them
catch (Exception ex)
{
    // Message from Expection
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Press any key");
    Console.ReadLine();
}

Console.WriteLine("============");
try
{
    Console.WriteLine("Enter some character");
    char character1 = char.Parse(Console.ReadLine());
    Console.WriteLine("You enter a charachter: " + character1);
    Console.WriteLine("Enter a number");
    int num = Int32.Parse(Console.ReadLine());
    Console.WriteLine("You enter a integer: " + num);

}
catch (OverflowException ov)
{
    Console.WriteLine("Broke the memory!" + ov.Message);
}
catch (FormatException fo)
{
    Console.WriteLine("You have enterd wrong character" + fo.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    // This is an innerException message ( More details on the problem ) 
    //It is rarely used
    //Console.WriteLine("More info: " + ex.InnerException.Message);
}

#endregion