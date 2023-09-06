Book lebook = new Book();
List<Chapter> chapters = new List<Chapter>();
List<Page> variablepages= new List<Page>();

Page variablerpage = new Page(MyNotes.VariablesPageOne);
Page variablerpage2 = new Page(MyNotes.VariablesPageTwo);
variablepages.Add(variablerpage);
variablepages.Add(variablerpage2);

Chapter variabler =new Chapter("Variabler");
Chapter data = new Chapter("Datatyper"); 
chapters.Add(data);
chapters.Add(variabler);




lebook.Start();