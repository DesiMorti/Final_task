/*
    Итоговая задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
    длина которых меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
    При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
    Примеры:
    ["hello","2","world",":-)"] -> ["2",":-)]
*/

Console.Clear();
string[] firstArray = new string[] { "hello", "2", "world", "qwe", "computer science", ":-)" };

PrintArray(firstArray);
Console.Write(" -> ");
PrintArray(FillArrayThreeChar(firstArray));

int CountThreeChar(string[] _array)
{
    int count = 0;
    for (int i = 0; i < _array.Length; i++)
    {
        if (_array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] FillArrayThreeChar(string[] _array)
{
    int size = CountThreeChar(_array);
    string[] resultArray = new string[size];
    for (int i = 0, j = 0; i < _array.Length; i++)
    {
        if (_array[i].Length <= 3)
        {
            resultArray[j] = _array[i];
            j++;
        }
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
        if (i < count - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}