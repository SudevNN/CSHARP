// Задача 2: Задайте массив заполненный случайными трёхзначными 
// числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.

int[] CreateArray(int size)
{
    int[] array = new int[size]; // Массив array на size элементов
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;      
}

int CountOddItems(int[] numbers)
{
    //Напишите свое решение здесь
    int cnt = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            cnt++;
        }
    }
    return cnt;
}

// Вызов функции
Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N);
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
Console.WriteLine($"Количество чётных чисел в массиве: {CountOddItems(res)}");