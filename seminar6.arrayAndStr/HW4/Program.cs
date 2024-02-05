// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.
// Пример:
// “Hello my world” => “world my Hello”

string ReverseWords(string str)
{
        string[] words = str.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
}
// Меняем кодировку для русских символов
Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");

Console.Write("Введите предложение: ");
string sentenceStr = Console.ReadLine();
string result = ReverseWords(sentenceStr);
// Вывод результата
Console.WriteLine(result);