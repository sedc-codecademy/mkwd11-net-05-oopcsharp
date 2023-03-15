namespace Class05_Exercise01
{
    internal class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetPersonStats()
        {
            return $"{FirstName} {LastName} ({Age})";
        }
    }
}
