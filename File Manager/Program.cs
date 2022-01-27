using TechnicalTask;

dir_file _check = new();     // тут вход классов; про конструкторы не, не слышал
delite _del = new();
getinfo _info = new();
copy _copy = new();
open _filOp = new();
create _create = new();

string userenter;

//3...2....1... старт!
//UI.WelcomeDrink();

while (true)
{
    try     // основной метод
    {
        userenter = Console.ReadLine();

        switch (userenter[0])
        {
            case 'h':
                UI.Help();
                break;
            case 'c':
                _copy.Copy(userenter);
                break;
            case 'd':
                _del.Delete(userenter);
                break;
            case 'i':
                _info.InfoAbout(userenter);
                break;
            case 'w':
                _check.DF(userenter);
                break;
            case 'o':
                _filOp.Open(userenter);
                break;
            case 'n':
                _create.Create(userenter);
                break;
            case 'e':
                UI.Examples();
                break;
            case 'r':
                //rename
                break;
            case 'm':
                //hacker mode
                break;

            default:       // ошибка пользователя
                UI.ErrorUser();
                break;
        }
        Console.WriteLine("");
    }

    catch (Exception a)       // не дает системе упасть на колени, книжка по психологии, если кратко
    {
        UI.ErrorSystem();
        Console.WriteLine(a);
    }
}
