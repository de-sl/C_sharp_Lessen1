// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int mx = 0;
int mn = 0;
if (num1 > num2 && num1 > num3)
    mx = num1;
else if (num2 > num1 && num2 > num3)
    mx = num2;
else if (num3 > num1 && num3 > num2)
    mx = num3;
Console.WriteLine($"The largest number: {mx}");

