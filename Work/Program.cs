// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

string[] array = new string[size];

FillStringArray(array);

Console.WriteLine();

Console.Write("[");
PrintStringArray(array, ", ");
Console.Write("] -> ");

string[] newArray = StringArray(array);
Console.Write("[");
NewStringArray(newArray, ", ");
Console.Write("]");

void FillStringArray(string[] array)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Console.ReadLine();
    }
}

void PrintStringArray(string[] array, string sep)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}{sep} ");
        else Console.Write($"{array[i]}");
    }
}

static string[] StringArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }

    string[] newArray = new string[count];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

void NewStringArray(string[] newArray, string sep)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i < newArray.Length - 1) Console.Write($"{newArray[i]}{sep} ");
        else Console.Write($"{newArray[i]}");
    }
}