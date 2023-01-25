/* Задача 19 Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

int GetNumber(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber > 9999 && resultNumber < 100000)
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

int CheckPalindrom(int resultNumber)
{
    int n = 5;
    int check=0;
    int[] figures = new int[n];
    
    for (int i=0; i<n-1; i++)
    {
        figures[n-1-i] = resultNumber % 10;
        resultNumber = resultNumber / 10;
    }   
    for (int i=0; i<n/2; i++)
    {
        if (figures[i] == figures[n-1-i])
        {
            check = 1;
        }
    }
     return check;     
}

int number5pos = GetNumber("Введите пятизначное число:");
int check = CheckPalindrom(number5pos);
if (check == 1)
{
    Console.WriteLine($"Число {number5pos} является палиндромом");
}
else Console.WriteLine($"Число {number5pos} не является палиндромом");