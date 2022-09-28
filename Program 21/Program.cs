// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int InputNumber(string C) // Ручной ввод координаты
{
    Console.Write($"Введите {C}: "); 
    return Convert.ToInt32(Console.ReadLine()); 
}

double Get3DDistance(int X1, int Y1, int Z1, int X2, int Y2, int Z2) // Нахождение расстояния между двумя точками в 3D
{
    return Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2)+Math.Pow(Z2-Z1,2));
}

Console.WriteLine("Расстояние между точками: "+Get3DDistance(InputNumber("X1"),InputNumber("Y1"),InputNumber("Z1"),InputNumber("X2"),InputNumber("Y2"),InputNumber("Z2")));