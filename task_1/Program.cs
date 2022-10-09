/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/ 

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int rem = 0;
int sum = 0;
int temp = number;

while (Convert.ToBoolean(number))
{
    rem = number % 10;
    number = number / 10;
    sum = sum * 10 + rem;
}
if (temp == sum)
{
    Console.WriteLine($"{temp} является палиндромом");
}
else
{
    Console.WriteLine($"{temp} не является палиндромом");
}