// ФИ: Асанов Илья
// 4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
// а) с использованием третьей переменной;
// б) *без использования третьей переменной.


Console.Write("Введите значение a (целое число): ");
string a1 = Console.ReadLine();
int a = Convert.ToInt32(a1);
Console.Write("Введите значение b (целое число): ");
string b1 = Console.ReadLine();
int b = Convert.ToInt32(b1);
int t = a;
a = b;
b = t;
Console.WriteLine($"Значение a = {a}");
Console.WriteLine($"Значение b = {b}");


// Console.Write("Введите значение a (целое число): ");
// string a1 = Console.ReadLine();
// int a = Convert.ToInt32(a1);
// Console.Write("Введите значение b (целое число): ");
// string b1 = Console.ReadLine();
// int b = Convert.ToInt32(b1);
// a = a + b;
// b = a - b;
// a = a - b;
// Console.WriteLine($"Значение a = {a}");
// Console.WriteLine($"Значение b = {b}");


// Console.Write("Введите значение a (целое число): ");
// string a1 = Console.ReadLine();
// int a = Convert.ToInt32(a1);
// Console.Write("Введите значение b (целое число): ");
// string b1 = Console.ReadLine();
// int b = Convert.ToInt32(b1);
// (a, b) = (b, a);
// Console.WriteLine($"Значение a = {a}");
// Console.WriteLine($"Значение b = {b}");
