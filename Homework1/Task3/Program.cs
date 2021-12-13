// 3.
// а) Написать программу, которая подсчитывает расстояние между точками с координатами 
// x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, 
// используя спецификатор формата .2f (с двумя знаками после запятой);
// б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

// Console.Write("Введите координату х1: ");
// string x0 = Console.ReadLine();
// double x1 = Convert.ToDouble(x0);
// Console.Write("Введите координату y1: ");
// string y0 = Console.ReadLine();
// double y1 = Convert.ToDouble(y0);
// Console.Write("Введите координату х2: ");
// string x00 = Console.ReadLine();
// double x2 = Convert.ToDouble(x00);
// Console.Write("Введите координату y2: ");
// string y00 = Console.ReadLine();
// double y2 = Convert.ToDouble(y00);
// double ab = Math.Sqrt(Math.Pow(x2 - x1, 2)+Math.Pow(y2 - y1, 2));
// Console.Write($"Расстояние между точками равно = {ab:F2}");

void Ab () // метод 
{
Console.Write("Введите координату х1: ");
string x0 = Console.ReadLine();
double x1 = Convert.ToDouble(x0);
Console.Write("Введите координату y1: ");
string y0 = Console.ReadLine();
double y1 = Convert.ToDouble(y0);
Console.Write("Введите координату х2: ");
string x00 = Console.ReadLine();
double x2 = Convert.ToDouble(x00);
Console.Write("Введите координату y2: ");
string y00 = Console.ReadLine();
double y2 = Convert.ToDouble(y00);
double ab = Math.Sqrt(Math.Pow(x2 - x1, 2)+Math.Pow(y2 - y1, 2));
Console.Write($"Расстояние между точками равно = {ab:F2}");
}
Ab ();