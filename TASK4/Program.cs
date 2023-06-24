// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа
//  от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
System.Console.WriteLine("Введите число: ");
String InputedString = System.Console.ReadLine();
int number = Convert.ToInt32(InputedString);
int count = 2;
while (count <= number)
{
    Console.Write($"{count} ");
    count+=2;
}