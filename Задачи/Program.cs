//Задача 1
//: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
{
    Console.Write("Введите трёхзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num <= 100 | num > 999)
    {
        Console.WriteLine("Что-то пошло не так, программа прервана: ");
    }
    else num = num / 10 % 10;
    {
        Console.WriteLine($"Вторая цифра введённого числа: {num}");
    }
}


//Задача 2
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
{

    Console.Write("Введи число: ");
    int anyNumber = Convert.ToInt32(Console.ReadLine());
    string anyNumberText = Convert.ToString(anyNumber);
    if (anyNumberText.Length > 2)
    {
        Console.WriteLine("третья цифра -> " + anyNumberText[2]);
    }
    else
    {
        Console.WriteLine("-> третьей цифры нет");
    }

}


//Задача 3
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

{
    Console.Write("Введи цифру, обозначающую день недели: ");
    int dayNumber = Convert.ToInt32(Console.ReadLine());

    void CheckingTheDayOfTheWeek(int dayNumber)
    {
        if (dayNumber == 6 || dayNumber == 7)
        {
            Console.WriteLine("(этот день выходной) -> да");
        }
        else if (dayNumber < 1 || dayNumber > 7)
        {
            Console.WriteLine("это вообще не день недели");
        }
        else Console.WriteLine("(этот день не выходной) -> нет");
    }

    CheckingTheDayOfTheWeek(dayNumber);
}