// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
System.Console.WriteLine("Введите первое число: ");
String InputedString1 = System.Console.ReadLine();
int number1 = Convert.ToInt32(InputedString1);
System.Console.WriteLine("Введите второе число: ");
String InputedString2 = System.Console.ReadLine();
int number2 = Convert.ToInt32(InputedString2);
if (number1 > number2)
{
    System.Console.WriteLine($"максимальное число равно {number1}, минимальное число равно {number2}");
}
else
{
    System.Console.WriteLine($"максимальное число равно {number2}, минимальное число равно {number1}");
}