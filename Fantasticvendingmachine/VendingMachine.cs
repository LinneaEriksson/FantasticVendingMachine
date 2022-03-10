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

		}
	}
}

