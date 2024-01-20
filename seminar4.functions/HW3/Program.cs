// Задача 3: Напишите программу, которая перевернёт одномерный 
// массив (первый элемент станет последним, второй – предпоследним 
// и т.д.)
// Пример:
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

int[] CreateArray(int size)
{
    int[] array = new int[size]; // Массив array на size элементов
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

int[] ReverseArray(int[] arrayIn)
{
    int thirdVariable = 0;
    int[] arrayOut = new int[arrayIn.Length];
    for (int i = 0, j = arrayIn.Length - 1; i < arrayIn.Length; i++, j--)
    {
        thirdVariable = arrayIn[i];
        arrayOut[i] = arrayIn[j];
        arrayOut[j] = thirdVariable;
    }
    return arrayOut;
}

// Вызов функции
Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N);
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
int[] ReverseRes = ReverseArray(res);
Console.WriteLine($"Перевернутый массив: [ {string.Join("; ", ReverseRes)} ]");