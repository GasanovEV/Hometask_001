Console.Clear();
Console.Write ("Введите  число ");
string userInput1 = Console.ReadLine () ??"";
int number1 = int.Parse (userInput1);

int count = 1;

while (count<=number1)
{
    if(count % 2 == 0)
    Console.Write ($"{count} ");
    count = count + 1;
}
