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
