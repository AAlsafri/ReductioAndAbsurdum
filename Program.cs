// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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
        Console.WriteLine("Viewing all products..");
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