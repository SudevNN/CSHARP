// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.
// Пример:
// “aBcD1ef!-” => “abcd1ef!-” 

string RndStr(int letters)
{
    Random rnd = new Random();
    string str = string.Empty;
    string letterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    for (int i = 0; i < letters; i++)
    {
        str += letterSet[Convert.ToChar(rnd.Next(0, letterSet.Length))];
    }
    return str;
}

// Уточняем размер строки:
Console.Write("Введите количество символов: ");
int lettersQuantity = Convert.ToInt32(Console.ReadLine());
// Наполняем строку случайными символами
string createStr = RndStr(lettersQuantity);
Console.WriteLine(createStr);
Console.WriteLine("Результат: ");
string strToLower = createStr.ToLower();
Console.WriteLine(strToLower);