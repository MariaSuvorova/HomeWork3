/* Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int GetNumber(string message)
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

int number = GetNumber("Введите число:");
for (int i=1; i<=number; i++)
{
   Console.Write($"{Math.Pow(i,3)}; ");
}