namespace UpCasting
{
  public class Phone
  {
    public void Call() => Console.WriteLine("打电话中...");
  }

  public class IPhone : Phone
  {
    public void UseFaceID() => Console.WriteLine("使用 FaceID 解锁成功！");
  }
  
}