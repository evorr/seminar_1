﻿// 0. Демонстрация решения
//Напишите программу, которая на вход принимает число и выдаёт его квадрат 
//(число умноженное на само себя).
//Например:
//4 -> 16
//-3 -> 9
//-7 -> 49

Console.Clear();

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
//int num = 4; // int -2.147 mlrd do 2.147 mlrd

int res = num*num;
Console.WriteLine($"квадрат числа {num} = {res}");


