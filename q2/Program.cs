﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Input first number: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB){
    Console.WriteLine($"The first number is greater than the second");
    Console.WriteLine($"{numA} > {numB}");
}
else{
    Console.WriteLine($"The second number is greater than the first");
    Console.WriteLine($"{numB} > {numA}");
}



