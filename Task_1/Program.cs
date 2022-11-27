//Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int numberA = int.Parse(Console.ReadLine());
int number_2;
if(numberA >= 100 & numberA <= 999 )
{
number_2  = numberA / 10;
number_2 = number_2 % 10;
Console.WriteLine($"Вторая цифра трехзначного числа равна: {number_2}");
}

if (numberA == 0 || numberA <= 99 || numberA >= 1000)
{
 Console.WriteLine("Число не 3-х значное!");   
};



