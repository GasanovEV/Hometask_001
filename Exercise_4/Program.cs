Console.Clear();
Console.Write ("Введите первое число ");
string userInput1 = Console.ReadLine () ??"";
int number1 = int.Parse (userInput1);
Console.Write ("Введите второе число ");
string userInput2 = Console.ReadLine () ??"";
int number2 = int.Parse (userInput2);
Console.Write ("Введите третье число ");
string userInput3 = Console.ReadLine () ??"";
int number3 = int.Parse (userInput3);

int max = number1;



if (number2 > max) max = number2;
if (number3 > max) max = number3;
         
Console.WriteLine ($" Максимальное число -> {max}");

