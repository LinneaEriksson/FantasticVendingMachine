using System;
namespace Fantasticvendingmachine;

public class User
{
	public string Name { get; set; }
	public int Money { get; set; }
	public List<Item> userItems = new List<Item>();

	public User (string name, int money)
		{
			Name = name;
			Money = money;
		}

	}


