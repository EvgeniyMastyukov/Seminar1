// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные
// числа от 1 до N. Примеры: 5 -> 2, 4; 8 -> 2, 4, 6, 8
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
//for (int i = 2; i<=a; i = i+2)                 //Первый способ
//{
  //  Console.WriteLine(i + " ");
//}
int i = 1;                                       // Второй способ    
while(i<=a)
{
    if (i%2 == 0) 
    Console.WriteLine(i);
    i=i+1;
}
