// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке 
// от -N до  N: 4 --> -4, -3, -2, -1,0, 1,2,3,4; 2--> -2, -1, 0, 1, 2.
int num = int.Parse(Console.ReadLine());
int count = 0;
Console.WriteLine(num);
while (count <= 2*num +1)
{
    num = num - 1;
    Console.WriteLine(num);
}
count = count+1;

