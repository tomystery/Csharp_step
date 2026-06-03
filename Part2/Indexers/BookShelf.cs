namespace Indexers
{

  /* 
  1. 索引器长的像属性，也有get和set
  2. 索引器有this关键字，代表当前对象
  3. 索引器可以重载
   */
  class Bookshelf
  {
    private readonly List<string> _books = new List<string>();

    public void AddBook(string book)
    {
      _books.Add(book);
    }
    public string this[int index]
    {
      get
      {
        if(index < 0 || index >= _books.Count)
        {
         throw new IndexOutOfRangeException("你找的格子没有放书"); 
        }
        return _books[index];
      }
      set
      {
        if(index < 0 || index >= _books.Count)
        {
          throw new IndexOutOfRangeException("你找的格子无法放书");
        }
        _books[index] = value;
      }
    }
  }
}