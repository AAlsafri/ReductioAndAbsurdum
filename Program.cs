// See https://aka.ms/new-console-template for more information
using System;

List<Product> products = new List<Product>()
{
    new Product() { Name = "Invisibility Cloak", Price = 150.00M, Sold = false, ProductTypeId = 3, DateStocked = new DateTime(2024, 2, 15) },
    new Product() { Name = "Phoenix Feather Wand", Price = 200.00M, Sold = false, ProductTypeId = 4, DateStocked = new DateTime(2024, 1, 10) },
    new Product() { Name = "Dragon Scale Armor", Price = 350.00M, Sold = true, ProductTypeId = 1, DateStocked = new DateTime(2023, 12, 1) },
    new Product() { Name = "Elixir of Eternal Youth", Price = 500.00M, Sold = false, ProductTypeId = 2, DateStocked = new DateTime(2024, 3, 5) },
    new Product() { Name = "Talking Spellbook", Price = 120.00M, Sold = true, ProductTypeId = 3, DateStocked = new DateTime(2024, 1, 25) },
    new Product() { Name = "Wizard Hat of Wisdom", Price = 80.00M, Sold = false, ProductTypeId = 1, DateStocked = new DateTime(2024, 2, 28) },
    new Product() { Name = "Potion of Luck", Price = 60.00M, Sold = false, ProductTypeId = 2, DateStocked = new DateTime(2024, 3, 10) },
    new Product() { Name = "Crystal Ball", Price = 175.00M, Sold = true, ProductTypeId = 3, DateStocked = new DateTime(2023, 11, 20) },
    new Product() { Name = "Silver Oak Wand", Price = 250.00M, Sold = false, ProductTypeId = 4, DateStocked = new DateTime(2024, 3, 1) },
    new Product() { Name = "Basilisk Fang Dagger", Price = 300.00M, Sold = false, ProductTypeId = 1, DateStocked = new DateTime(2024, 1, 5) }
};

string choice = null;
while (choice != "0")
{
Console.WriteLine(@"
Main Menu:
0. To exit the program
1. View all products
2. Add a product
3. Delete a product
4. Update a product
5. Available products 
");

    choice = Console.ReadLine();
    if (choice == "0")
    {
        Console.WriteLine("Are you sure you want to exit the program? (y/n)");
        string? res = Console.ReadLine().Trim().ToLower();

        if (res == "y")
        {
            Console.WriteLine("Goodbye!");
            break;
        }
        else
        {
            Console.WriteLine("Returning to main menu!");
        }

    }
    else if (choice == "1")
    {
        // Console.WriteLine("Viewing all products..");
        ListProducts();
    }
    else if (choice == "2")
    {
        // Console.WriteLine("Adding a products..");
        PostProduct();
    }
    else if (choice == "3")
    {
        // Console.WriteLine("Deleting a products..");
        RemoveProduct();
    }
    else if (choice == "4")
    {
        UpdateProduct();
    }
    else if (choice == "5")
    {
        // Console.WriteLine("Searching for products by type...");
        AvailableProducts();
    }
    else
    {
        Console.WriteLine("Invalid choice. Please enter a valid option.");
    }
    Console.WriteLine("\nPress any key to return to the main menu...");
    Console.ReadKey();
    Console.Clear();
}

void ListProducts()
{
    Console.WriteLine("All Products: ");

    var productStrings = products
        .Select((p, index) => $"{index + 1}. {p}")
        .ToList();

    foreach (string productString in productStrings)
    {
        Console.WriteLine(productString);
    }
}

void PostProduct()
{
    Console.WriteLine("Enter product name: ");
    string name = Console.ReadLine();

    Console.WriteLine("Enter product price: ");
    decimal price = Decimal.Parse(Console.ReadLine());

    Console.WriteLine("Is the product sold? (y/n): ");
    bool sold = Console.ReadLine().Trim().ToLower() == "y";

    Console.WriteLine("Enter product type ID (1-4): ");
    int ProductTypeId = int.Parse(Console.ReadLine());

    Product newProduct = new()
    {
        Name = name,
        Price = price,
        Sold = sold,
        ProductTypeId = ProductTypeId,
        DateStocked = DateTime.Now
    };

    products.Add(newProduct);
    Console.WriteLine($"{name} was successfully added to the shop!");
}

void AvailableProducts()
{
    List<Product> unsoldProducts = products.Where(p => !p.Sold).ToList();
    foreach (Product unsold in unsoldProducts)
    {
        Console.WriteLine(unsold);
    }
}

void RemoveProduct()
{
    ListProducts();
    Console.WriteLine(@"To remove a product, enter its **name or number** from the list above: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int productNumber) && productNumber >= 1 && productNumber <= products.Count)
    {
        Product toRemove = products[productNumber - 1];
        products.Remove(toRemove);
        Console.WriteLine($"{toRemove.Name} was removed from the list.");
    }
    else
    {
        Product matchingProduct = products.FirstOrDefault(p => p.Name.StartsWith(input, StringComparison.OrdinalIgnoreCase));

        if (matchingProduct != null)
        {
            products.Remove(matchingProduct);
            Console.WriteLine($"{matchingProduct.Name} was removed from the list.");
        }
        else
        {
            Console.WriteLine("No matching product found.");
        }
    }
}

void UpdateProduct()
{
    ListProducts();
    Console.WriteLine("To update a product, enter the product name (or starting letters):");

    string input = Console.ReadLine();
    Product toUpdate = products.FirstOrDefault(p => p.Name.StartsWith(input, StringComparison.OrdinalIgnoreCase));

    if (toUpdate != null)
    {
        Console.WriteLine($"Updating {toUpdate.Name}...");

        Console.WriteLine("Enter a new name (or press Enter to keep current): ");
        string newName = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newName))
        {
            toUpdate.Name = newName;
        }

        Console.WriteLine("Enter a new price (or press Enter to keep current): ");
        string newPriceInput = Console.ReadLine();
        if (decimal.TryParse(newPriceInput, out decimal newPrice))
        {
            toUpdate.Price = newPrice;
        }

        Console.Write("Is the product sold? (y/n or press Enter to keep current): ");
        string soldInput = Console.ReadLine().Trim().ToLower();
        if (soldInput == "y")
        {
            toUpdate.Sold = true;
        }
        else if (soldInput == "n")
        {
            toUpdate.Sold = false;
        }

        Console.WriteLine("Product updated successfully.");
    }
    else
    {
        Console.WriteLine("No product found matching that name.");
    }
}