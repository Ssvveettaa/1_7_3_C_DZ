// Задача 23:
// Напишите программу, которая
// принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 5 –>
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void CubeTable(int num)
{
    for (int count = 1; count <= num; count++)
    {
        Console.WriteLine($"{count, 4} {Math.Pow(count, 3), 12}");
    }
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    CubeTable(number);
}
else
{
    Console.WriteLine("Число не натуральное.");
}
