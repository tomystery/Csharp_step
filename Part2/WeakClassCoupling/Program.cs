

namespace ClassCoupling
{
  class Program
  {
    static void Main1(string[] args)
    {
      // 场景 A：今天想用邮件通知
      INotificationService emailService = new EmailNotificationService();
      var processor1 = new OrderProcessor(emailService);
      processor1.ProcessOrder(); // 打印：[Email] 您的订单已发货！

      // 场景 B：明天想换成短信通知，OrderProcessor 源码一字未改！
      INotificationService smsService = new SmsNotificationService();
      var processor2 = new OrderProcessor(smsService);
      processor2.ProcessOrder(); // 打印：[SMS] 您的订单已发货！
    }
  }
}