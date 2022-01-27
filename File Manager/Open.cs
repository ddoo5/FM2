using System;
using System.Reflection.PortableExecutable;

namespace TechnicalTask
{
	internal sealed class open :CheckDirOrFile  //подглядываем, да?
	{
        public void Open(string path)
        {
            if (path[2] == 'f')
                FlOpen(path);
        }


        private void FlOpen(string path)  //что за 'homework' на 11гб?
        {
            path = FileIsExistOrNot(path);

            if (path != "")
            {
                StreamReader reader = new(path);
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}

