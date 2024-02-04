// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int GetVovelsCount(string str)
{
    string vovels = "aoueiy";// Строка с гласными
    int countVovels = 0; // Количество гласных 
    foreach (char symbol in str) // Берем каждую букву из str
    {
        foreach (char vovel in vovels) // Берем гласные буквы
        {
            if (symbol == vovel) // Мы нашли гласную букву
            {
                countVovels++;
                break; 
            }
        }
    }
    return countVovels; 
}
Console.Write("Введите строчку: ");
string inputString = Console.ReadLine();
inputString = inputString.ToLower(); // HELLO => hello
// ToUpper() -> hello => HELLO
int countVovels = GetVovelsCount(inputString);
Console.WriteLine($"Количество гласных: {countVovels}");
