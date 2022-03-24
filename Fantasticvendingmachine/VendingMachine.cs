using System;
namespace Fantasticvendingmachine
{
	public class VendingMachine
	{
		public Inventory inventory = new Inventory();

		public VendingMachine()
		{
			inventory.items.Add(new Item("marabou", 20));
			inventory.items.Add(new Item("daim", 15));
			inventory.items.Add(new Item("coca-cola", 10));
			inventory.items.Add(new Item("popcorn", 25));
			inventory.items.Add(new Item("pepsi", 10));
			inventory.items.Add(new Item("chips", 20));
			inventory.items.Add(new Item("ramlösa", 10));
			inventory.items.Add(new Item("snus", 50));
			inventory.items.Add(new Item("fransk bulldog", 250));
		}
		public void SellItemTo(User user, Item item)
		{
			if (user.Money < item.Price)
			{
				Console.WriteLine($"I'm sorry {user.Name}, you don't have enough money to buy {item.Name}.");
				return;
			}
			else {
				user.Money = user.Money - item.Price;
				Console.WriteLine($"Yay, here is your {item.Name}, you have {user.Money}:- left!");
				user.userItems.Add(item);

			}
		}
	}
}



