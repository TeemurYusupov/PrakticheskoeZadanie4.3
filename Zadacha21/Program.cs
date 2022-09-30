// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите x1 точки А...");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x2 точки А...");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x3 точки А...");
int x3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y1 точки B...");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y2 точки B...");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y3 точки b...");
int y3 = Convert.ToInt32(Console.ReadLine());

int n1 = y1 - x1; Math.Pow(n1, 2);
int n2 = y2 - x2; Math.Pow(n2, 2);
int n3 = y3 - x3; Math.Pow(n3, 2);

int result = n1 + n2 + n3;
Math.Sqrt(result);
Console.WriteLine($"Расстояние между точками = {result}");