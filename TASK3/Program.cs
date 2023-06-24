// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
System.Console.WriteLine("Введите число: ");
String InputedString = System.Console.ReadLine();
int number = Convert.ToInt32(InputedString);
if (number % 2 == 0)
{
    Console.WriteLine($"Число {number} четное");
}
else
{
    Console.WriteLine($"Число {number} нечетное");
}