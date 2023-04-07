

/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/

/*
Console.WriteLine("Введите два целых числа, чтобы узнать, какое из них больше, а какое - меньше");
Console.WriteLine("Введите первое число: ");

int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");

int b = int.Parse(Console.ReadLine());

if(a > b){
Console.WriteLine("max = " + a , "min = " + b);
}

if(b > a){
Console.WriteLine("max = " + b, "min = " + a);
}

else{
Console.WriteLine("Числа равны друг другу");
}

*/

//Не понимаю, почему если ввести первое число большее, чем второе, консоль выводит правильный результат, но в конце пишет "Числа равны друг другу". И не выводит значение min.//

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

/*

Console.WriteLine("Введите три целых числа, чтобы получить максимальное из них");
Console.WriteLine("Введите первое число: ");

int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");

int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число");

int c = int.Parse(Console.ReadLine());

if(a > b & a > c){
Console.WriteLine("max = " + a);
}

if(b > a & b > c){
Console.WriteLine("max = " + b);
}

if(c > b & c > a){
Console.WriteLine("max = " + c);
}

else{
Console.WriteLine("Введите три разных числа");
}

//Тут тоже не работает else:( //

*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/

/*

Console.WriteLine("Введите число, чтобы проверить, является ли оно четным");

int a = int.Parse(Console.ReadLine());

int b = a % 2;

if(b < 1 & b > -1){
Console.WriteLine("Число является четным");
}

else{
Console.WriteLine("Число является нечетным");
}

*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


/*

Console.WriteLine("Введите число N, чтобы увидеть все четные числа от 1 до N");

int a = int.Parse(Console.ReadLine());

int b = a;

while(b <= a){
Console.WriteLine($"{b},");
    b = b + 1;
}

//Не получилась:( //

*/