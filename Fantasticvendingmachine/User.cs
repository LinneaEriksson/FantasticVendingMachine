using System;
namespace Fantasticvendingmachine;

	public class User
	{
		public string Name { get; set; }
		public int Money { get; set; }

		public User (string name, int money)
		{
			Name = name;
			Money = money;
		}
	}


