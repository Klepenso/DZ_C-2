// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру дня недели:");

int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDay(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("выходной - да");
    }
    else Console.WriteLine("выходной - нет");
}

CheckingTheDay(dayNumber);