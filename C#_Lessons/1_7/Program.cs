/*Задача No7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. */;

Console.WriteLine("Введите трехзначное число, чтобы увидеть последнюю цифру этого числа");
int number = int.Parse(Console.ReadLine());

if(number < 1000 & number > 99){

Console.WriteLine(number % 10);
}

else{
Console.WriteLine("Введите трехзначное число");
}

