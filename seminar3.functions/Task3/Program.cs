// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int[] CreateArray(int size)
{
    int[] array = new int[size]; // Массив array на size элементов
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        // 0,10: 0,1,2,3,4,5,6,7,8,9
    }
    return array;
}

int ConvertArrayToInteger(int[] array)
{
    int result = 0;
    for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
    {
        // a=[1,6,3];
        // r = 0 + 1 * 10 ^ 2; r = 100
        // r = 100 + 6 * 10 ^ 1;  r = 160
        // r = 160 + 3 * 10 ^ 0 = 160 + 3 * 1 => r = 163
        result = result + array[i] * (int)Math.Pow(10, j);
        // double -> int (все числа)
    }
    return result;
}
Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N);
if (N > 8)
{
    Console.WriteLine("Invalid data");
    return; // Остановится программа на этой строчке, код ниже НЕ вып.
}
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
Console.WriteLine($"Result: {ConvertArrayToInteger(res)}");
