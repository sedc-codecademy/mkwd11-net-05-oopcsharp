using Enums;

int day = 5;


//NOT CLEAR, NOT A GOOD PRACTICE
if(day == 5)
{
    Console.WriteLine("Yee it's Friday!");
}

if(day == (int)DaysOfWeek.Friday)
{
    Console.WriteLine("Yee it's Friday!");
}

string role = "";
if(role == "Admin")
{

}

if(role == "administrator")
{

}

if(role == Role.Admin.ToString()) //role == "Admin"
{

}
