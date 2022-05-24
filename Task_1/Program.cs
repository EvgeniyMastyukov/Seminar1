// Первый способ задачи Напишите программу, которая на вход принимает два числа и проверят, 
//является ли первое число квадратом второго: а = 5, b =25; a = 2, b = 10. 

Console.WriteLine("Первое число a = ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Второе число b = ");
int b = int.Parse(Console.ReadLine());

if (a*a == b)
{
    Console.WriteLine("a - квадрат b");
}
else
{
    Console.WriteLine("a - не квадрат b");
}