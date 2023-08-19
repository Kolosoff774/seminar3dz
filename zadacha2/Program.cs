/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Write("Введите координату X точки 1: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y точки 1: ");
int y = int.Parse(Console.ReadLine());

Console.Write("Введите координату Z точки 1: ");
int z = int.Parse(Console.ReadLine());

Console.Write("Введите координату X точки 2: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y точки 2: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату Z точки 2: ");
int z1 = int.Parse(Console.ReadLine());

double result = Distance(x, y, z, x1, y1, z1);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {resultRound}");

double Distance(int x, int y, int z, int x1, int y1, int z1) {
    int distX = x1 - x;
    int distY = y1 - y;
    int distZ = z1 - z;
    double dist = Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2) + Math.Pow(distZ, 2));
    return dist;
}
