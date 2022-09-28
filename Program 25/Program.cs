// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int InputNumber(string text, int bottomlimit) // Ручной ввод целого числа
{
    int number=0;
    do
    {
        Console.Write(text); 
        number=Convert.ToInt32(Console.ReadLine()); 
    }while(number<bottomlimit);
    return number; 
}

int Power(int number, int power) // Возведение числа в степень
{
    int result=1;
    for(int i=1; i<=power; i++)
    {
        result*=number;
    }
    return result;
}

int a=InputNumber("Введите целое число: ",-2147483648);
int b=InputNumber("Введите натуральную степень числа "+a+": ",0);
Console.WriteLine(a+"^"+b+" = "+Power(a,b));