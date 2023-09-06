using System.Text;

List<Page> pages = new List<Page>();

Book lebook = new Book("The Book Of Goon", pages);

string[] files = Directory.GetFiles("pages");

List<string> names = lebook.LoadPageNames(files);
lebook.Addpagesnames(files, names);

lebook.Start();