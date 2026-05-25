namespace Properties
{
  class Program
  {
    public int width {get;set;}
    public int height {get;set;} // 好处是不用单独写get和set

    public int area => width * height; // => 会变成了一个计算属性

    static void Main(string[] args)
    {
      var program = new Program();
      program.width = 5;
      program.height =10;
      System.Console.WriteLine(program.area);
      program.width = 10;
      System.Console.WriteLine(program.area);
    }
  }
}