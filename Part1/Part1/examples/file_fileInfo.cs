//File
/* using System.IO;
var path = @"/Users/yangran/Desktop/test.txt";
// File.Copy(path, @"/Users/yangran/Desktop/ran_yang_test.pdf", true); // 复制文件，第三个参数表示如果目标文件已经存在，是否覆盖

if (File.Exists(path)) // 检查文件是否存在
{
  // File.Delete(path); // 删除文件
  var content = File.ReadAllText(path); // 读取文件内容
  Console.WriteLine(content);
  Console.WriteLine("File exists.");
}
else
{
  Console.WriteLine("File does not exist.");
} */

//fileInfo 实例类  （适合频繁操作同一个文件）
/* var fileInfo = new FileInfo(path);
if (fileInfo.Exists)
{
  var text = File.ReadAllText(fileInfo.FullName);
  Console.WriteLine(text);
  Console.WriteLine(fileInfo.Length);

  Console.WriteLine(fileInfo.Extension);
} */




