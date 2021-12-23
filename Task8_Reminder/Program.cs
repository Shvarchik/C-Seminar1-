Console.Write("Введите первое число:");
string Number1 = Console.ReadLine();
int num1 = int.Parse(Number1);
Console.Write("Введите второе число:");
string Number2 = Console.ReadLine();
int num2 = int.Parse(Number2);
if (num1 % num2 == 0)
{
    Console.WriteLine ("{0} кратно {1}", num1, num2);
}
else
{
    Console.WriteLine("{0} не кратно {1}, остаток от деления {2}", num1, num2, num1 % num2);
}