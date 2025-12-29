namespace WarehouseAdministration;

public class Product
{
    public string Name { get; private set; }
    public int Price { get; private set; }
    public int ProductId { get; private set; }
    
    public Product(string name, int price, int productId)
    {
        Name = name;
        Price = price;
        ProductId = productId;
    }
    
}