// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

string ShowNumbers(int startM, int endN)
{
    if (startM == endN)
    {
        return startM.ToString();
    }
    return startM + ", " + ShowNumbers(startM + 1, endN);
}

Console.Write("Введите значение M: ");
int natNumberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int natNumberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ShowNumbers(natNumberM, natNumberN));