// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


//основной метод
string[] OnlyLessThanThreeStrings(string[] array)
{
    string[] result = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }

    return result;
}

//метод для печати массива
void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
}


string[] example = new string[] {"киборг","НЛО","хлеб","ок","гоу","флекс"};

PrintArray(OnlyLessThanThreeStrings(example));