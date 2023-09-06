public class Page
{
    public string Content;
    public string Title;
    public Page(string title, string content) 
    {
        Content = content;
        Title = title;
    }

    public void Read() {
        Console.Clear();
        Console.WriteLine("\nPage contents:");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(Content);
        Console.ResetColor();
    }
}