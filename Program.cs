using System;

enum Day
{
    Понедельник,
    Вторник,
    Среда,
    Четверг,
    Пятница,
    Суббота,
    Воскресенье
}

enum Time
{
    Утро,
    День,
    Вечер,
    Ночь
}

public class Program
{


    public static void Main()
    {
        string result = "";
        Console.Write("Введите день недели: ");
        string day = Console.ReadLine();

        switch (day)
        {
            case "Понедельник":
                result += "Сейчас " + Day.Понедельник; break;
            case "Вторник":
                result += "Сейчас " + Day.Вторник; break;
            case "Среда":
                result += "Сейчас " + Day.Среда; break;
            case "Четверг":
                result += "Сейчас " + Day.Четверг; break;
            case "Пятница":
                result += "Сейчас " + Day.Пятница; break;
            case "Суббота":
                result += "Сейчас " + Day.Суббота; break;
            case "Воскресенье":
                result += "Сейчас " + Day.Воскресенье; break;
            default: Console.WriteLine("Ошибка"); System.Environment.Exit(1); break;
        }

        Console.Write("Введите время в часах: ");
        if (int.TryParse(Console.ReadLine(), out int time))
        {
            if (time >= 0 && time <= 6)
            {
                Console.WriteLine(result + ", " + Time.Ночь);
            }
            else if (time >= 7 && time <= 12)
            {
                Console.WriteLine(result + ", " + Time.Утро);
            }
            else if (time >= 13 && time <= 18)
            {
                Console.WriteLine(result + ", " + Time.День);
            }
            else if (time >= 19 && time <= 23)
            {
                Console.WriteLine(result + ", " + Time.Вечер);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
        else
        {
            Console.WriteLine("Ошибка");
            System.Environment.Exit(1);
        }
    }
}
