namespace ClassCoupling
{
  public interface INotificationService
  {
    void Send(string message); // 所有人都要遵守这个行为规范
  }

  // 邮件通知实现
  public class EmailNotificationService : INotificationService
  {
    public void Send(string message)
    {
      Console.WriteLine($"[Email] {message}");
    }
  }

  // 短信通知实现（随时可以新增，不影响老代码）
  public class SmsNotificationService : INotificationService
  {
    public void Send(string message)
    {
      Console.WriteLine($"[SMS] {message}");
    }
  }

  public class OrderProcessor
  {
    private readonly INotificationService _notificationService; // 👍 依赖抽象接口

    // 👍 通过构造函数把工具传进来，而不是自己去 new
    public OrderProcessor(INotificationService notificationService)
    {
      _notificationService = notificationService;
    }

    public void ProcessOrder()
    {
      Console.WriteLine("订单处理完成。");

      // 至于到底是发邮件还是发短信，OrderProcessor 根本不关心！
      _notificationService.Send("您的订单已发货！");
    }
  }
}