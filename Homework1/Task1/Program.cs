// ФИ: Асанов Илья
// 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
// В результате вся информация выводится в одну строчку:
// а) используя склеивание;
// б) используя форматированный вывод;
// в) используя вывод со знаком $.

Console.WriteLine("Анкета");
Console.Write("Введите ваше имя: ");
string Name = Console.ReadLine();
Console.Write("Введите вашу фамилию: ");
string Surname = Console.ReadLine();
Console.Write("Введите ваш возраст: ");
string Age = Console.ReadLine();
Console.Write("Введите ваш рост (см): ");
string Growth = Console.ReadLine();
Console.Write("Введите ваш вес (кг): ");
string Weight = Console.ReadLine();
string h = Name + "; " + Surname + "; " + Age + "; " + Growth + "; " + Weight + "."; // склеивание
Console.WriteLine ("Результат: {0}", h);
string k = String.Format("{0}; {1}; {2}; {3}; {4}.", Name, Surname, Age, Growth, Weight); //явно форматированный вывод
Console.WriteLine ("Результат: {0}", k);
string l = String.Format($"{Name}, {Surname}, {Age}, {Growth}, {Weight}."); //вывод с использованием интерполяции ($)
Console.WriteLine ("Результат: {0}", l);
