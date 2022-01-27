using System;
namespace TechnicalTask
{
	internal sealed class create :CheckDirOrFile  //создание 
	{
        public void Create(string path)
        {
            if (path[2] == 'f')
                FlCreate(path);
            if (path[2] == 'd')
                DirCreate(path);
        }


        private void FlCreate(string path)   //создаем файл
        {
            string[] realPath = path.Split(' ');
            realPath[2] =  "n" +  " dir " + realPath[2];    //получается сам себя взломал?

            realPath[2] = DirectoryIsExistOrNot(realPath[2]);

            if (realPath[2] != "")
            {
                File.Create(realPath[2] + "/" + realPath[3]);
                UI.Create();
            }
        }

        private void DirCreate(string path)  //создаем целую папку
        {
            string[] realPath = path.Split(' ');
            realPath[2] = realPath[0] + " " + realPath[1] + " " + realPath[2];

            realPath[2] = DirectoryIsExistOrNot(realPath[2]);

            if (realPath[2] != "")
            {
                Directory.CreateDirectory(realPath[2] + "/" +realPath[3]);
                UI.Create();
            }
        }
    }
}

