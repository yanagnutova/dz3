// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


double dotx1 = InputInt ("Введите значение х1");
double doty1 = InputInt ("Введите значение y1");
double dotz1 = InputInt ("Введите значение z1");
double dotx2 = InputInt ("Введите значение x2");
double doty2 = InputInt ("Введите значение y2");
double dotz2 = InputInt ("Введите значение z2");

double lengthBetweenPoints = FindLength (dotx1, doty1, dotz1, dotx2, doty2, dotz2);
Console.WriteLine ($"Расстояние между точками = {lengthBetweenPoints:F2}");

double InputInt (string message)
{
    Console.Write (message + " > ");
    string? inputValue = Console.ReadLine ();
    double result = Convert.ToDouble (inputValue);
    return result;
}

double FindLength (double xOne, double yOne, double zOne, double xTwo, 
double yTwo, double zTwo)
{
    double stor1 = Math.Pow (xTwo-xOne,2);
    double stor2 = Math.Pow (yTwo-yOne,2);
    double  stor3 = Math.Pow (zTwo-zOne,2);
    double formula = Math.Sqrt (stor1 + stor2 + stor3);
    return formula;
}