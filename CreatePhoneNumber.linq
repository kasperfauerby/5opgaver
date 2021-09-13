<Query Kind="Program" />

void Main()
{
	// Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.

	static string CreatePhoneNumber(int[] numbers)
	{

		string phonenumber = "";

		for(int i = 0; i < numbers.Length; i++){
		phonenumber = phonenumber.Insert(i, numbers[i].ToString());
		}
		
		string phonenumber1 = phonenumber.Insert(0, "(");
		string phonenumber2 = phonenumber1.Insert(4, ") ");
		string phonenumber3 = phonenumber2.Insert(9, "-");
		

		return phonenumber3;

	}

	int[] nummer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
	
	int[] nummer1 = {0,9,8,7,6,5,4,3,2,1};
	
	Console.WriteLine(CreatePhoneNumber(nummer));
	Console.WriteLine(CreatePhoneNumber(nummer1));
}

// You can define other methods, fields, classes and namespaces here
