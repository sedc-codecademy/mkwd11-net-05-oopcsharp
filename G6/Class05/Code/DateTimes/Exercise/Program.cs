Console.WriteLine(DateTime.Now.AddDays(3));
Console.WriteLine(DateTime.Now.AddMonths(1).AddDays(3));
Console.WriteLine(DateTime.Now.AddYears(-1).AddMonths(-2));

Console.WriteLine(string.Format("{0:MMMM}", DateTime.Now));
Console.WriteLine(string.Format("{0:yyyy}", DateTime.Now));