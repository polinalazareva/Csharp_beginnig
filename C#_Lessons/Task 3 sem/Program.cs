/*

Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да


System.Console.WriteLine("Введите пятизначное число, чтобы узнать, является ли оно палиндромом");

string number = Console.ReadLine();

int size = number.Length;

if(size == 5){
    if(number[0] == number [4] & number[1] == number [3]){
    System.Console.WriteLine($"Число {number} является палиндромом");}
    else{
    System.Console.WriteLine($"Число {number} не является палиндромом");
    }
}
else{
System.Console.WriteLine("Введите пятизначное число");
}

*/


/*

Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

*/

System.Console.WriteLine("Введите координаты точки А");

int xa = int.Parse(Console.ReadLine());
int ya = int.Parse(Console.ReadLine());
int za = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B");

int xb = int.Parse(Console.ReadLine());
int yb = int.Parse(Console.ReadLine());
int zb = int.Parse(Console.ReadLine());

int a = (xb - xa);
int b = (yb - ya);
int c = (zb - za);

double result = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2));
System.Console.WriteLine(result);
// AB = √ (xb - xa) 2+ (yb - ya) 2+ (zb - za) 2

/*

Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/

/*

System.Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());

int x = 0;

while(x < number){
x++;
int result = x * x * x;
System.Console.WriteLine(result);
};

if(number < 0){
System.Console.WriteLine("Введите положительное число");
}

*/