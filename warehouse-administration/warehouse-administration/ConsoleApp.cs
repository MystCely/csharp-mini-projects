namespace WarehouseAdministration;

public class ConsoleApp
{
    
    private readonly Input _input;
    private readonly Warehouse _warehouse;

    public ConsoleApp()
    {
        _input = new Input();
        _warehouse = new Warehouse();
        
        SeedProducts();
        
    }
    
    public void Run()
    {
        Console.WriteLine("Warehouse Administration Tool");
        
        bool running = true;
        while (running)
        {
            ShowMenu();
            
            string choice = _input.AskForInput("\nEnter your choice: ");
            Console.WriteLine();

            running = HandleChoice(choice);
        }
        
    }
    
    private void ShowMenu()
    {
        Console.WriteLine("\nMenu");
        Console.WriteLine("1. Print stock");
        Console.WriteLine("2. Add product");
        Console.WriteLine("3. Update stock");
        Console.WriteLine("4. Exit");
    }
    
    private bool HandleChoice(string choice)
    {
        switch (choice)
        {
            case "1": 
                _warehouse.PrintStock();
                break;
            
            case "2":
                HandleAddProduct();
                break;
            
            case "3":
                HandleUpdateStock();
                break;
                
            case "4":
                return false;
            
        }

        return true;
    }

    private void HandleUpdateStock()
    {
        int id = 0;
        int change = 0;
        
        var idStr = _input.AskForInput("Enter product ID to update: ").Trim();
        Console.WriteLine();
        var changeStr = _input.AskForInput("Enter change in stock quantity (+ to add, - to remove): ").Trim();
        Console.WriteLine();
        
        if (!int.TryParse(idStr, out id) || !int.TryParse(changeStr, out change))
        {
            Console.WriteLine("Invalid input");
            return;
        }
        
        try 
        {
            _warehouse.UpdateStock(id, change);
            Console.WriteLine("Stock updated");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
    
    private void HandleAddProduct()
    {
        int id = 0;
        int price = 0;
        int stockQty = 0;
        
        var name = _input.AskForInput("Enter product name: ").Trim();
        Console.WriteLine();
        var idStr = _input.AskForInput("Enter product ID: ").Trim();
        Console.WriteLine();
        var priceStr = _input.AskForInput("Enter product price: ").Trim();
        Console.WriteLine();
        var stockQtyStr =  _input.AskForInput("Enter initial stock quantity: ").Trim();
        Console.WriteLine();
        
        if (int.TryParse(idStr, out id) && int.TryParse(priceStr, out price) && int.TryParse(stockQtyStr, out stockQty))
        {
            try
            {
                _warehouse.AddProduct(new Product(name, price, id), stockQty);
                Console.WriteLine("Product added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        else
        {
            Console.WriteLine("Invalid input");
        }
        
    }
    
    private void SeedProducts()
    {
        try
        {
            _warehouse.AddProduct(new Product("Banana", 10, 1), 100);
            _warehouse.AddProduct(new Product("Apple", 5, 2), 200);
            _warehouse.AddProduct(new Product("Orange", 15, 3), 300);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
}