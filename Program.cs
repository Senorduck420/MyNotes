List<Page> pages = new List<Page>();

Book lebook = new Book("GUUUHHH", pages);

Page variables = new Page("variables", MyNotes.VariablesPageOne);
Page loops = new Page("loops", MyNotes.loopspage);
Page classes = new Page("classes", MyNotes.classespage);
pages.Add(variables);
pages.Add(loops); 
pages.Add(classes);




lebook.Start();