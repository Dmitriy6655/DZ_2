// Напишите программу, которая выводит третью 
//цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число");
long numberA = long.Parse(Console.ReadLine());
long result = 0;

if(numberA < 100)
{
 Console.WriteLine("Третей цифры нет");  
}

while(numberA > 100 || numberA == 100)
{
    if(numberA < 1000)
    {
    result = numberA % 10;
    Console.WriteLine($"Третья цифра трехзначного числа равна: {result}");
    break;
    }
   
    else
    {
    numberA = numberA / 10;
    }

};





