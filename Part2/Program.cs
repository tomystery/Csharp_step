namespace Indexers
{
  class Program
  {
    static void Main(string[] args)
    {
      var bookshelf = new Bookshelf();
      
      bookshelf.AddBook("C# in Depth2");
      bookshelf[0] = "C# in Depth1";
      System.Console.WriteLine(bookshelf[0]);
    }
  }
}