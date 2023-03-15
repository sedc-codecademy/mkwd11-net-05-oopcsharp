using Exercise04.ATM.ConsoleApp.Classes;

Customer[] database = new Customer[]
{
    new Customer("Angel", "Mitrov", new Card(1234123412341234, 100)),
    new Customer("John", "Doe", new Card(4321432143214321, 1000)),
};


foreach (Customer customer in database)
{
    customer.GetCustomerInfo();
}