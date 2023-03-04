double firstDouble = 5;
double secondDouble = 9;

double doubleResult = firstDouble / secondDouble;
Console.WriteLine("doubleResult: " + doubleResult);

//When we divide two whole numbers, the result is the whole of the division
int firstInt = 5;
int secondInt = 9;
int intResult = firstInt / secondInt;
Console.WriteLine("intResult: " + intResult);

double doubleIntResult =  firstInt / secondInt;
Console.WriteLine("doubleIntResult: " + doubleIntResult);

//When we divide a whole number and a decimal number, the result is a decimal number
double differentTypesResult = firstDouble / secondInt;
Console.WriteLine("differentTypesResult: " + differentTypesResult);


//EXTRA - casting
//double doubleIntResult =  (double)firstInt / secondInt;
