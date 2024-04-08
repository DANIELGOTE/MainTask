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
}

