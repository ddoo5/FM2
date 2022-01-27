using System;
namespace TechnicalTask
{
    internal sealed class copy : CheckDirOrFile      // класс копирования файлов и директорий
    {
        public void Copy(string path)
        {
            if(path[2] == 'f')
                FlCopy(path);

            if (path[2] == 'd')
                DirCopy(path);
        }


        private void FlCopy(string path)  //крадем код у соседа
        {
            path = TwoFilesIsExistOrNot(path);

            if (path != "")
            {
                string[] file = path.Split(' ');
                File.Copy(file[0], file[1], true);
                UI.Copy();
            }
        }

        private void DirCopy(string path)   //копирование директории
        {
            path = TwoDirectoriesIsExistOrNot(path);

            if (path != "")
            {
                string[] dir1 = path.Split(' ');
                DirectoryInfo dir2 = new(dir1[0]);

                dir2.MoveTo(dir1[1]);
                UI.Copy();
            }
        }
    }
}