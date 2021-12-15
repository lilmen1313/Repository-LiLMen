// ФИ: Асанов Илья
// 5.
// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
// б) Сделать задание, только вывод организовать в центре экрана.
// в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).


//         static void Print(string msg, int x, int y)
//         {
//             // Установим позицию курсора на экране
//             Console.SetCursorPosition(x, y);
//             Console.WriteLine(msg);
//         }
// Print ("ВАЙ ВАЙ КАРАВАЙ", 87, 0);



        // static void Print(string msg, ConsoleColor foregroundcolor)
        // {
        //     // Установим цвет символов
        //     Console.ForegroundColor = foregroundcolor;
        //     Console.WriteLine(msg);
        // }


           // Создайте перегрузку функции, в которой будет указана позиция и цвет
        static void Main()
        {
           Print("Привет!\n", 10,10);
           Print("Привет еще раз!", ConsoleColor.Red);
          Console.ReadLine();
        }
Main();