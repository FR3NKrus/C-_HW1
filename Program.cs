// Домашняя работа Виталия Петровича

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число :"); 
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :"); 
int num_2 = Convert.ToInt32(Console.ReadLine());
if (num_1 > num_2)
    Console.WriteLine($"{num_1} больше, чем {num_2}");
else if (num_1 < num_2)
    Console.WriteLine($"{num_2} больше, чем {num_1}");
else
    Console.WriteLine($"{num_2} равно {num_1}");


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число :"); 
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :"); 
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число :"); 
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;
if (num_1 < num_2) 
    max = num_2;
if (num_2 < num_3)
    max = num_3;
if (num_1 > num_3)
    max = num_1;
Console.WriteLine($"Максимальное число: {max}");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число :"); 
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
    Console.WriteLine($"{num} -  является чётным число!");
else
    Console.WriteLine($"{num} -  является НЕчётным число!");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число :"); 
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (num > 0)
    while (count <= num ) {
        Console.WriteLine(count);
        count++;
    }
else 
    Console.WriteLine("Программа работает только с числами больше 0!"); 