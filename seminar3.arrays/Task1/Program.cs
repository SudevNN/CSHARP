// Задание 1. Совместная работа
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 
// тип_данных[] имя_массива = ...

int[] array = { 11, 22, 33, 44, 55, 66, 77 };
Console.Write("Введите число для поиска: ");
int numberForSearch = Convert.ToInt32(Console.ReadLine());
bool isFound = false; // Изначально элемента в массиве нет
// точка старта; условие;
for (int i = 0; i < array.Length; i++) 
{
    if (numberForSearch == array[i])
    {
        isFound = true; // Ура, число найдено :)
        break; // Ломаю цикл, так как число найдено
    }
}
if (isFound) // isFound == true
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}