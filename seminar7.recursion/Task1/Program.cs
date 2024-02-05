// // Рекурсия - метод, который вызывается внутри метода

// // Факториал - произведение чисел от 1 до n включительно
// // 4! = 4 * 3 * 2 * 1
// // n -> 1
// int FindFactorial(int n)
// {
//     // Базовый случай - случай выхода из рекурсии
//     if (n == 1) return 1;
//     if (n == 0) return 1; // Факториал от нуля равен 1
//                           // 4 * 3 * 2 * x(1)
//                           // Рекурсивный случай - тут и происходит вызов метода внутри метода
//     return n * FindFactorial(n - 1);
// }

// Console.WriteLine(FindFactorial(4)); // 4 * 3 * 2 * Find(1)

// Задание 1. Напишите программу, которая будет принимать на 
// вход число и возвращать сумму его цифр.
// Указание - Использовать рекурсию.
// Пример:
// 123 => 6
// 63 => 9

int SumOfDigits(int number)
{
    // 63 = 3(63 % 10) + 6(6 % 10) + 0
    if (number == 0) return 0; // 6 + 3 + 0 = 9
    int result = number % 10 + SumOfDigits(number / 10);
    return result;
    // number = 35
    // result = 5 + 3 + SumOfDigits(0) = 5 + 3 + 0
    // SumOfDigits(3) = 3 + SumOfDigits(0)
}
Console.WriteLine(SumOfDigits(45));
