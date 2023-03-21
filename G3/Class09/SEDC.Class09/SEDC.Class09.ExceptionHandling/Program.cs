// See https://aka.ms/new-console-template for more information
using SEDC.Class09.ExceptionHandling;
using System.Globalization;

Console.WriteLine("Hello, World!");


// unhandled exception
//string input = Console.ReadLine();
//int parsedNumber = int.Parse(input);

//try
//{
//    string input = Console.ReadLine();
//    // input = null; // simulate ArgumentNullException
//    int parsedNumber = int.Parse(input);
//}
//catch (ArgumentNullException ex)
//{
//    Console.WriteLine("Argument null exception");
//    Console.WriteLine(ex.Message);
//    // log this error in some loging file
//}
//catch(FormatException ex)
//{
//    Console.WriteLine("FormatException");
//    Console.WriteLine(ex.Message);
//    // log this error in some loging file
//}
//catch(OverflowException ex)
//{
//    Console.WriteLine("OverflowException");
//    Console.WriteLine(ex.Message);
//    // log this error in some loging file
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

List<Human> humans = new List<Human>()
{
    new Human { Name = "Trajan" },
    new Human { Name = "Dragan" },
    new Human(),
    null
};


Human GetHuman(List<Human> listOfHumans, string name)
{
    try
    {
        foreach(Human h in listOfHumans)
        {
            if(h.Name == name)
            {
                return h;
            }
        }
        return null;
    }
    catch(Exception ex)
    {
        // log exception
        throw ex;
    }
}

Human GetHumanDefensive(List<Human> listOfHumans, string name)
{
    if(listOfHumans.Count == 0)
    {
        return null;
    }

    if(string.IsNullOrWhiteSpace(name))
    {
        return null;
    }

    foreach(Human h in listOfHumans)
    {
        if(!string.IsNullOrWhiteSpace(h.Name))
        {
            if(h.Name == name)
            {
                return h;
            }
        }
    }

    return null;
}


//try
//{
//    Human human = GetHuman(humans, "Pero");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
Console.WriteLine("Everything went fine!");


//try
//{
//    // file is opening
//    string text = Console.ReadLine();

//    // simulate error
//    if (text == "asd")
//    {
//        throw new Exception("Simulating write to file exception!");
//    }
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    // file close
//    Console.WriteLine("Finaly is always executed");
//}

Human CreateHuman()
{
    Console.WriteLine("Enter human name");
    string humanName = Console.ReadLine();

    Human human = new Human() { Name = humanName };
    Console.WriteLine("Enter how many skills you have");

    try
    {
        string input = Console.ReadLine();
        int numberOfSkills = int.Parse(input);

        List<Skill> skillList = CreateHumanSkills(numberOfSkills);
        human.Skills = skillList;
    }
    catch(ArgumentNullException ex)
    {
        Console.WriteLine("Number of skills not a valid int");
        throw new HumanException("Number of skills not a valid int", 1);
    }
    catch(FormatException ex)
    {
        Console.WriteLine("Format is not valid");
        throw new HumanException("Format is not valid", 2);
    }
    catch(SkillException ex)
    {
        Console.WriteLine("Something went wrong while crwating skill");
        throw ex;
    }
    catch (Exception ex)
    {
        throw ex;
    }

    return human;
}

List<Skill> CreateHumanSkills(int numberOfSkills)
{
    List<Skill> list = new List<Skill>();
    for(int i = 0; i < numberOfSkills; i++)
    {
        try
        {
            Console.WriteLine("Skill name");
            string skillName = Console.ReadLine();
            Console.WriteLine("Skill points");
            string skillPoints = Console.ReadLine();
            int points = int.Parse(skillPoints);

            Skill skill = new Skill()
            {
                Name = skillName,
                Points = points
            };
            list.Add(skill);
        }
        catch(Exception ex)
        {
            throw new SkillException("Skill cannot be created");
        }
    }
    return list;
}

//try
//{
//    Human human = CreateHuman();
//    Console.WriteLine(human.Name);
//    foreach(Skill skill in human.Skills)
//    {
//        Console.WriteLine($"name: {skill.Name} points: {skill.Points}");
//    }
//}
//catch(HumanException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch(SkillException ex)
//{
//    Console.WriteLine(ex.Message);
//}


Parsers p = new Parsers();

int a = p.FromStringToIntTryParse();
Console.WriteLine($"Parsed number: {a}");

int b = p.FromStringToInt();
Console.WriteLine($"Parsed with exception handling: {b}");
