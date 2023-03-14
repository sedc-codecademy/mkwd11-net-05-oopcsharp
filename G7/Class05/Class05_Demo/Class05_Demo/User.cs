namespace Class05_Demo
{
    //class User
    //{
    //    string FirstName { get; set; }
    //    string LastName { get; set; }
    //    DateTime DateOfBirth { get; set; }

    //    string GetFullName()
    //    {
    //        return $"{FirstName} {LastName}";
    //    }
    //}

    internal class User
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        //default constructor => if none constructor is presented in code, the default one comes out of the box and it is provided by the C#
        //User() 
        //{ 
        //}

        private string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
