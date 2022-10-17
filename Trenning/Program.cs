Console.WriteLine("Введите первое число: ");
int inputA= int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int inputB = int.Parse(Console.ReadLine()!);

if(inputA == inputB * inputB)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


