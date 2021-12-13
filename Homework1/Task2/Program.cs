// ФИ: Асанов Илья
// 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) 
//по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

Console.Write("Введите свой вес в кг: ");
string m = Console.ReadLine();
double m1 = Convert.ToDouble(m);
Console.Write("Введите свой рост в м: ");
string h = Console.ReadLine();
double h1 = Convert.ToDouble(h);
double imt = m1/(h1*h1);
Console.WriteLine("Индекс массы тела: {0:F3}", imt);
