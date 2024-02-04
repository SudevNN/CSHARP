// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

char[] ConvertStringToCharArray(string str)
{
    char[] chars = new char[str.Length];
    // "hi" => [h,i]
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
    }
    return chars;
}
string testString = "Hello world";
char[] chars = ConvertStringToCharArray(testString);
Console.WriteLine($"Массив: [ {string.Join(" ;", chars)} ]");
