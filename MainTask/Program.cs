

string[] FilterArray(string[] arr)
{
    int count = 0;
    foreach (string str in arr)
    {
        if(str.Length <= 3)
        {
            count++;
        }
    }
    
    string[] array = new string[count];
    int index = 0;
    foreach (string str in arr)
    {
        if(str.Length <= 3)
        {
            array[index++] = str;
        }
    }
    return array;
}

string[] arr = { "Hello", "World", "2", "8", ":-)" };
{

        
        string[] filteredArray = FilterArray(arr);

        
        Console.WriteLine("Исходный массив:");
        foreach (string str in arr)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();
        
        Console.WriteLine("Массив строк длиной не более 3 символов:");
        foreach (string str in filteredArray)
        {
            Console.Write(str + " ");
        }
}