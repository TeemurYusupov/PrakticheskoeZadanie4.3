// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 52 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int i = 0;
while ( num > 0)
{
    i = num % 10;
    sum = sum + i;
    num = num / 10;
}

Console.WriteLine($"{sum}");