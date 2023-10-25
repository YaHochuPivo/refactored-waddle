// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.Clear();
    DateTime d = new DateTime(2023, 10, 10);
    Console.WriteLine(d);
    Console.WriteLine("  1.Прогулять пары");
    Console.WriteLine("  2.Пойти на пары");
    int pos = 1;
    ConsoleKeyInfo info;
    ConsoleKeyInfo exit;
    do

    {
        Console.SetCursorPosition(0, pos);
        Console.WriteLine("->");
        info = Console.ReadKey();
        Console.SetCursorPosition(0, pos);
        Console.WriteLine("  ");
        if (info.Key == ConsoleKey.UpArrow && pos != 1)
        {
            pos--;

        }
        else if (info.Key == ConsoleKey.DownArrow && pos != 2)
        {
            pos++;
        }
        else if (info.Key == ConsoleKey.RightArrow)
        {
            Console.Clear();
            d = d.AddDays(1);
            Console.WriteLine(d);
            Console.WriteLine("  1.Съесть булочку с корицей на перемене");
            Console.WriteLine("  2.Ничего не есть");
        }
        else if (info.Key == ConsoleKey.LeftArrow)
        {
            Console.Clear();
            d = d.AddDays(-1);
            Console.WriteLine(d);
            Console.WriteLine("  1.Нарисовать рисунок");
        }
    }

    while (info.Key != ConsoleKey.Enter);
    {
        {


            {

                if (pos == 1 && d == new DateTime(2023, 10, 10))
                {

                    {
                        Console.Clear();
                        Console.WriteLine(d);
                        Console.WriteLine("Прогулять пары");
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine("Ты прогулял пары и поехал спать домой");

                    }
                }
                if (pos == 2 && d == new DateTime(2023, 10, 10))
                {
                    Console.Clear();
                    Console.WriteLine(d);
                    Console.WriteLine("Пойти на пары");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Ты отсидел 4 пары и очень устал");
                }
            }

        }

        while (d == new DateTime(2023, 10, 11))
        {



            if (pos == 1)
            {
                Console.Clear();
                Console.WriteLine(d);
                Console.WriteLine("Съесть булочку с корицей на перемене");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Ты так долго наслаждался булочкой, что опоздал на пару. Зато ты не голодный.");

            };
            if (pos == 2)
            {
                Console.Clear();
                Console.WriteLine(d);
                Console.WriteLine("Ничего не есть");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Ты остался голодным и грустным, зато не опоздал на пару");
            }
        while (d == new DateTime(2023, 10, 9))
        {

            if (pos == 1)
            {
                Console.Clear();
                Console.WriteLine(d);
                Console.WriteLine("Нарисовать рисунок");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Ты нарисовал пляж, шезлонги, море и яркое солнце. Как жаль, что у тебя нет денег на Мальдивы....");

            };


        }
            break;
        }
        Console.ReadKey();

    }


}


















