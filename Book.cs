using System.Text;

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

    public void Addpagesnames(string[] files, List<string> names) {
        for (int i = 0; i < files.Length; i++)
        {
            Pages.Add(new Page(names[i], File.ReadAllText(files[i])));
        }
    }

    public void WriteFile() {
        Console.WriteLine("Please enter filename to be created");
        string fileName = Console.ReadLine().ToLower();

        Console.WriteLine("Enter content to be inserted into file :)");
        string fileContent = Console.ReadLine();

        string path = @"pages/"+fileName+".txt"; 

        using (FileStream fs = File.Create(path)) {
                byte[] info = new UTF8Encoding(true).GetBytes(fileContent);
                fs.Write(info, 0, info.Length);
        };

        Pages.Add(new Page(fileName, fileContent));
    }

    public void Start()
    {

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Title);
        Console.ResetColor();

        Console.WriteLine("\nWelcome to your programming notes. " +
        "This program will help you keep track of your notes " +
        "for your programming projects.\n");

        Console.ForegroundColor= ConsoleColor.Magenta;
        Console.WriteLine("Do you want to enter Write Mode or read pre-existing files?\nWrite/Read");
        string mode = Console.ReadLine().ToLower();


        while (mode == "write") {
            if (mode == "write") {
                WriteFile();
            }
            Console.WriteLine("Write another?\nY/N");
            mode = Console.ReadLine().ToLower();
        }

        Console.ResetColor();

        while (true)
        {
            //Print book title and introduction

            //Print chapter titles
            PrintPages();


            Console.WriteLine("\nEnter a chapter title (or 'quit/q/exit' to exit):");
            string input = Console.ReadLine().ToLower();
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