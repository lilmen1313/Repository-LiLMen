﻿// ФИ: Асанов Илья
// 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

void App ()
{
int a = 0;
int sum = 0;
do
{
    Console.Write("Введите число (кроме нуля) и узнаете сумму всех нечетных положительных чисел: ");
    a = Convert.ToInt32(Console.ReadLine());
    for (int i = a; i > 0 & i % 2 != 0; i++)
        {
            Console.WriteLine($"Нечетное положительное число: {i}");
            sum = sum + i;
        }
} while (a != 0);

Console.Write($"Увы, но вы ввели 0, теперь программа посчитает\nсумму всех нечетных положительных чисел, которые вы ввели: {sum}");
}

App ();