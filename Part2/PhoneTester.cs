namespace UpCasting
{
  class PhoneTester
  {
     //downCasting

    // 假设我们在刚才的维修店方法里，想对 iPhone 进行特殊处理：
    public void TestPhone(Phone phone)
    {
      phone.Call(); // 通用测试

      // 🚀 安全的 Downcasting：如果是 IPhone，就把它装进真实口袋 'applePhone' 里
      if (phone is IPhone applePhone)
      {
        // 此时 applePhone 已经是 IPhone 类型了
        applePhone.UseFaceID(); // ✅ 成功调用子类特有方法！
      }
    }
  }
}