int SizeNewArray(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) size += 1;
    }
    return size;
}
string[] ArrayOfLengthIsThree(string[] array, int size)
{
    string[] newArray = new string[size];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count += 1;
        }
    }
    return newArray;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
string[] firstArray = new string[] {"Nic", "Hello", "fic", "2", "world", ":-)"};
ShowArray(firstArray);
int size = SizeNewArray(firstArray);
string[] secondArray = ArrayOfLengthIsThree(firstArray, size);
ShowArray(secondArray);
