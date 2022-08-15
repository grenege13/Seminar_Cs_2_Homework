// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int[] arrNum = number.ToString().Select(x => x - '0').ToArray();

if (number / 10 == 0 || number / 100 == 0)
{
    Console.WriteLine("В числе " + number + " нет 3ей цифры.");
}
else
Console.WriteLine("Третья цифра числа " + number + " : " + arrNum[2]);
