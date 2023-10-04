using DB_First.Abstract;
using DB_First.Concrete;

namespace DB_First;

internal class Program
{
    private static void Menu()
    {
        Creator? creator = null;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\tProject By Bahram Bayramzade");
            Console.WriteLine();
            var menu = new List<string>
            {
                "Books",
                "Authors",
                "Category",
                "Department",
                "Faculty",
                "Group",
                "Lib",
                "Press",
                "SCard",
                "Student",
                "TCard",
                "Teacher",
                "Theme",
                "About",
                "Exit"
            };


            int index = Choice(menu);
            switch (index)
            {
                case 0:
                    creator = new CreatorBook();
                    break;
                case 1:
                    creator = new CreatorAuthor();
                    break;
                case 2:
                    creator = new CreatorCategory();
                    break;
                case 3:
                    creator = new CreatorDepartment();
                    break;
                case 4:
                    creator = new CreatorFaculty();
                    break;
                case 5:
                    creator = new CreatorGroup();
                    break;
                case 6:
                    creator = new CreatorLib();
                    break;
                case 7:
                    creator = new CreatorPress();
                    break;
                case 8:
                    creator = new CreatorSCard();
                    break;
                case 9:
                    creator = new CreatorStudent();
                    break;
                case 10:
                    creator = new CreatorTCard();
                    break;
                case 11:
                    creator = new CreatorTeacher();
                    break;
                case 12:
                    creator = new CreatorTheme();
                    break;
                case 13:
                    Console.WriteLine(@"
    Special thanks to my dear teacher Nadir Zamanov!
    Aslo you can get my Telegram: https://t.me/baxram97 ");
                    break;
                case 14:
                    Environment.Exit(0);
                    break;
                default:
                    creator = null;
                    break;
            }

            if (creator == null) break;
            var library = creator.LibraryCreator();
            library.CreateLib();
            Console.ReadLine();
        }
    }

    private static int Choice(List<string> menu)
    {
        int index = 0;

        while (true)
        {
            foreach (var item in menu)
            {
                Console.ForegroundColor = menu.IndexOf(item) == index ? ConsoleColor.Green : ConsoleColor.Blue;
                Console.WriteLine($"\t\t{item}");
            }

            Console.WriteLine();

            ConsoleKey key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                {
                    index--;
                    if (index < 0) index += 5;
                    index %= menu.Count;
                    break;
                }
                case ConsoleKey.DownArrow:
                    index++;
                    index %= menu.Count;
                    break;
                case ConsoleKey.Enter:
                    return index;
            }

            Console.Clear();
        }
    }

    static void Main()
    {
        Menu();
    }
}