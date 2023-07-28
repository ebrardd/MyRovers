using MyRover;

namespace MyRovers
{
    enum Movement // numaralandırma,sabit liste olusturma belli türdeki degerleri tutmaya yarar.
    {
        W,//Yukarı
        D,//Sag
        S,//Asagı
        A,//Sol
        L,
        R,
        M
    }

    class program
    {

        static void Main()
        {
            string[] MenuChoices = new string[]
            {
            "Choice1","Choice2","Choice3" };
            int e = 0;
            //choice1=Enter a name,choice2=Move the rovers,choice3=check the rovers

            while (true)
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to Menu");
                    Console.WriteLine();

                    for (int i = 0; i < MenuChoices.Length; i++)
                    {
                        if (e == i)
                        {
                            Console.WriteLine(" " + MenuChoices[i] + "  {");
                        }
                        else
                        {
                            Console.WriteLine(MenuChoices[i]);
                        }
                    }
                    var key = Console.ReadKey();

                    if (key.Key == ConsoleKey.DownArrow && e != MenuChoices.Length - 1)
                    {
                        e++;
                    }
                    else if (key.Key == ConsoleKey.UpArrow && e
                               >= 1)
                    {
                        e--;
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        switch (e)
                        {
                            case 0:
                                MenuChoice1();
                                break;
                            case 1:
                                MenuChoice2();
                                break;
                            case 2:
                                MenuChoice3();
                                break;
                            case 3:
                                MenuChoice4();
                                break;
                        }
                    }
                }
        }

        public static void MenuChoice1()
        {

            //class2.second();
            Console.Clear();

            Console.ReadKey();
        }

        public static void MenuChoice2()
        {



            Console.Clear();

            Console.ReadKey();
        }
        public static void MenuChoice3()
        {
            Console.Clear();

            Console.ReadKey();


        }

        public static void MenuChoice4()
        {

            Console.Clear();

            Console.WriteLine("Press Enter To Exit The Menu");
            Console.ReadKey();
            Console.Clear();
            Environment.Exit(1);

            Console.Clear();
            Console.SetWindowSize(Plateau.Width + Plateau.InfoWidth, Plateau.Height);
            Console.SetBufferSize(Plateau.Width + Plateau.InfoWidth, Plateau.Height);
            Rover rover = new Rover();
            Movement movement = new Movement();

            ulong x = 0;
            ulong y = 0;
            x++;
            y++;
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo;
                while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
                {
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.L:
                            Console.ReadKey();
                            Console.WriteLine("turn left");
                            break;
                        case ConsoleKey.R:
                            Console.ReadKey();
                            Console.WriteLine("turn right");
                            break;
                        case ConsoleKey.M:
                            Console.ReadKey();
                            Console.WriteLine("Move 1 unit");
                            break;
                        case ConsoleKey.W:
                            Console.ReadKey();
                            Console.WriteLine("Move Up ");
                            break;
                        case ConsoleKey.D:
                            Console.ReadKey();
                            Console.WriteLine("Move right");
                            break;

                        case ConsoleKey.S:
                            Console.ReadKey();
                            Console.WriteLine("Move down");
                            break;

                        case ConsoleKey.A:
                            Console.ReadKey();
                            Console.WriteLine("Move left +1");
                            break;

                        default:
                            Console.WriteLine("Invalid key.");
                            break;

                    }
                }
                while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
                {
                    Console.WriteLine("Press a key");
                }













            }
        }
    }
}
 
