// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число...");
int n = Convert.ToInt32(Console.ReadLine());
int[] num = new int[5];

num[0] = (n - (n % 10000)) / 10000;
num[1] = ((n - (n % 1000)) / 1000) % 10;
num[2] = ((n - (n % 100)) / 100) % 10;
num[3] = ((n - (n % 10)) / 10) % 10;
num[4] = n % 10;

if((num[0] == num[4]) && (num[1] == num[3]))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


// Console.WriteLine($"{num[0]}"); 
// Console.WriteLine($"{num[1]}");
// Console.WriteLine($"{num[2]}");
// Console.WriteLine($"{num[3]}");
// Console.WriteLine($"{num[4]}");