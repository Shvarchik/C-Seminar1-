Console.Write("Введите трехзначное число: ");
string Number = Console.ReadLine();
int ABC = int.Parse(Number);
  //int C = ABC % 10;
  //int A = (ABC / 100) * 100;
  //int AC = A + C;
int AC = ABC / 100 * 100 + ABC % 10;
Console.WriteLine ("Без второй цифры это число:" + AC);
