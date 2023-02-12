﻿// Напишите программу, которая на вход принимает число 
// и выдаёт его квадрат (число умноженное на само себя).
Console.WriteLine("Введите число > ");      // Ввод в консоль приглашения для ввода
string inputValue;                          // Объявление переменной, которую будем сохранять пользовательский ввод
inputValue = Console.ReadLine();            // Присваивание переменной из консоли (ввод пользователя)
int value = Convert.ToInt32(inputValue); // Конвертация в целое введенной строки. Строка конвертируется в целое число. Конвертируем в то, что нам нужно, другого типа спецификации

int square = value * value; // Вычисление квадрата
// Вывод на экран
System.Console.WriteLine("Квадрат числа " + value + " равен " + square);
System.Console.WriteLine($"Квадрат числа {value} равен {square}");