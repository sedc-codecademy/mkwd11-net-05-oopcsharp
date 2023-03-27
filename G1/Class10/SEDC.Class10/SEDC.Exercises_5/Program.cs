
int CalculateNumberOfLegs(int chickenLegs, int cowLegs, int pigLegs)
{
    return chickenLegs * 2 + cowLegs * 4 + pigLegs * 4;
}


try
{
    Console.WriteLine("Please enter number of chichkens");
    int chichkenLegs = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter number of cows ");
    int cowLegs = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter number of pigs");
    int pigLegs = int.Parse(Console.ReadLine());

    Console.WriteLine(CalculateNumberOfLegs(chichkenLegs, cowLegs, pigLegs));
}
catch (Exception ex)
{
    Console.WriteLine("Error occured! Please try again");
}