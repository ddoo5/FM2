using System;
namespace TechnicalTask
{
    internal static class UI     //веселый пользовательский интерфейс
    {
        private static void ChangeColorRed()  //смена цветов
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }

        private static void ChangeColorGreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        private static void ChangeColorCyan()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }

        private static void ResetColor()   //ресет
        {
            Console.ResetColor();
        }

        private static void Colorful(int i)   //радуга для приветствия
        {
            if (i == 2)
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (i == 6)
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (i == 10)
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (i == 14)
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (i == 16)
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (i == 18)
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (i == 20)
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (i == 24)
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (i == 28)
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (i == 30)
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (i == 32)
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (i == 35)
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (i == 38)
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (i == 40)
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (i == 43)
                Console.ForegroundColor = ConsoleColor.DarkCyan;
        }


        public static void Help()   //вывод подмоги
        {
            Console.WriteLine("h » help");
            Console.WriteLine("e » examples");
            Console.WriteLine("i f » information about file");
            Console.WriteLine("i dir » information about directory");
            Console.WriteLine("c f » copy file");
            Console.WriteLine("c dir » copy directory");
            Console.WriteLine("d f » delete file");
            Console.WriteLine("d dir » delete directory");
            Console.WriteLine("w » use to see 'tree' of files");
            Console.WriteLine("o f » use to open file");
            Console.WriteLine("n f » create file");
            Console.WriteLine("n dir » create directory");

        }

        public static void Examples()   //примерчики
        {
            Console.WriteLine("i f /Users/mac/test/test.xml");
            Console.WriteLine("i dir /Users/mac/test");
            Console.WriteLine("c f /Users/mac/test.txt /Users/mac/test2.txt  (first - file from u want to copy, second - where)");
            Console.WriteLine("c dir /Users/mac/test /Users/mac/test1  (test1 will be new directory)");
            Console.WriteLine("d f /Users/mac/test/test.txt");
            Console.WriteLine("d dir /Users/mac/test");
            Console.WriteLine("w /Users/mac");
            Console.WriteLine("o f /Users/mac/onlytextfile.docx");
            Console.WriteLine("n f /Users/mac/test1 moonlightsonate.txt (first - path, second - name of new file)");
            Console.WriteLine("n dir /Users/mac test3 (first - path too, second - name too, but of new directory)");
        }

        public static void WelcomeDrink()   //приветствие
        {
            string message = "Welcome to updated FM! \n";
            string message2 = "Thank's for using this progect, i'll do my best ^_^ \n";

            ChangeColorCyan();

            for (int i = 0; i < message.Length; i++)
            {
                Thread.Sleep(250);
                Console.Write(message[i]);

                Colorful(i);
            }

            for (int i = 0; i < message2.Length; i++)
            {
                Thread.Sleep(200);
                Console.Write(message2[i]);

                Colorful(i);
            }

            ChangeColorRed();
            Console.WriteLine("Don't forget to use 'h' !");

            ResetColor();

            Thread.Sleep(1250);
            Console.Clear();
        }

        public static void Success()   //для успешных людей
        {
            ChangeColorGreen();
            Console.WriteLine("Success");
            Console.WriteLine("");
            Thread.Sleep(700);
            ResetColor();
        }

        public static void IllusionOfWait()  //иллюзия
        {
            string _points = "...";

            ChangeColorCyan();
            Console.Write("Wait");

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(300);
                Console.Write(_points[i]);
            }

            Console.WriteLine("\n");
            ResetColor();
        }

        public static void Copy()  //подтверждение того, что скопировалось
        {
            ChangeColorGreen();
            Console.WriteLine("Copied");
            ResetColor();
        }

        public static void Delete()  //нужно было делать бэкап
        {
            ChangeColorGreen();
            Console.WriteLine("Deleted");
            ResetColor();
        }

        public static void Create()  //подтверждение того, что создалось
        {
            ChangeColorGreen();
            Console.WriteLine("Created");
            ResetColor();
        }


        public static void ErrorUser()   //ошибка пользователя в написании команды
        {
            ChangeColorRed();
            Console.WriteLine("You write something unusual, try to keep documentation");
            ResetColor();
        }

        public static void ErrorNotFound()   //пользователь не шарит, где у него файлы
        {
            ChangeColorRed();
            Console.WriteLine("Sorry, I can't find it  #_#");
            ResetColor();
        }

        public static void ErrorSystem()   //пользователь доигрался
        {
            ChangeColorRed();
            Console.WriteLine("Ops, I caught your exception  ^_^ \n" +
                "Check it:");
            ResetColor();
        }
    }
}

