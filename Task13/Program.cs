// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введи число: ");

int Number = Convert.ToInt32(Console.ReadLine());

string TextNumber = Convert.ToString(Number);

if (TextNumber.Length > 2)
{
    Console.WriteLine("третья цифра: " + TextNumber[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}