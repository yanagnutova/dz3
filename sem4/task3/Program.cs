//Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран. Сделать через функции
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] CreateNumbersArray()
{
    int[] array = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next (0, 100);
    }
    return array;
}

void PrintArray (int[] array, string message)
{
    Console.WriteLine (message);
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
}

int[] numbersArray = CreateNumbersArray ();
PrintArray (numbersArray, "Массив из 8 элементов");
