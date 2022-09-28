// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// int InputNumber() // Ручной ввод целого пятизначного числа
// {
//     int Number=0;
//     while(Number<10000 || Number>99999)
//     {
//         Console.Write("Введите пятизначное число: "); 
//         Number=Convert.ToInt32(Console.ReadLine()); 
//     }
//     return Number;
// }

int InputNumber() // Ручной ввод целого числа
{
    Console.Write("Введите число: "); 
    return Convert.ToInt32(Console.ReadLine()); 
}

bool PalindromeCheck(int Number) //проверка на палиндромность числа
{
    if (Number<0)
    {
        return false;
    }
    int R=1;
    while ((int)(Number/Math.Pow(10,R))>0)  //нахождение разрядности числа
    {
        R++;
    }
    int i=0;
    while (i<R/2)          //проверка на палиндромность
    {
        if ((int)(Number/Math.Pow(10,R-i*2-1)) != Number%10)
        {
            return false;
        }
        else
        {
            Number=(int)((Number%Math.Pow(10,R-i*2-1))/10);
        }
        i++;
    }
    return true;
}


if (PalindromeCheck(InputNumber()))
{
    Console.WriteLine("Введенное число является палиндромом!!!"); 
}
else
{
    Console.WriteLine("Введенное число не является палиндромом."); 
}