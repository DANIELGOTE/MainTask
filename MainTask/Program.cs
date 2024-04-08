

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