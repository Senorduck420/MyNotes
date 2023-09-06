using System.Text;

List<Page> pages = new List<Page>();

Book lebook = new Book("GUUUHHH", pages);

string[] files = Directory.GetFiles("pages");

string variableText = File.ReadAllText(files[2], Encoding.UTF8);
Page variables = new Page("variables", variableText);

string loopText = File.ReadAllText(files[1], Encoding.UTF8);
Page loops = new Page("loops", loopText);

string classsesText = File.ReadAllText(files[0], Encoding.UTF8);
Page classes = new Page("classes", classsesText);

pages.Add(variables);
pages.Add(loops); 
pages.Add(classes);




lebook.Start();