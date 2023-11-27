﻿// Задача 1:Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

//  Console.WriteLine((int.Parse(Console.ReadLine()!) % 161 == 0) ? 
//  "Число кратно одновременно 7 и 23." : "Число НЕ кратно одновременно 7 и 23.");

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.


// ﻿using System;
// class Program

// {
//     static void Main()
//     {
//         Console.WriteLine("Введите координаты точки (X и Y):");

//         // Ввод координат с клавиатуры
//         Console.Write("Введите X: ");
//         double x = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Введите Y: ");
//         double y = Convert.ToDouble(Console.ReadLine());

//         // Проверка условия X ≠ 0 и Y ≠ 0
//         if (x == 0 || y == 0)
//         {
//             Console.WriteLine("Ошибка: X и Y должны быть не равны нулю.");
//         }
//         else
//         {
//             // Определение четверти
//             int quadrant = DetermineQuadrant(x, y);

//             // Вывод результата
//             Console.WriteLine($"Точка находится в {quadrant} четверти.");
//         }
//     }

//     // Метод для определения номера координатной четверти
//     static int DetermineQuadrant(double x, double y)
//     {
//         if (x > 0 && y > 0)
//         {
//             return 1;
//         }
//         else if (x < 0 && y > 0)
//         {
//             return 2;
//         }
//         else if (x < 0 && y < 0)
//         {
//             return 3;
//         }
//         else
//         {
//             return 4;
//         }
//     }
// }


//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.



// Console.Write("Введите число от 10 до 99: ");
// int number = int.Parse(Console.ReadLine()!);
// while (number < 10 || number > 99)
// {
//     Console.Write("Вы ввели неверное число!\nВведите число от 10 до 99: ");
//     number = int.Parse(Console.ReadLine()!);
// }
// int firstNumber = number / 10;
// int secondNumber = number % 10;
// if (firstNumber > secondNumber)
// {
//     Console.WriteLine("Наибольшая цифра этого числа: " + firstNumber);
// }
// else
// {
//     Console.WriteLine("Наибольшая цифра этого числа: " + secondNumber);
// }



//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.


Console.Write("Введите любое натуральное число: ");
string inputNum = (Console.ReadLine()!);
int number = int.Parse(inputNum);
string outNumLine = string.Empty;
int count = 0;
while (count < number)
{
    outNumLine = outNumLine + count + ",";
    count = count + 1;
}
Console.WriteLine(outNumLine + number);



