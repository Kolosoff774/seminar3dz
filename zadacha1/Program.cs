/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введи пятизначное число: ");
int number = int.Parse(Console.ReadLine());

if (number < 10000 || number > 99999) {
    Console.WriteLine("Ошибка! Вы ввели не пятизначное число!");
} else {
    Console.WriteLine(Palindrom(number));
}

string Palindrom(int num) {
    int num1 = num / 10000;
    int num2 = num % 10;

    int num3 = num / 1000;
    num3 %= 10;

    int num4  = num / 10;
    num4 %= 10;
    if (num1 == num2 && num3 == num4) return "Yes";
    return "No";
}
