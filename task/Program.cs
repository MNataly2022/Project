// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] array = { "hello", "2", "world", ":-)" };

string[] addElement(string[] array, string newElement)
{
    string[] newArray = new string[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    newArray[array.Length] = newElement;
    return newArray;
}

string[] newArray = new string[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray = addElement(newArray, array[i]);
    }
}
Console.WriteLine($"Массив с элементами меньше 3-х символов:\n[\"{string.Join("\", \"", newArray)}\"]");
