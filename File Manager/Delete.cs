using System;
namespace TechnicalTask
{
    internal sealed class delite :CheckDirOrFile   // класс удаления файлов и каталогов
    {
        public void Delete(string path)
        {
            if (path[2] == 'f')
                FlDelete(path);

            if (path[2] == 'd')
                DirDelete(path);
        }


        private void FlDelete(string path)  //выкидываем файл
        {
            path = FileIsExistOrNot(path);

            if (path != "")
            {
                if (File.Exists(path))
                {
                    File.Delete (path);
                    UI.Delete();
                }
            }
        }

        private void DirDelete(string path)  //зачем же папка System64?
        {
            path = DirectoryIsExistOrNot(path);

            if (path != "")
            {
                if (Directory.Exists(path))
                {
                    string[] deleter = Directory.GetFiles(path);
                    string[] deleterDir = Directory.GetDirectories(path);

                    for (int i = 0; i < deleter.Length; i++)
                    {
                        File.Delete(deleter[i]);
                    }
                    for (int i = 0; i < deleterDir.Length; i++)
                    {
                        Directory.Delete(deleterDir[i]);
                    }

                    Directory.Delete(path);
                    UI.Delete();
                }
            }
        }
    }
}

