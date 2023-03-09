namespace Classes
{
    public class Person
    {
        //we can access FirstName from anywhere, from Person's class methods, but also from Program.cs
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        
        
        //we can access _ssn only from Person class (its methods)
        private long _ssn { get; set; }

        //Constructor
        //Constructor is always public and has the name of the class
        //we need it in order to instantiate objects

        //Default constructor
        public Person()
        {
            _ssn = new Random().Next(100000, 999999);
        }

        public Person(string firstName, string lastName, int age, long ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            if(ssn >= 100000 && ssn <= 999999)
            {
                _ssn = ssn;
            }
            
        }

        public void PrintDetails()
        {
            Console.WriteLine($"FirstName: {FirstName} LastName: {LastName} Age: {Age}, SSN: {_ssn}");
        }

        //we can use this method to get the value of _ssn from outside
        public long GetSsn()
        {
            return _ssn;
        }

        //we can set the ssn from outside, but in a controlled way
        public void SetSsn(long ssn)
        {
            if (ssn >= 100000 && ssn <= 999999)
            {
                _ssn = ssn;
            }
            else
            {
                Console.WriteLine("Invalid ssn value");
            }
        }

        public void Says(string message)
        {
            Console.WriteLine($"{FirstName} {LastName} says {message}");
        }
    }
}
