// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
// Например:
// ● 78 -> 8
// ● 12-> 2
// ● 85 -> 8

/*

Random random = new Random();
int randomValue = random.Next(10, 100);

int lastDigit = randomValue % 10;
int firstDigit = randomValue / 10;

Console.WriteLine(randomValue);

if(lastDigit > firstDigit)
{
    Console.WriteLine(lastDigit);
}
else{
    Console.WriteLine(firstDigit);
}
int b = 5;

*/

/* Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
● 456 -> 46
● 782 -> 72
● 918 -> 98
*/

Random random = new Random();
int randomValue = random.Next(100, 1000);

System.Console.WriteLine(randomValue);

int firstDigit = randomValue / 100;
int lastDigit = randomValue % 10;

System.Console.Write(firstDigit);
System.Console.WriteLine(lastDigit);