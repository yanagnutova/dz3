//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int InputInt (string message)
{
    Console.Write (message + " > ");
    string? inputValue = Console.ReadLine ();
    int result = Convert.ToInt32 (inputValue);
    return result;
}

int N = InputInt ("Введите число"); 
Console.Write ("Таблица кубов = ");
TKub (N);

void TKub (int N)
{
    for (int i = 1; i <= N; i ++)
    {
        int result = i*i*i;
        Console.Write ($"{result}, ");
    }
}