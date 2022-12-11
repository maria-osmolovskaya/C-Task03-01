/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result.ToString().Length!>4 && result.ToString().Length<6)
        {
            isCorrect = true;
        }
        else 
        {
            Console.WriteLine("Вы ввели не пятизначное число. Введите пятизначное число");
        }
    }
    return result;
}

int Number = GetNumber ("Введите пятизначное число");

int FirstDigit = Number / 10000;
int SecondDigit = ((Number / 1000) % 10);
int FourthDigit = ((Number % 100) / 10);
int FifthDigit = Number % 10;

if (FirstDigit==FifthDigit && SecondDigit==FourthDigit)
{
Console.WriteLine ("да");
}
else
Console.WriteLine ("нет");