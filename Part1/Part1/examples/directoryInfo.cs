//Directory
var folderPath = @"/Users/yangran/Desktop/unknown_words";
Directory.CreateDirectory(folderPath);//
var files = Directory.GetFiles(folderPath,"*.txt", SearchOption.AllDirectories); // 获取目录下所有的 .txt 文件，包括子目录
foreach (var file in files)
{
  Console.WriteLine(file);
}

System.Console.WriteLine("-------------------");

//DirectoryInfo 实例类（适合频繁操作同一个目录）
var directoryInfo = new DirectoryInfo(folderPath);
var txtFiles = directoryInfo.GetFiles("*.txt", SearchOption.AllDirectories); // 获取目录下所有的 .txt 文件，包括子目录
System.Console.WriteLine(txtFiles);
foreach (var file in txtFiles)
{
  Console.WriteLine(file.FullName);
}
var subDirectories = directoryInfo.GetDirectories(); // 获取子目录  
System.Console.WriteLine(subDirectories);
