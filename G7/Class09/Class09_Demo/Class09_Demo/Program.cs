namespace Class09_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> names = new List<string> { "Risto", "Tijana", "Marko", "Ana", "Jesus", "Marko" };

                string sixthElement = names[8];

                string nameWithMoreThan8Char = names.First(x => x.Length > 8);
            }
            //catch blocks (exceptions) are orders in a way so the specific ones are first, and the global one comes last
            catch (ArgumentOutOfRangeException exception)
            {
                //send email notifcation the dev team
                Console.WriteLine("Please reach sales team");
            }
            catch (InvalidOperationException ex)
            {
                //send email notifcation the dev team
                Console.WriteLine("Please contact IT.");
            }
            catch (Exception ex)
            {
                //send email notifcation the dev team
                Console.WriteLine("Something went wrong... Please try again later");
            }
            finally
            {
                Console.WriteLine("Thank you for using our app.");
            }

        }
    }
}