/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

int GetCoord(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resultNumber))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число. Повторите ввод!");
        }
    }
    return resultNumber;
}
double GetDistance(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Sqrt(Math.Pow(ax-bx,2)+Math.Pow(ay-by,2)+Math.Pow(az-bz,2));
    return result;
}
 int ax = GetCoord("Введите координату x первой точки");
 int ay = GetCoord("Введите координату y первой точки");
 int az = GetCoord("Введите координату z первой точки");

 int bx = GetCoord("Введите координату x второй точки");
 int by = GetCoord("Введите координату y второй точки");
 int bz = GetCoord("Введите координату z второй точки");

 double distance = GetDistance(ax,ay,az,bx,by,bz);
 Console.WriteLine($"Расстояние между точками {distance:f2}");