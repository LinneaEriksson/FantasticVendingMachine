using Fantasticvendingmachine;

var bank = new Bank();
var user = new User("Snusmumriken", 150);

var machine = new VendingMachine();
{  
};
// Man ska kunna se vilka varor som man har köpt. 


    Console.WriteLine("Hello and welcome to this Fantastic vending machine!");
    Console.WriteLine("This is what we currently have!");
    foreach (var item in machine.inventory.items)
    {
        Console.WriteLine(item.Name + ": " + item.Price + ":-");

    }
while (user.Money > 0)
{
    Console.WriteLine("What would you like to buy?");
    Console.WriteLine();

    var reply = Console.ReadLine();

    Console.WriteLine("");

    var product = machine.inventory.items.FirstOrDefault(x => x.Name == reply);

    if (product == null)
    {
        Console.WriteLine("Sorry, we don't have that in stock!");
    }
    else
    {
        machine.SellItemTo(user, product);
    }
} 
    Console.WriteLine("You are out of money!");
