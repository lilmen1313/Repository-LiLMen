// ФИ: Асанов Илья
// Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.

void Complex ()
{
    Console.WriteLine("Первое комплексное число");
    Complex complex1 = new();
    Console.WriteLine("Второе комплексное число");
    Complex complex2 = new();
    
    Complex resultPlus = complex1.Plus(complex2);
    Console.WriteLine(resultPlus.Print ());

    Complex resultMinus = complex1.Minus(complex2);
    Console.WriteLine(resultMinus.Print ());

    Complex result = complex1.Multi(complex2);
    Console.WriteLine(result.Print ());
}

Complex ();









// double GetNubmer(string text)
// {
//     double result;
//     bool flag;
//     do 
//     {
//         Console.WriteLine(text);
//         flag = double.TryParse(Console.ReadLine(), out result); // защита от дурака
//     }
//     while (!flag);

//     return result;
// }


// double a = GetNubmer("Введи 1 ");
// double b = GetNubmer("Введи 2 ");
// double c = GetNubmer("Введи 3 ");
// double d = GetNubmer("Введи 4 ");





// bool flag = double.TryParse(Console.ReadLine(), out a); // защита от дурака
// Console.WriteLine(flag);
// Console.WriteLine(a);




// string GetStringNumbers (int k) // метод
// {
//     string result = String.Empty; // описание метода
//     for ( int i = 1; i <= k; i++)
//     {
//         result = result + $"{i}\n";
//     }
//     return result;
// }

// // string Yy = GetStringNumbers(); // вызов метода


// Console.WriteLine(GetStringNumbers(5));
// File.AppendAllText ("file.txt", GetStringNumbers(15));




// for ( int i = 1; i < 11; i++)
//     {
//         Console.WriteLine(i);
       
//     }

// for ( int i = 1; i < 11; i++)
//     {
//         File.AppendAllText ("file.txt", i);
//     }





