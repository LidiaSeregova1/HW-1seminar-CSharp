// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите певое число:");
int numberA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите треье число:");
int numberC=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Max(numberA, Math.Max(numberB,numberC)));
