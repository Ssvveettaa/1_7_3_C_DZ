// Задача 19:
// Напишите программу, которая
// принимает на вход пятизначное число
// и проверяет является ли оно палиндромом.
// 14212 –> нет
// 12821 –> да
// 23432 –> да

string Palindrome(int num)
{
    if (num < 0) num *= -1;
    if (num >= 10000 && num <= 99999)
    {
        return num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10 ? "является палиндромом" : "не является палиндромом";
    }
    else return "не пятизначное";
}

Console.Write("Введите целое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string palindrome = Palindrome(number);
Console.WriteLine($"Число {number} {palindrome}.");
