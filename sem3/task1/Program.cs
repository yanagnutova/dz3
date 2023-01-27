//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом. Не используйте строки
//14212 -> нет
//12821 -> да
//23432 -> да

int InputInt(string message)
{
    Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}
int N = InputInt("Введите пятизначное число");
bool Fivepoint(int N)
{
    if (N > 9999 && N < 100000)
    {
        return true;
    }
    Console.WriteLine("Ошибка! Введите пятизначное число");
    return false;
}

bool CheckRevers(int N)
{
    int num1 = N / 10000;
    int num5 = N % 10;
    int num2 = N / 1000;
    num2 %= 10;
    int num4 = N % 100;
    num4 /= 10;

    if (num1 == num5 & num2 == num4)
    {
        Console.WriteLine($"Число {N} является палиндромом");
        return true;
    }
    Console.WriteLine($"Число {N} не является палиндромом");
    return false;
}

if (Fivepoint(N))
{
    CheckRevers(N);
}