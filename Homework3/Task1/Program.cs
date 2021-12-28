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