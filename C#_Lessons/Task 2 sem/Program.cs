/*

Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

/*

System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if(number > 99 | number < 1000){
int result = number / 10 % 10;
System.Console.WriteLine(result);
}

else{
System.Console.WriteLine("Введите трехзначное число");
}

*/

/*

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

*/



System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int length = number.Length;

не получается:(




/*

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет


Console.WriteLine("Напишите номер, соответствующий дню недели");

string input = Console.ReadLine();

int number = int.Parse(input);

if(number == 1){
Console.WriteLine("нет");
}

if(number == 2){
Console.WriteLine("нет");
}

if(number == 3){
Console.WriteLine("нет");
}

if(number == 4){
Console.WriteLine("нет");
}

if(number == 5){
Console.WriteLine("нет");
}

if(number == 6){
Console.WriteLine("да");
}

if(number == 7){
Console.WriteLine("да");
}

if(number > 7){
Console.WriteLine("Такого дня недели нет");
}

if(number < 1){
Console.WriteLine("Такого дня недели нет");
}

*/