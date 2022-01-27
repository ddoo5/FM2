using System;
using System.IO;

namespace TechnicalTask
{
	internal sealed class Rename : CheckDirOrFile
	{
        public void rename(string path)
        {
            if (path[2] == 'f')
                FileRename(path);

            if (path[2] == 'd')
                DirRename(path);
        }


        private void FileRename(string path)   //меняем имя в паспорте
        {
            string[] realPath = path.Split(' ');
            string[] endPath;
            realPath[2] = "n" + " dir " + realPath[2];    //получается сам себя взломал?

            realPath[2] = DirectoryIsExistOrNot(realPath[2]);

            if (realPath[2] != "")
            {
                if(realPath[3] != null)
                {
                    endPath = realPath[2].Split('/');

                    for (int i = 0; i < endPath.Length - 1; i++)
                    {
                        endPath[0] += realPath[i];
                    }
                    endPath[0] += realPath[3];

                    File.Move(realPath[2], endPath[0]);
                    UI.Success(); 
                }
                UI.ErrorNotFound();
            }


        }

        private void DirRename(string path)  //переименование директории
        {
            path = DirectoryIsExistOrNot(path);

            if (path != "")
            {
                
            }
        }
    }
}

