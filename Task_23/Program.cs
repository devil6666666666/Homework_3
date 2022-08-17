//Выдает кубы чисел от 1 до N включительно
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
    for (int a = 1; a <= N; a++)
    {
        Console.WriteLine();
        Console.Write(Math.Pow(a, 3));
    }
}
else for (int a = 1; a >= N; a--)
    {
        Console.WriteLine();
        Console.Write(Math.Pow(a, 3));
    }

