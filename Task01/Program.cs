/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine ("Введите первое число");
string numberOneStr = Console.ReadLine ();

Console.WriteLine ("Введите второе число");
string numberTwoStr = Console.ReadLine ();

int NumberOne = Convert.ToInt32(numberOneStr);
int NumberTwo = Convert.ToInt32(numberTwoStr);

if (NumberOne > NumberTwo)
{
    Console.WriteLine("Число 1 больше Числа 2");
}
else
{
    Console.WriteLine("Число 2 больше Числа 1");
}
