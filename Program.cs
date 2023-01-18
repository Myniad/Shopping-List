using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;



Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
{
    {"eggs", 6.99m},{"bread", 3.99m},{"milk",4.57m},{"chips", 3.99m},{"flowers", 5.99m},{"pet food", 10.20m},{"meat", 9.99m},{"vegetables", 7.45m}
};
List<string> cart = new List<string>();

bool runProgram = true;
string input = "";

while (runProgram)
{
    Console.WriteLine(string.Format("{0,-20} {1,-20}", "Item", "Price"));
    Console.WriteLine(string.Format("============================="));

    foreach (KeyValuePair<string, decimal> item in menu)
    {
        Console.WriteLine(string.Format("{0,-20} ${1,-20}", item.Key, item.Value));
    }
    Console.WriteLine("=============================");
    while (true)
    {
        Console.Write("\nwhat would you like to order? ");
        input = Console.ReadLine();
        if (menu.ContainsKey(input))
        {
            cart.Add(input);
            break;
        }
        else
        {
            Console.WriteLine("Sorry we dont carry that, please try again.");
            cart.Remove(input);
        }
        
    }
    
    Console.WriteLine($"Adding {input} to cart for {menu[input]}");
    while (true)
    {
        Console.WriteLine("\nWould you like to order anything else? y/n");
        string choice = Console.ReadLine();
        if (choice == "n")
        {
            runProgram = false;
            break;
        }
        else if (choice == "y")
        {
            runProgram=true;
            break;
        }
    }   
}
Console.WriteLine("Thanks for your order! \nHeres what you have: ");

decimal sum = 0;
foreach (string i in cart)
{
    Console.WriteLine(string.Format("{0,-20} ${1,-20} ", i, menu[i]));
    sum += menu[i];   
}
Console.WriteLine($"Your total is ${sum}");


