// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

if (A>B)
{
   Console.WriteLine("Первое число больше второго числа");
}
else 
{
    if (B>A)
    {
       Console.WriteLine($"Второе число больше первого числа");
    }
    else
    {
       Console.WriteLine($"Числа равны"); 
    }
}