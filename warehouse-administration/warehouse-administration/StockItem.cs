namespace WarehouseAdministration;

public class StockItem
{
    public int Quantity { get; private set; }
    public Product Product { get; private set; }
    
    public StockItem(int quantity, Product product)
    {
        Quantity = quantity;
        Product = product;
    }
    
    public void IncreaseQuantity(int quantity)
    {
        Quantity += quantity;
    }
    
    public void DecreaseQuantity(int quantity)
    {
        if (Quantity <= 0) return;
        Quantity -= quantity;
        
        if (Quantity < 0) Quantity = 0;
    }   
}