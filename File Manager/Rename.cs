using System;
using System.IO;

namespace TechnicalTask
{
	internal sealed class Rename : CheckDirOrFile
	{
        public void Rename(string path)
        {
            if (path[2] == 'f')
                FileRename(path);

            if (path[2] == 'd')
                DirRename(path);
        }


        private void FileRename(string path)   //информация о файле
        {
            path = FileIsExistOrNot(path);

            if (path != "")
            {
            }
        }

        private void DirRename(string path)  //информация о директории
        {
            path = DirectoryIsExistOrNot(path);

            if (path != "")
            {
                
            }
        }
    }
}

