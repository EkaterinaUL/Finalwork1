string[] FillArray()
{
    string[] array = new string[] {"Hello", "2", "world", ":-)"};
    return array;
}

void PrintArray (string[] array)
{
    for (int i=0; i < array.Length; i++)
    {       
        if (array[i] != String.Empty) Console.Write("'" + array[i] + "'");
    }
    Console.WriteLine();
}

string[] NewStringArray (string[] array)
{
    int j = 0;
    int count = 3;
    string[] newArray = new string[array.Length];
    for (int i=0; i < array.Length; i++)
    {
        if (array[i].Length < count + 1)
        {
           newArray[j] = array[i];
           j++;
        }
    }
return newArray;
}

string[] array = FillArray();
PrintArray(array);
string[] newArray = NewStringArray(array);
PrintArray(newArray);
