// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите число:...");
int n = Convert.ToInt32(Console.ReadLine());
double i = 1;
double x = 1;

while (i <= n)
{
    x = Math.Pow(i, 3);
    {
        Console.Write($" {x}");
    }
    i++;
}