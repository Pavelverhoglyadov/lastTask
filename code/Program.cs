string[] array = { "Hello", "2", "world", ":-)" };
int maxnum = 3;

string[] FillArray(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= maxnum)
        {
            result[count] = array[i];
            count++;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    foreach (string el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

string[] shortArray = FillArray(array);
PrintArray(shortArray);