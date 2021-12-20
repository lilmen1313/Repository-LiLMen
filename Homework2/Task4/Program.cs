// ФИ: Асанов Илья
// 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
// На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
// программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.

void LogPass ()
{
        string log;  
        int i;
            
        for (i = 0; i < 3; i++)
        {
            Console.Write ("Введите логин: ");
            log = Console.ReadLine ();
            if (Convert.ToBoolean (log != "root"))
            {
            i++
            
            }
            else {Console.WriteLine($"Введен верный логин: {log}");} break;};
        } 
        

                
        
            if (Convert.ToBoolean (log != "root"))
            {
                Console.WriteLine ($"Было выполнено {i} попытки ввода неверного логина,\nаккаунт временно заморожен, обратитесь в службу поддержки :)");
                Console.ReadKey();
            }

            string pass;
            int j = 0;
            do
        {   
            Console.WriteLine ("Введите пароль: ");
            pass = Console.ReadLine ();
            if (Convert.ToBoolean (pass != "GeekBrains"))
            {
            j++;
            }
            else {Console.WriteLine($"Введен верный пароль: {pass}");};
            
        } while (j < 3);

            if (Convert.ToBoolean (pass != "GeekBrains"))
            {
                Console.WriteLine ($"Было выполнено {j} попытки ввода неверного пароля,\nаккаунт временно заморожен, обратитесь в службу поддержки :)");
                Console.ReadKey();
            }
            // Console.WriteLine ($"Введены верные логин ({log}) и пароль ({pass})!");
}

LogPass ();