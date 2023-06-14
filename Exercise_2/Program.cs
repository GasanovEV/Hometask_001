Console.Clear();
Console.Write ("Введите первое число ");
string userInput1 = Console.ReadLine () ??"";
int number1 = int.Parse (userInput1);
Console.Write ("Введите второе число ");
string userInput2 = Console.ReadLine () ??"";
int number2 = int.Parse (userInput2);

if (number1 == number2)
{
    Console.WriteLine ($" !!! Число {number1} равно числу {number2}!!!");
}
    if (number1>number2)
    {
        Console.WriteLine ($"!!! Максимальное число -> {number1}!!!");
    }
    else 
    {
            Console.WriteLine ($"!!! Максимальное число -> {number1}!!!");
    }
