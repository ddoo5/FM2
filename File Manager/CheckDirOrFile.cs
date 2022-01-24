using System;
namespace TechnicalTask
{
    internal class CheckDirOrFile    //класс, который проверяет существование жизни на земле
    {
        private string _b = "";


        private string Beta
        {
            get { return _b; }
            set { _b = value; }
        }


        public string  FileIsExistOrNot(string a)  //для 1^го файла
        {
            if (a[2] == 'f')
            {
                UI.IllusionOfWait();
                Beta = a.Remove(0, 4);
                 return Beta;
            }

            else
            {
                UI.ErrorUser();
                return "";
            }
        }

        public string TwoFilesIsExistOrNot(string a)    //для 2^х файлов /filea..... /fileb..... 
        {
            string[] file = a.Split(' ');

            if (File.Exists(file[0]) == File.Exists(file[1]))
            {
                return file[0] + " " + file[1];
            }
            else
            {
                UI.ErrorNotFound();
                return "";
            }
        }


        public string DirectoryIsExistOrNot(string a)   //для 1^го ввода
        {
            if (a[2] == 'd')
            {

                if (a[3] == 'i')
                {

                    if (a[4] == 'r')
                    {
                        Beta = a.Remove(0, 6);

                        if (Directory.Exists(Beta))
                        {
                            UI.IllusionOfWait();
                            return Beta;
                        }

                        else
                        {
                            UI.ErrorNotFound();
                            return "";
                        }
                    }

                    else
                    {
                        UI.ErrorUser();
                        return "";
                    }
                }

                else
                {
                    UI.ErrorUser();
                    return "";
                }
            }

            else
            {
                UI.ErrorUser();
                return "";
            }
        }

        public string TwoDirectoriesIsExistOrNot(string a)   //2 ввода /Users.... /Users.....
        {
            if (a[2] == 'd')
            {

                if (a[3] == 'i')
                {

                    if (a[4] == 'r')
                    {
                        Beta = a.Remove(0, 6);
                        string[] dir1 = Beta.Split(' ');

                        if (Directory.Exists(dir1[0]) && Directory.Exists(dir1[1]) == false)
                        {
                            UI.IllusionOfWait();
                            return dir1[0] + " " + dir1[1];
                        }
                        else
                        {
                            UI.ErrorNotFound();
                             return "";
                        }
                    }

                    else
                    {
                        UI.ErrorUser();
                        return "";
                    }
                }

                else
                {
                    UI.ErrorUser();
                    return "";
                }
            }

            else
            {
                UI.ErrorUser();
                return "";
            }
        }
    }
}

