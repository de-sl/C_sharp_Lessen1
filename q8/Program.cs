﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = 1;
while (res <= num){
    Console.Write($"{res} ");
    res++;
}
