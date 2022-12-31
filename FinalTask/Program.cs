// метод ввода числа/текста пользователем
string DataEntry(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    return input;
}

//метод создания массива и заполнения через ввод пользователем
string[] FillArray(int elements)
{
    string[] massive = new string[elements];
    for (int i = 0; i < elements; i++)
    {
        massive[i] = DataEntry("Введите число или текст: ");
    }
    return massive;
}

//метод вывода элементов массива соответствующих условию
void ChangeArray(string[] array, int control)
{
    string[] newarray = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= control)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    Console.WriteLine('[' + string.Join(",", newarray) + ']');
}

Console.Clear();
int numberofelements = 3;
int maxelementlength = 3;
string[] array = FillArray(numberofelements);
Console.WriteLine('[' + string.Join(",", array) + ']');
ChangeArray(array, maxelementlength);




