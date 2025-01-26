using Composite;

var root = new DirectoryElement("root");

DirectoryElement subFolder1 = new DirectoryElement("folder1");
DirectoryElement subFolder2 = new DirectoryElement("folder2");


FileElement file1 = new FileElement ("file1");
FileElement file2 = new FileElement ("file2");
FileElement file3 = new FileElement("file3");
FileElement file4 = new FileElement("file4");




root.AddElement(subFolder1);
subFolder1.AddElement(subFolder2);
subFolder1.AddElement(file1);
subFolder1.AddElement (file2);

root.AddElement(file3);

subFolder2.AddElement(file4);



Console.WriteLine("root count " + root.GetCount());

Console.WriteLine("Subfoler1 count :" + subFolder1.GetCount());

Console.WriteLine("File1 count " + file1.GetCount());

