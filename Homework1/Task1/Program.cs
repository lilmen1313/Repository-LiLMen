// 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
// В результате вся информация выводится в одну строчку:
// а) используя склеивание;
// б) используя форматированный вывод;
// в) используя вывод со знаком $.

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

string h = Name + "; " + Surname + "; " + Age + "; " + Growth + "; " + Weight;
Console.WriteLine ("Результат: {0}", h);




// Console.Write ("{0}, {1}, {2}, {3}, {4}", Name, Surname, Age, Growth, Weight);


// string s="string";
// string str=s[0].ToString()+s[1]+s[2]+s[5];
// Console.WriteLine(str);



// double j=156.555555555;
// double h=156.555555555;
// double d=
// Console.WriteLine("{0:F3}", j);
