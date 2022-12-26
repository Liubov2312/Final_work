// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 
// три символа.

string text = "hello 2 world :-)";
Console.WriteLine(text);
string[] array = text.Split(" ");
Console.WriteLine();
string result = String.Empty;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Console.Write($"{array[i]} ");
    }
}



