string[] Week = {"понедельник", "вторник","среда", "четверг", "пятница", "суббота", "воскресенье"};
Console.Write("Введите номер дня недели:");
string number = Console.ReadLine();
int num = int.Parse(number);
Console.WriteLine (num + "-й день недели - " + Week[num-1]);
