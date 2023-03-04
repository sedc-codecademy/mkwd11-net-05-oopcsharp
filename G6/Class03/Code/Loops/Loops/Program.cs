for(int i = 0; i < 10; i++)
{
    Console.WriteLine("i: " + i);
}

// Loops indefinetly unless a condition in the block is met
for (; ; )
{
    Console.WriteLine("Another iteration");
    Console.WriteLine("Enter x to exit the loop");
    //input is block scoped
    string input = Console.ReadLine();

    if (input == "x" || input == "X")
        break;
}

//Print all numbers from 1 to 10 (in fact 1 - 7 because of the break)
//if 5, skip printing
//if 7 exit the loop

for(int i = 1; i <= 10; i++)
{
    if (i == 5)
        continue;

    Console.WriteLine("i: " + i);

    if (i == 7)
        break;

}


//While loop
Console.WriteLine("=====While loops======");
int counter = 1;

while(counter <= 5)
{
    Console.WriteLine("counter: " + counter);
    counter++;
}

//Infinite while loop
while (true)
{
    Console.WriteLine("We will loop until you enter x");
    //input is block scoped
    string input = Console.ReadLine();

    if (input == "x" || input == "X")
        break;
}

//use while, count 1 -10, skip 3 and 5
int number = 1;
while(number <= 10)
{
    if(number == 3 || number == 5)
    {
        //careful, put the code that moves forward before continue so we don't get an infinite loop
        number++;
        continue;
    }

    Console.WriteLine("number: " + number);
    number++;
}

//do while
do
{
    Console.WriteLine("This will executed at least once");
}
while (false);


