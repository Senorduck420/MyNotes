using System.Text;

List<Page> pages = new List<Page>();

Book lebook = new Book("GUUUHHH", pages);

string variableText = File.ReadAllText(@"pages\variables.txt", Encoding.UTF8);
Page variables = new Page("variables", variableText);

string loopText = File.ReadAllText(@"pages\loops.txt", Encoding.UTF8);
Page loops = new Page("loops", loopText);

string classsesText = File.ReadAllText(@"pages\classes.txt", Encoding.UTF8);
Page classes = new Page("classes", classsesText);

pages.Add(variables);
pages.Add(loops); 
pages.Add(classes);




lebook.Start();