// Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int InputInt(string message)
{
    Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int Summa(int number)
{
    int sum = 0;
    while (number != 0)
    {
        int posl = number % 10;
        sum = sum + posl;
        number /= 10;
    }
    return sum;
}
int number = InputInt("Введите число");
int res = Summa (number);
Console.WriteLine ($"Cумма цифр в числе равна {res}");