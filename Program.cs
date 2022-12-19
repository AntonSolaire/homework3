// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


void palindrom (int N)
{
   if (N<10000 || N>99999) {
    Console.WriteLine("Ваше число не пятизначное");
   }
   else {
    int revers = 0;
    int copy = N;
    int diff = 0;
    while (N>0) {
        diff = N % 10;
        revers = revers*10 + diff;
        N = N / 10;
    }

    if (copy == revers)
    Console.WriteLine("Это полиндром");
    else
    Console.WriteLine("Это не полиндром");
   }
}

Console.WriteLine("Введите пятизначное число:");
int N = Convert.ToInt32(Console.ReadLine());
palindrom(N);



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// double distance (double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double dy = y1 - y2;
//     double dx = x1 - x2;
//     double dz = z1 - z2;
//     double d = Math.Round(Math.Sqrt(dx*dx + dy*dy + dz*dz),2);
//     return d;
// }

// Console.WriteLine("Введите X1:");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Y1:");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Z1:");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите X2:");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Y2:");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Z2:");
// double z2 = Convert.ToDouble(Console.ReadLine());

// double result = distance (x1,y1,z1,x2,y2,z2);

// if (result == 0)
// Console.WriteLine("Точки точки в одинаковых координатах");
// else
// Console.WriteLine($"Расстояние между точками {result}");



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void cubeNumber (int N)
// {
//     for (int i = 1; i <= N; i++)
//     {
//         Console.Write(Math.Pow(i,3)+" ");
//     }
// }

// Console.WriteLine("Введите число:");
// int N = Convert.ToInt32(Console.ReadLine());
// cubeNumber(N);