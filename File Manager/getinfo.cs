using System;
namespace TechnicalTask
{
    internal sealed class getinfo  : CheckDirOrFile   //тут крадут информацию
    {
        public void InfoAbout(string path)
        {
            if (path[2] == 'f')
                InfoAboutFile(path);

            if (path[2] == 'd')
                InfoAboutDir(path);
        }


        private void InfoAboutFile(string path)   //информация о файле
        {
            path = FileIsExistOrNot(path);

            if (path != "")
            {
                if (File.Exists(path))
                {
                    UI.Success();

                    info.InfoF(path);
                }
            }
        }

        private void InfoAboutDir(string path)  //информация о директории
        {
            path = DirectoryIsExistOrNot(path);

            if (path != "")
            {
                if (Directory.Exists(path))
                {
                    UI.Success();

                    info.InfoD(path);
                }
            }
        }
    }
}

