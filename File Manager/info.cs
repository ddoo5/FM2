using System;
using System.Security.Cryptography.X509Certificates;

namespace TechnicalTask
{
    internal static class info       // класс преобразования информации
    {
        public static void InfoD(string path)   // вывод информации о каталоге
        {
            if (Directory.Exists(path))
            {
                DirectoryInfo infoDir = new DirectoryInfo(path);

                Console.WriteLine($"name: {infoDir.Name}");
                Console.WriteLine($"last access time: {infoDir.LastAccessTime}");
                Console.WriteLine($"creation time: {infoDir.CreationTime}");
                Console.WriteLine($"root: {infoDir.Root}");
                Console.WriteLine($"attributes: {infoDir.Attributes}");
                Console.WriteLine($"parent: {infoDir.Parent}");

            }
        }

        public static void InfoF(string path)  // вывод информации о файле
        {
            if (File.Exists(path))
            {
                FileInfo file = new FileInfo(path);

                Console.WriteLine($"name: {file.Name}");
                Console.WriteLine($"directory: {file.DirectoryName}");
                Console.WriteLine($"creation time: {file.CreationTime}");
                Console.WriteLine($"last edit: {file.LastWriteTime}");
                Console.WriteLine($"size in bytes: {file.Length}");
                Console.WriteLine($"file exists: {file.Exists}");
                Console.WriteLine($"file format: {file.Extension}");
                Console.WriteLine($"last enter: {file.LastAccessTime}");
            }
        }
    }
}

