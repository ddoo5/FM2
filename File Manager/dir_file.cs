using System;
using System.IO;

namespace TechnicalTask
{
    internal sealed class dir_file : CheckDirOrFile  // класс, который выводит каталоги с файлами
    {
        public void DF(string path)
        {
            Console.Clear();
            path = path.Remove(0,2);

            UI.IllusionOfWait();

            if (Directory.Exists(path))
            {
                UI.Success();

                string[] b = Directory.GetDirectories(path);
                string[] d = Directory.GetFiles(path);

                foreach (string directories in b)  // вывод каталога
                {
                    Console.WriteLine($"║ {directories}");
                }

                foreach (string files in d)     //вывод файлов
                {
                    Console.WriteLine($" ║ { files}");
                }

                Console.WriteLine();

            }
            else  // ошибка
                UI.ErrorNotFound();
        }
    }
}

