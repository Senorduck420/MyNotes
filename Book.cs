public class Book
{
    public string Title;
    public List<Page> Pages;
    public Book(string title = "Programming notes")
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Title = title;
        Pages = new List<Page>();
    }

    public Book(string title, List<Page> pages)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Title = title;
        Pages = pages;
    }

    /*public void PrintChapters()
    {
        //Print chapter titles
        Console.WriteLine("\nChapter titles:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (Chapter chapter in Chapters)
        {
            Console.WriteLine(chapter.Title);
        }
        Console.ResetColor();
    }*/

    public void PrintPages()
    {
        //Print page titles
        Console.WriteLine("\nPages titles:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (Page page in Pages)
        {
            Console.WriteLine(page.Title);
        }
        Console.ResetColor();
    }

    /*private Chapter GetChapter(string title)
    {
        foreach (Chapter chapter in Chapters)
        {
            if (chapter.Title == title)
            {
                return chapter;
            }
        }
        return null;
    }*/

     private Page GetPages(string title)
    {
        foreach (Page page in Pages)
        {
            if (page.Title == title)
            {
                return page;
            }
        }
        return null;
    }
    public string RecursiveWriteLine(string text)
    {
        if (text.Length == 0)
        {
            return "";
        }
        else
        {
            Console.Write(text[0]);
            Thread.Sleep(1);
            return RecursiveWriteLine(text.Substring(1));
        }
    }

    public static void WriteLine(string text)
    {
        foreach (char letter in text)
        {
            Console.Write(letter);
            Thread.Sleep(1);
        }
    }

    public List<string> LoadPageNames(string[] files) {
        List<string> names = new List<string>();
        for(int i = 0; i < files.Length; i++) {
            names.Add(files[i].Substring(6, files[i].Length-10));
        }
        return names;
    }

    public void Start()
    {

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Title);
        Console.ResetColor();

        Console.WriteLine("\nWelcome to your programming notes. " +
        "This program will help you keep track of your notes " +
        "for your programming projects.\n");

        while (true)
        {
            //Print book title and introduction

            //Print chapter titles
            PrintPages();


            Console.WriteLine("\nEnter a chapter title (or 'quit/q/exit' to exit):");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit" || input.ToLower() == "q" || input.ToLower() == "exit")
            {
                break;
            }
            Page chapterToRead = GetPages(input);
            if (chapterToRead == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Page not found.\n");
                Console.ResetColor();
                continue;
            }
            chapterToRead.Read();

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}