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
5. 
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
        Console.WriteLine("Adding a products..");
    }
    else if (choice == "3")
    {
        Console.WriteLine("Deleting a products..");
    }
    else if (choice == "4")
    {
        Console.WriteLine("Updating a products..");
    }
    else if (choice == "5")
    {
        Console.WriteLine("Searching for products by type...");
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
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i]}");
    }
}