// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.
// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

int[] FillArray(int number)
{
    int[] arr = new int[number];
    Random rnd = new Random();
    for (int i = 0; i < number; i++)
    {
        arr[i] = rnd.Next(101);
    }
    return arr;
}

void ShowReversArray(int[] arr, int size)
{
    // Доходим до 0 индекса
    if (size == 0)
    {
        Console.Write($" {arr[size]} ]");
        return;
    }
    Console.Write($" {arr[size]};");
    size -= 1;
    ShowReversArray(arr, size);
}

Console.Write("Введите количество элементов массива: ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());
int[] Array = FillArray(numberOfElements);
Console.WriteLine($"Массив: [ {string.Join("; ", Array)} ]");
Console.Write("Реверс массива: [");
ShowReversArray(Array, Array.Length - 1);