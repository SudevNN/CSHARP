string GetStringFromCharArray (char[] array)
{
    string result = string.Empty; // ""
    foreach (char symbol in array) 
    // symbol='a',symbol='b',symbol='c',symbol='d'
    {
        result += symbol;
    }
    return result;
}

char[] chars = {'1', 'd', '!', '2', 'f'};
string res = GetStringFromCharArray(chars);
Console.WriteLine($"Result: {res}");