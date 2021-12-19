// ФИ: Асанов Илья
// 2. Написать метод подсчета количества цифр числа.

void Schetchiik ()
{
Console.Write("Введите целое число и узнаете количество цифр в нем: a = "); // как сделать код и для рациональных?? попытка 
// разбивки строки на символы и подсчет этих символов.
int a = Convert.ToInt32(Console.ReadLine());
int ch = 1;
int chh = 1;
while (a != 0)
{
chh = ch++;
a = a / 10;
}
Console.Write($"Количество цифр в числе a = {chh}");
};

Schetchiik ();

// Console.Write("Введите число и узнаете количество цифр в нем: a = ");
// string a = Console.ReadLine();
//  char[] c = a.ToCharArray();
// // bool ver;
// Console.Write($"Количество цифр в числе a = {c}");