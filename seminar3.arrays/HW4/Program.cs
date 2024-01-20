// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.
// Примеры
// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]

int[] CreateArray(int number)
{
    int size = 1;
    int number1 = number;
    while (number > 9)
    {
            number /= 10;
            size++;
    }
    int[] array = new int[size]; // Массив array на size элементов
    for (int i = array.Length-1; i >= 0; i--)
    {
        array[i] = number1 % 10;
        // Console.WriteLine(number1);       
        number1 = number1 / 10;
    }
    return array;
      
}

// Вызов функции
Console.Write("Введите натуральное число в диапазоне от 1 до 100 000: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N);
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
