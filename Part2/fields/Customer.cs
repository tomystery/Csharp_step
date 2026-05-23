namespace Fields;

public class Customer
{
    public int Id;
    public string? Name;
    public  List<Order> Orders = new List<Order>();

    public Customer()
    {
        
    }

    //走这步就没有初始化Orders了，所以就会报错，所以一开始就应该初始化Orders
    public Customer(int id)
    {
        this.Id = id;
    }

    public Customer(int id, string name) : this(id)
    {
        this.Name = name;
    }

    public void Promote()
    {
        Orders = new List<Order>();
    }
}
