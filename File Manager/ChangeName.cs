using System;
namespace TechnicalTask
{
	internal sealed class ChangeName : CheckDirOrFile
	{
            public void Rename(string path)
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

                realPath[2] = FileIsExistOrNot(realPath[0] + " " + realPath[1] + " " + realPath[2]);

                if (realPath[2] != "")
                {
                    if (realPath[3] != null)
                    {
                        endPath = realPath[2].Split('/');

                        for (int i = 0; i < endPath.Length - 2; i++)
                        {
                            endPath[0] += "/" + endPath[1+i];
                        }
                        endPath[0] += "/" + realPath[3];

                        File.Move(realPath[2], endPath[0]);
                        UI.Success();
                    }
                }
            }

            private void DirRename(string path)  //переименование директории
            {
            string[] realPath = path.Split(' ');
            string[] endPath;

            realPath[2] = realPath[0] + " " + realPath[1] + " " + realPath[2];
            realPath[2] = DirectoryIsExistOrNot(realPath[2]);

            if (path != "")
            {
                if (realPath[3] != null)
                {
                    endPath = realPath[2].Split('/');

                    for (int i = 0; i < endPath.Length - 2; i++)
                    {
                        endPath[0] += "/" + endPath[1 + i];
                    }
                    endPath[0] += "/" + realPath[3];

                    Directory.Move(realPath[2], endPath[0]);
                    UI.Success();
                }
            }
        }
    }
}

