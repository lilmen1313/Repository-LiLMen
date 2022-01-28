// ФИ: Асанов Илья
// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
// в) Добавить диалог с использованием switch демонстрирующий работу класса.

class Program
{
    static void Main ()
    {
        Console.WriteLine("Первое комплексное число");
        Complex complex1 = new Complex ();
            
        Console.WriteLine("Второе комплексное число");
        Complex complex2 = new Complex ();
        
        Console.WriteLine(complex1.Print ());
        Console.WriteLine(complex2.Print ());

        // complex1.A = 34;
        // Console.WriteLine(complex1.Print ());

        Complex resultPlus = Complex.Plus(complex1, complex2);
        Complex resultMinus = complex1 - complex2;
        Complex resultMulti = Complex.Multi(complex1, complex2);

        Console.WriteLine("Введите название операции над комплексными числами, которое хотите выполнить (сумма, разность, произведение)");
        string text = Console.ReadLine ();
        
        switch (text)
        {
            case "сумма": Console.WriteLine(resultPlus.Print ());
            break;

            case "разность": Console.WriteLine(resultMinus.Print ());
            break;

            case "произведение": Console.WriteLine(resultMulti.Print ());
            break;

            default: Console.WriteLine("Ничего не выбрано");
            break;
        }
    }
}