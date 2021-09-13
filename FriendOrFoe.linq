<Query Kind="Program" />

void Main()
{


	/*
Make a program that filters a list of strings and returns a list with only your friends name in it.

If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! Otherwise, you can be sure he's not...

Ex: Input = ["Ryan", "Kieran", "Jason", "Yous"], Output = ["Ryan", "Yous"]

i.e.
	


*/

	static string FriendOrFoe(string[] names)
	{
		
		string friends = "";

		foreach (var name in names)
		{
			if (name.Length == 4)
			{
				friends = friends.Insert(0,name + " ");
			}
		}
		
		return friends;

	}
	
	string[] names = { "Ryan", "Kieran", "Jason", "Yous", "Mark" };

	Console.WriteLine(FriendOrFoe(names));
	
}

// You can define other methods, fields, classes and namespaces here
