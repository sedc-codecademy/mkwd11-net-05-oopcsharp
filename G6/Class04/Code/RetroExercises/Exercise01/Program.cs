int[] ourArray = new int[5];

for(int i=0; i < ourArray.Length; i++)
{
    Console.WriteLine("Enter value for index: " + i);
    //string input = Console.ReadLine();
    //int number = int.Parse(input);

    int number = int.Parse(Console.ReadLine());
    ourArray[i] = number;
}


int sum = 0;
foreach(int num in ourArray)
{
    sum += num;
}

Console.WriteLine("The sum is: " + sum);