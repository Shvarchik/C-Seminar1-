int AB = new Random().Next(10, 100);
Console.WriteLine("Выбрано число " + AB);
int B = AB % 10;
int A = AB / 10;
if (A > B)
{
  Console.WriteLine ("Наибольшая цифра числа " + A);
}
else
{
   Console.WriteLine ("Наибольшая цифра числа " + B);
}
