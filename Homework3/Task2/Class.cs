class Complex
{
    double a;
    double b;

    public Complex ()
    {
        a = GetNubmer("Введите первое вещественное число a: ");
        b = GetNubmer("Введите второе вещественное число b: ");
    }
    public Complex (double a, double b)
    {
        this.a = a;
        this.b = b;
    }
    double GetNubmer(string text) // защита от дурака
    {
        double result;
        bool flag;
        do 
        {
            Console.WriteLine(text);
            flag = double.TryParse(Console.ReadLine(), out result); 
        }
        while (!flag);
        return result;
    }
    public static Complex Plus (Complex x, Complex y) // СУММА комплексных чисел
    {
        Complex complex = new (x.a + y.a, x.b + y.b);
        return complex;
    }
     public static Complex operator -(Complex x, Complex y) // РАЗНОСТЬ комплексных чисел
    {
        Complex complex = new (x.a - y.a, x.b - y.b);
        return complex;
    }
     public static Complex Multi (Complex x, Complex y) // ПРОИЗВЕДЕНИЕ комплексных чисел
    {
        Complex complex = new (x.a * y.a - x.b * y.b, x.b * y.a + x.a * y.b);
        return complex;
    }
    public double A // свойство
    {
        get {return a;} // чтение
        set {if (value >= 0) a = value;} // запись
    }
    public string Print ()
    {
        string s;
        if (b > 0) {s = $"{a}+{b}i";}
        else {s = $"{a}-{-b}i";};
        return s;
    }
}