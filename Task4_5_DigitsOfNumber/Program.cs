Console.Write("Введите трехзначное число: ");
string Number = Console.ReadLine();
int ABC = int.Parse(Number);
int C = ABC % 10;
int B = (ABC % 100 - ABC % 10) / 10;
// вариант без %:
//int A = ABC /100;
//A = A * 100;
//int B = (ABC - A)/10;
//int C = ABC - A - B*10;
Console.WriteLine ("Вторая цифра числа:" + B);
Console.WriteLine ("Третья цифра числа:" + C);
