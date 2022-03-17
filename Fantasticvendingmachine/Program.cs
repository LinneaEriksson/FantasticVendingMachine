using Fantasticvendingmachine;

var bank = new Bank();
var user = new User("Snusmumriken", 150);


var machine = new VendingMachine();
{
    
};

Console.WriteLine("Hello and welcome to this Fantastic vending machine!");
Console.WriteLine("This is what we currently have!");
 foreach (var item in machine.inventory.items)
{
    Console.WriteLine(item.Name + ": " + item.Price + ":-");
  
}
Console.WriteLine("What would you like to buy?");
Console.WriteLine();

var reply = Console.ReadLine();

Console.WriteLine("");

var product = machine.inventory.items.FirstOrDefault(x => x.Name == reply);

machine.SellItemTo(user, product);

