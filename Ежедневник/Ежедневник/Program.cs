namespace Ежедневник
{
    internal class Program
    {
        public static ConsoleKeyInfo put;
        public static int a = 0;
        public static int position = 2;
        public static int w = 0;
        public static int z = 0;
        public static int x = 0;
        static void Main(string[] args)
        {
            Perekluchenie_0();
        }
        static void colorconsole()
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
        }
        static void Perekluchenie_1()
        {
            Console.SetCursorPosition(0, position);
            Console.Write("->");
            do
            {
                put = Console.ReadKey();
                if (put.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, position--);
                    if (a == 0 && position == 1)
                    {
                        position++;
                    }
                    if (a == 1 && position == 1)
                    {
                        position++;
                    }
                    if (a == 2 && position == 1)
                    {
                        position++;
                    }
                    Console.Write("->");
                }
                else if (put.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, position++);
                    if (a == 0 && position == w)
                    {
                        position--;
                    }
                    if (a == 1 && position == z)
                    {
                        position--;
                    }
                    if (a == 2 && position == x)
                    {
                        position--;
                    }
                    Console.Write("->");
                }
                Console.Write("\r" + new string(' ', 2) + "\r");
                Console.SetCursorPosition(0, position);
                Console.Write("->");
            } while (put.Key == ConsoleKey.UpArrow | put.Key == ConsoleKey.DownArrow);
            if (put.Key == ConsoleKey.LeftArrow | put.Key == ConsoleKey.RightArrow)
            {
                switch (put.Key)
                {
                    case ConsoleKey.LeftArrow:
                        a--;
                        if (a == -1)
                            a = 2;
                        break;
                    case ConsoleKey.RightArrow:
                        a++;
                        if (a == 3)
                            a = 0;
                        break;
                }
                Perekluchenie_0();
            }
            else if (put.Key == ConsoleKey.Enter)
            {
                Perekluchenie_0();
            }
            if (put.Key == ConsoleKey.Escape)
            {
                return;
            }
        }
        public static void zametkaone()
        {
            List<string> zametki = new List<string>();
            zametki.Add("Выбрана дата 02.02.2023");
            zametki.Add("------------------------------------------");
            zametki.Add(" 1. Отметить день рождение");
            zametki.Add(" 2. Напиться с друзьями");
            w = zametki.Count;
            foreach (string item in zametki)
                Console.WriteLine(item);
        }
        public static void zametkatwo()
        {
            List<string> zametki = new List<string>();
            zametki.Add("Выбрана дата 06.02.2023");
            zametki.Add("------------------------------------------");
            zametki.Add(" 1. Сходить за правами");
            zametki.Add(" 2. Отметить бухлом");
            z = zametki.Count;
            foreach (string item in zametki)
                Console.WriteLine(item);
        }
        public static void zametkathree()
        {
            List<string> zametki = new List<string>();
            zametki.Add("Выбрана дата 07.02.2023");
            zametki.Add("------------------------------------------");
            zametki.Add(" 1. Сходить в автосолон");
            x = zametki.Count;
            foreach (string item in zametki)
                Console.WriteLine(item);
        }
        static void dopolnenie1()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Отметить день рождение");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Сходить в боулинг с друзьями как обычно");
            podzametki.Add("Дата: 02.02.2023");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void dopolnenie1_1()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Напиться с друзьями");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Как обычно");
            podzametki.Add("Дата: 02.02.2023");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void dopolnenie2()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Сходить за правами");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Сходить за правами в ГАИ");
            podzametki.Add("Дата: 06.02.2023");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void dopolnenie2_1()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Отметить бухлом");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Как обычно");
            podzametki.Add("Дата: 06.02.2023");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void dopolnenie3()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Сходить в автосолон");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Сходить в автосолон и пресмотреть себе машину" +
                "");
            podzametki.Add("Дата: 07.02.2023");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void Perekluchenie_0()
        {
            Console.Clear();
            do
            {
                do
                {
                    if (a == 0 && position == 2 && put.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        dopolnenie1();
                        put = Console.ReadKey();
                        if (put.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    else if (a == 0 && position == 3 && put.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        dopolnenie1_1();
                        put = Console.ReadKey();
                        if (put.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    if (a == 1 && position == 2 && put.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        dopolnenie2();
                        put = Console.ReadKey();
                        if (put.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    else if (a == 1 && position == 3 && put.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        dopolnenie2_1();
                        put = Console.ReadKey();
                        if (put.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    if (a == 2 && position == 2 && put.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        dopolnenie3();
                        put = Console.ReadKey();
                        if (put.Key ==
                        ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                } while (put.Key == ConsoleKey.Escape);
                switch (a)
                {
                    case 0:
                        Console.Clear();
                        zametkaone();
                        Perekluchenie_1();
                        return;
                    case 1:
                        Console.Clear();
                        zametkatwo();
                        Perekluchenie_1();
                        return;
                    case 2:
                        Console.Clear();
                        zametkathree();
                        Perekluchenie_1();
                        return;
                }
                put = Console.ReadKey();
                switch (put.Key)
                {
                    case ConsoleKey.LeftArrow:
                        a--;
                        switch (a)
                        {
                            case -1:
                                Console.Clear();
                                a = 2;
                                zametkatwo();
                                break;
                            case 0:
                                Console.Clear();
                                zametkaone();
                                break;
                            case 1:
                                Console.Clear();
                                zametkatwo();
                                break;
                            case 2:
                                Console.Clear();
                                zametkathree();
                                break;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        a++;
                        switch (a)
                        {
                            case 3:
                                Console.Clear();
                                a = 0;
                                zametkaone();
                                break;
                            case 0:
                                Console.Clear();
                                zametkaone();
                                break;
                            case 1:
                                Console.Clear();
                                zametkatwo();
                                break;
                            case 2:
                                Console.Clear();
                                zametkatwo();
                                break;
                        }
                        break;
                }
            } while (put.Key == ConsoleKey.LeftArrow | put.Key == ConsoleKey.RightArrow);
            if (put.Key == ConsoleKey.Escape)
            {
                return;
            }
        }
    }
}