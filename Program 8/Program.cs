// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int i=2;

Console.WriteLine("Четные числа в диапазоне от 1 до "+Number+":");
while (i<=Number)
{
    Console.Write(i+" ");
    i=i+2;
}