// See https://aka.ms/new-console-template for more information
using SEDC.Class07.Enumerations;
using SEDC.Class07.Services;

Console.WriteLine("Hello, World!");

//DaysOfWeek monday = DaysOfWeek.Monday;
//int monday1 = 1;
//int dayOfWeek = 3;
//DaysOfWeek day = DaysOfWeek.Friday;

ReadService readService = new ReadService();
readService.ReadFromScreen();

Test test = new Test()
{
    Id = 1,
    Day = DayOfWeek.Sunday
};