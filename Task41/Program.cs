/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/
int count = 0;
Console.WriteLine("Enter your numbers: ");

int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(' ', ',', '.', '\t'), int.Parse); 

for (int i = 0; i < numbers.Length; i++) if (numbers[i] > 0) count++;

Console.WriteLine($"Count of positive numbers is: {count}");
