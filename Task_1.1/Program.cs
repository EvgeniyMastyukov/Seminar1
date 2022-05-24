// Второй способ задачи Напишите программу, которая на вход принимает два числа и проверят, 
//является ли первое число квадратом второго: а = 5, b =25; a = 2, b = 10. 
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
bool num1sqare = num1*num1 == num2;
Console.WriteLine(num1sqare? "Да" : "Нет");