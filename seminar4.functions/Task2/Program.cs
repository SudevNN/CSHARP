// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size]; // Массив array на size элементов
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int GetCountOfInterestingNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 7 == 0 && arr[i] % 10 == 1)
        {
            count++; // count = count + 1
        }
    }
    return count;
}

// Вызов функции
Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N, 10, 99);
// CreateArray(N, 10, 99) => массив, размер: N
// каждый элемент: число от 10 до 99 вкл-но
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
Console.WriteLine($"Total: {GetCountOfInterestingNumbers(res)}");