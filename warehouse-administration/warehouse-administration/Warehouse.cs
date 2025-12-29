namespace WarehouseAdministration;

public class Warehouse
{
    public List<Product> Products { get; private set; }
    public List<StockItem> StockItems { get; private set; }

    public Warehouse()
    {
        Products = new List<Product>();
        StockItems = new List<StockItem>();
    }

    public void AddProduct(Product product, int initialQuantity)
    {

        if (Products.Any(p => p.ProductId == product.ProductId))
        {
            throw new Exception("Product ID already exists. Please choose another one.");
        }
        
        Products.Add(product);
        StockItems.Add(new StockItem(initialQuantity, product));
    }

    public void UpdateStock(int productId, int change)
    {

        var stockItem = StockItems.Find(s => s.Product.ProductId == productId);
        
        if (stockItem == null)
            throw new Exception("Product not found");
        
        switch (change)
        {
            case > 0:
                stockItem.IncreaseQuantity(change);
                break;
            case < 0:
                stockItem.DecreaseQuantity(Math.Abs(change));
                break;
        }
    }

    public void PrintStock()
    {
        var stockArr = 
            StockItems
                .Select(s => $"ID: {s.Product.ProductId} | Name: {s.Product.Name} | Qty: {s.Quantity} | Price: {s.Product.Price}")
                .ToArray();
        
        Console.WriteLine("Current Stock Overview:");
        for (int i = 0; i < stockArr.Length; i++)
        {
            Console.WriteLine(stockArr[i]);
        }
    }

}