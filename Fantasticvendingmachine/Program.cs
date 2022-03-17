using Fantasticvendingmachine;

var bank = new Bank();
var user = new User("Snusmumriken", 150);


var vendingmachine = new VendingMachine();
{
    
};

Console.WriteLine("Hello and welcome to this Fantastic vending machine!");
Console.WriteLine("This is what we currently have!");
 foreach (var item in vendingmachine.inventory.items)
{
    Console.WriteLine(item.Name + ": " + item.Price + ":-");
  
}
Console.WriteLine("What would you like to buy?");
Console.WriteLine();
Console.WriteLine("");
