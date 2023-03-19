namespace SEDC.Class08.Domain
{
    public class Dog
    {
        public Dog(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public List<string> FavouriteFoods { get; set; } = new List<string>();
    }
}
