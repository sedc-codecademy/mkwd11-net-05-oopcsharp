int applesPerBranch = 8;
int applesInBasket = 5;
int numberOfBranchesPerTree = 12;

Console.WriteLine("Please enter number of trees");
string input = Console.ReadLine();

int numberOfTrees;

bool success = int.TryParse(input, out numberOfTrees);

int result;

if (success)
{
    int numberOfApples = numberOfTrees * numberOfBranchesPerTree * applesPerBranch;
    Console.WriteLine("Number of apples:" + numberOfApples);

    if(numberOfApples % applesInBasket == 0)
    {
        result = numberOfApples / applesInBasket;
    }
    else
    {
        result = numberOfApples / applesInBasket + 1;
    }

    Console.WriteLine("You need " + result + " baskets.");
}
else
{
    Console.WriteLine("Invalid input");
}