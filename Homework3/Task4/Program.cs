// See https://aka.ms/new-console-template for more information


double a, b, c, min, min1;
Console.Write("Введите число а = ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b = ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число c = ");
c = Convert.ToDouble(Console.ReadLine());
if (a < b)
{
    min1 = a;
}
else
{
    min1 = b;
};
if (c < min1)
{
    min = c;
}
else
{
    min = min1;
};
Console.Write("Наименьшее число = {0}", min);

