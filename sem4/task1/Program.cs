//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B. Не использовать Math.Pow
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int InputInt(string message)
{
    Console.Write(message + "  ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int InputIntDegree(string message)
{
    Console.Write(message + "  ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int SearchPow (int number, int degree)
{
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result *= number;
    }
    return result;
}

int number = InputInt("Введите число, которое будем возводить в степень");
int degree = InputIntDegree($"Введите степень числа {number}, которое будем возводить в степень");
int search = SearchPow (number, degree);

Console.WriteLine ($"Число {number} в степени {degree} равно {search}");
