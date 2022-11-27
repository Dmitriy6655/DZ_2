// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int day_week = int.Parse(Console.ReadLine());
if (day_week >= 1 && day_week <= 5 )
{
  Console.WriteLine("Сегодня рабочий день.");   
}

if (day_week >= 6 && day_week <= 7 )
{
   Console.WriteLine("Ура!Сегодня выходной!");  
};