// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
    Console.WriteLine("Your number is even");
else 
    Console.WriteLine("Your number is not even");