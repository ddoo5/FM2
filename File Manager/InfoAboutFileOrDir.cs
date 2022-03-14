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

            if (Directory.Exists(path))   //если единороги существуют, то...
            {
                UI.Success();

                string[] b = Directory.GetDirectories(path);      //хотел через 2, но мне сказали index was outside
                string[] d;
                string[] files;

                for (int i = 0; i < b.Length; i++)    //путь, который передал пользователь(на алгоритмах да, был(min n(если файлов нет), но я уже жду квантовые компьютеры))
                {
                    Console.WriteLine($"║ {b[i]}");

                    if (Directory.Exists(b[i]))   //если есть что-то глубже, то копаем
                    {
                        d = Directory.GetDirectories(b[i]);

                        for (int a = 0; a < d.Length; a++)  //естественно показываем
                        {
                            files = Directory.GetFiles(d[a]);

                            Console.WriteLine($" ╚║ { d[a]}");

                            foreach (string deepthFiles in files)  //файлы в папке папки(русский - крутой язык)
                            {
                                Console.WriteLine($"   ╚ {deepthFiles}");
                            }
                        }
                    }

                    files = Directory.GetFiles(b[i]);

                    for (int s = 0; s < files.Length; s++)     //файлы в папке по пути пользователя
                    {
                        Console.WriteLine($"  ╚ { files[s]}");
                    }
                }

                d = Directory.GetFiles(path);

                foreach (string filesInCurrentDirectory in d)     //вывод файлов просто по пути
                {
                    Console.WriteLine($"╚ { filesInCurrentDirectory}");
                }

                Console.WriteLine();

            }
            else  // ошибка
                UI.ErrorNotFound();
        }
    }
}

