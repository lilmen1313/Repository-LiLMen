
struct Complex
{
    public double a; // инициализируем вещественную составляющую
    public double b; // инициализируем вещественную составляющую
    
        public Complex () // конструктор
        {
            Console.WriteLine("Введите первое вещественное число a: ");
            double re = Convert.ToDouble(Console.ReadLine());
            a = re;
            Console.WriteLine("Введите второе вещественное число b: ");
            double im = Convert.ToDouble(Console.ReadLine());
            b = im;
        }
        public Complex Plus (Complex x) // метод реализующий сумму комплексных чисел
        {
        Complex y;
        y.a = a + x.a;    // y = new Complex (x1.a + x2.a, x1.b + x2.b); через конструктор
        y.b = b + x.b;
        return y;
        }
        public Complex Minus (Complex x) // метод реализующий разность комплексных чисел
        {
        Complex y;
        y.a = a - x.a;    // y = new Complex (x1.a - x2.a, x1.b - x2.b); через конструктор
        y.b = b - x.b;
        return y;
        }
        public Complex Multi (Complex x) // метод реализующий произведение комплексных чисел 
        {
        Complex y;
        y.a = a * x.a - b * x.b;
        y.b = b * x.a + a * x.b;
        return y;
        }
        public string Print () // вывод результата операций над комплексными числами
        {                       // public override string ToString()
        string s;
        if (b < 0)
        {s = $"{a}-{-b}i";}
        else {s = $"{a}+{b}i";};
        return s;
        }
}

