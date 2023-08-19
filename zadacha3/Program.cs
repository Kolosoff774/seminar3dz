/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine());

if (number < 0) {
    Console.Write("Ошибка ввода!");
} else {
    Cube(number);
}

void Cube(int num) {
    for (int i = 1; i <= num; i++) {
        Console.WriteLine($"{i, 3}   | {i * i * i, 4}");
    }
}