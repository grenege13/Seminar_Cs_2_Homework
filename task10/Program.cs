// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Нужно сделать через числа, без индексов строк.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int number = 0;
while (number == 0)
{
    Console.WriteLine("Введите трёхзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());

    if (number / 100 < 1 || number / 100 > 10)
    {
        Console.WriteLine(" ERROR: Число НЕ трёхзначное !");
        number = 0;
    }
}

Console.WriteLine("Правильно, число " + number + " - трёхзначное");

int secondDigit = (number % 100) / 10;

Console.WriteLine("Вторая цифра :  " + secondDigit);