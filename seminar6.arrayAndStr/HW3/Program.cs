// Задача 3: Задайте произвольную строку. Выясните, является ли 
// она палиндромом.(читается одинаково слева направо и справа 
// на лево)
// Пример:
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

bool PalindromeCheck(char[] wordIn)
{
    for (int i = 0, j = wordIn.Length - 1; i < wordIn.Length; i++, j--)
    {
        if (wordIn[i] != wordIn[j])
        {
            return false; //есть отличия по символам, слово не палиндром
        }
    }
    return true; //все символы совпали, слово палиндром
}

char[] ConvertStringToChar(string str)
{
    char[] chars = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
    }
    return chars;
}
// Меняем кодировку
Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");

Console.Write("Введите слово: ");
string wordStr = Console.ReadLine();
string wordStrToLower = wordStr.ToLower();
char[] charsWord = ConvertStringToChar(wordStrToLower);
// Console.WriteLine($"Массив: [ {string.Join(" ;", charsWord)} ]");
// // является ли строка палиндромом
bool isPalindrome = PalindromeCheck(charsWord);
// результат
Console.WriteLine(isPalindrome ? "Да" : "Нет");