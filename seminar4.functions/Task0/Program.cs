// тип_метода ИмяМетода (пар1, пар2)
// char ('+') - 1 элемент, string - массив символов
// "Hello", string - массив char-ов
// char: '2', ' ', '+' (только ОДИНАРНАЯ кавычка)
// string: "hello" , "2", (только ДВОЙНАЯ кавычка)
int Calculate(int a, int b, char sign) // 2 числа и знак (sign)
{
    if (sign == '+')
    {
        return a + b;
    }
    else if (sign == '-')
    {
        return a - b;
    }
    else if (sign == '*')
    {
        return a * b;
    }
    else if (sign == '/')
    {
        return a / b;
    }
    else
    {
        Console.WriteLine("Вы ввели неизвестный арифм. оператор");
        return 0;
    }

}
// Вызов метода 
// int Calculate(int a, int b, char sign)
Console.WriteLine(Calculate(10, 20, '+')); // 30
Console.WriteLine(Calculate(10, 20, '-')); // -10
Console.WriteLine(Calculate(10, 20, '*')); // 200
Console.WriteLine(Calculate(20, 10, '/')); // 2
Console.WriteLine(Calculate(20, 10, '.')); // Вы ввели неизвестный арифм. оператор
