// ФИ: Асанов Илья
// 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

void App ()
{
int a = 0; int sum = 0; string output = String.Empty;
do
{
    Console.Write("Введите число (кроме нуля) и узнаете сумму всех нечетных положительных чисел: ");
    va = Convert.ToInt32(Console.ReadLine());
    for (int i = a; i > 0 & i % 2 != 0; i++)
        {
            Console.WriteLine($"Нечетное положительное число: {i}");
            sum = sum + i;
            string ss = Convert.ToString (i);
            output += "+" + ss;
        }
} while (a != 0);

    Console.WriteLine($"Увы, но вы ввели 0, теперь программа посчитает\nсумму всех нечетных положительных чисел, которые вы ввели {output} = {sum}");
}

App ();