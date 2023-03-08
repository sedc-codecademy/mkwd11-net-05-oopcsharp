namespace SEDC.Class5.OOP.Classes
{
    // We cannot instantiate(create) objects out of static classes, we use static classes directly
    // Static classes can only hold static members (properties and methods)
    // If we want to invoke Separator we need to invoke it directly on the class => ex. ConsoleHelper.Separator()
    public static class ConsoleHelper
    {
        
        public static void Separator()
        {
            Console.WriteLine();
            Console.WriteLine("=============================");
            Console.WriteLine();
        }
    }
}
