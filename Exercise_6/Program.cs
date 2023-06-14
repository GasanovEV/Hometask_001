Console.Clear();
Console.Write ("Введите  число ");
string userInput1 = Console.ReadLine () ??"";
int number1 = int.Parse (userInput1);

if (number1 % 2 == 0)
{
    Console.Write ($"Число {number1} является четным ");
}
else
{
   Console.Write ($"Число {number1} является НЕчетным "); 
}