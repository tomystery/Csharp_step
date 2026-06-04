namespace UpCasting
{
  class Program
  {

    //upCasting
    /* static void Main(string[] args)
    {
      IPhone myIPhone = new IPhone();
      myIPhone.Call();

      Phone myPhone = myIPhone; // Upcasting
      myPhone.Call();
      myPhone.UseFaceID(); // 编译错误：Phone 类没有 UseFaceID 方法
    } */



   
    static void Main(string[] args)
    {
      Phone myPhone = new IPhone(); // Upcasting
      PhoneTester tester = new PhoneTester();
      tester.TestPhone(myPhone);
    }
  }
}