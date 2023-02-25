int n = GetNumberFromUser($"Введите количество элементов в массиве", "Ошибка ввода");
string[] res1 = GetArray(n);
Console.Write($"[{String.Join(", ", res1)}]");



int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


string[] GetArray(int size)
{
    string[] res = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите элемент {i+1}:");
        res[i] = Console.ReadLine() ?? "";
    }
    return res;
}

string[] ChangeArray(string[] inArray)
{
    string[] T = new string[inArray.Length];
    int j = 0;
    for(int i = 0; i < inArray.Length; i++)
    {
        if(inArray[i].Length <= 3)
        {
            T[j] = inArray[i];
            j++;
        }
    }

    Array.Resize(ref T, j);
    return T;
}

