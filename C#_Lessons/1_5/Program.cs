Console.WriteLine("Напишите число N, чтобы посмотреть все целые числа в промежутке от -N до N");

int number = int.Parse(Console.ReadLine());

int a = -number;

while(a <= number){
Console.Write($"{a},");
    a = a + 1;
}

 