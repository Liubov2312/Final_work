// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 
// три символа.

string[] array = new string[5] {"hello", "2", "hello", "world", ":-)"};
string[] arr = new string[array.Length];

FillArrayIF(array, arr);
PrintArray(array);
PrintArray(arr);

void FillArrayIF(string[] array, string[] arr)
{
    int item = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        arr[item] = array[i];
        item++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}



