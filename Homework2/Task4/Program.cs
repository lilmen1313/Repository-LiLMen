// ФИ: Асанов Илья
// 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
// На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
// программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.

void LogPass ()
{
    #region // блок ввода и проверки логина
    int i;
    string log = "Привет";
    string text1 = "неверных попыток ввода";

    for (i = 0; i < 3; i++)
    {
        Console.Write("Введите логин: ");
        log = Console.ReadLine();

        if (Convert.ToBoolean(log == "root"))
        {break;}
        else 
        {
            if (Convert.ToBoolean(log != "root"))
            {i = i++;}
            else {Console.WriteLine($"Введен верный логин: {log}");};
        }
    }

    if (Convert.ToBoolean(log != "root"))
        {Console.WriteLine($"Было выполнено {i} {text1} логина,\nаккаунт временно заморожен, обратитесь в службу поддержки :)");
        return;}
    #endregion
        
    #region // блок ввода и проверки пароля
       string pass = "password";
       int j = 0;
    do
    {   
        Console.Write ("Введите пароль: ");
        pass = Console.ReadLine ();
        if (Convert.ToBoolean(pass != "GeekBrains"))
        {
            {j++;}
        }
        else {break;};
     
    } while (j < 3);

    if (Convert.ToBoolean(pass != "GeekBrains"))
        {Console.WriteLine($"Было выполнено {j} {text1} пароля,\nаккаунт временно заморожен, обратитесь в службу поддержки :)");
        return;}
    #endregion

Console.WriteLine ($"Введены верные логин ({log}) и пароль ({pass})!");
}

LogPass ();