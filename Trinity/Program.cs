//Проверяем правилтность работы команды координат и знак обозначения выбранной координаты:
//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");
//Устанавливаем значения координат для первых 3х точек:
int xa = 1, ya = 1;
int xb = 1, yb = 30;
int xc = 80, yc = 30;
//Вводим значения на вывод в консоль:
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
//Определяем случайную точку:
int x = xa, y = ya; //в качестве случайной выбрана первая точка.
//Вводим кол-во циклов
int count = 10000;
//Далее идет цикл:
while (count < 10000)
{
    int what.new Random().Next(0, 3);
    //вводим рандомное переменное от 0 до 2 [0,1,2]

    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}

