// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string choice = null;
while (choice != "0")
{
Console.WriteLine(@"
Main Menu:
1. View all products
2. Add a product
3. Delete a product
4. Update a product
5. 
");

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
            choice = null;
        }

    }
    else if (choice == "1")
    {
        Console.WriteLine("Viewing all products..");
        choice = null;
    }
    else if (choice == "2")
    {
        Console.WriteLine("Adding a products..");
        choice = null;
    }
    else if (choice == "3")
    {
        Console.WriteLine("Deleting a products..");
        choice = null;
    }
    else if (choice == "4")
    {
        Console.WriteLine("Updating a products..");
        choice = null;
    }
}