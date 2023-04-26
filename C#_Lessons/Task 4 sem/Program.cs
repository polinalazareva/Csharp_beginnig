/*

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/

/*

System.Console.WriteLine("Введите число A");

int a = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите число B");

int b = int.Parse(Console.ReadLine());

double result = Math.Pow(a, b);

System.Console.WriteLine(result);

*/

/*

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

*/

/*

System.Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());

int result = 0;
while(number > 0){
result += number % 10;
number = number / 10;
}
System.Console.WriteLine(result);

*/

/*

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

*/
Random rand = new Random();

int[] array =  new int [8];

for (int i = 0; i < array.Length; i++)

{
    array[i] = new Random().Next();
    System.Console.WriteLine(array[i] + " ");

}
