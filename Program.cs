// Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.

void Cube(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write ($"{i*i*i}");
        if (i != n)
        {
            Console.Write(", ");
        }
    }
}
Console.Clear();
Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine()!);
Cube(N);
