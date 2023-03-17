using Exercise1;

Human inputHuman = new Human();
Console.WriteLine("Enter the first name");
inputHuman.FirstName = Console.ReadLine();
Console.WriteLine("Enter the last name");
inputHuman.LastName = Console.ReadLine();
Console.WriteLine("Enter the age");
inputHuman.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(inputHuman.GetStats());


