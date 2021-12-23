Console.Write("Введите число: ");
string Number = Console.ReadLine();
int num = int.Parse(Number);
if ((num < 100) && (num > -100))
{
    Console.WriteLine("У этого числа нет третьей цифры");
}
else 
{
if (num < 0) num = -1 * num;
int num1 = (num - num % 100) / 100;
int ThirdDigit = num1 % 10;
Console.WriteLine("Третья цифра числа {0} ", ThirdDigit);
}

