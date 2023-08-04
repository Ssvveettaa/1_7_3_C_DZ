// Задача 19:
// Напишите программу, которая
// принимает на вход пятизначное число
// и проверяет является ли оно палиндромом.
// 14212 –> нет
// 12821 –> да
// 23432 –> да

bool FiveDigit(int num)
{
    if (num < 0) num *= -1;
    return num >= 10000 && num <= 99999;
}   // Или только (return (num >= 10000 && num <= 99999) || (num <= -10000 && num >= -99999);) в теле метода.

bool Palindrome(int fiveDigit)
{
    return fiveDigit / 10000 == fiveDigit % 10 && fiveDigit / 1000 % 10 == fiveDigit / 10 % 10;
}   // Не привожу число сначала к модулю, так как метод работает и с отрицательными тоже.

Console.Write("Введите целое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (FiveDigit(number))
{
    bool palindrome = Palindrome(number);
    Console.WriteLine(palindrome ? $"Число {number} является палиндромом." : $"Число {number} не является палиндромом.");
}
else Console.WriteLine("Число не пятизначное.");
