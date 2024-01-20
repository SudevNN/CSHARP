// Задача 1: Напишите программу, которая бесконечно запрашивает 
// целые числа с консоли. Программа завершается при вводе 
// символа ‘q’ или при вводе числа, сумма цифр которого чётная.

while (true) // true == true
{
    Console.Write("Введите текст: ");
    string text = Console.ReadLine();
    if (text == "q")
    {
        break;
    }
    // Нужно проверить, что строчка text cостоит ТОЛЬКО
    // из цифр
    int number; // 0, если в строчке есть символы
                // или само число
    if (int.TryParse(text, out number)) // == true
    {
        Console.WriteLine("Введенная строчка состоит из ЦИФР");
        int sum = 0; // 56 => 6+5
        while (number > 0)
        {
            sum = sum + number;
            number /= 10; // Избавляюсь от последней цифры
        }
        if (sum % 2 == 0)
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("Ошибка! Введите цифры без символов");
    }
}
