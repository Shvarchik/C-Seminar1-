Console.Write("Введите первое число:");
string number1 = Console.ReadLine();
int num1 = int.Parse(number1);
Console.Write("Введите второе число:");
string number2 = Console.ReadLine();
int num2 = int.Parse(number2);
if (num1 == num2 * num2)
{
    Console.WriteLine ("первое число - квадрат второго");
}
else
{
   Console.WriteLine ("первое число не является квадратом второго");
}
