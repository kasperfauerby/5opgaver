<Query Kind="Program" />

void Main()
{
	//You are given an array(which will have a length of at least 3, but could be very large) containing integers. 
	//The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N.
	//Write a method that takes the array as an argument and returns this "outlier" N.

	//Examples

	/*
	[2, 4, 0, 100, 4, 11, 2602, 36]
 Should return: 11 (the only odd number)

 [160, 3, 1719, 19, 11, 13, -21]
 Should return: 160 (the only even number)
	*/
   

	static int FindOutlier(int[] integers)
	{
		int odds = 0;
        int evens = 0;
        int outlier;


		for (int i = 0; i < integers.Length; i++)	{
			
			if (integers[i] % 2 == 0){
				
				evens++;
				
			} else {
				
				odds++;
			}
		}

		if (evens > odds)
		{
			outlier = 1;
		}
		else
		{
			outlier = 0;
		}

		for (int i = 0; i < integers.Length; i++)
		{
			if ((integers[i] % 2) == outlier)
			{
				return integers[i];
			}
		}

		return 0;
	}
	
	int[] numre = {2, 4, 0, 100, 4, 11, 2602, 36};
	
	int[] numre1 = {160, 3, 1719, 19, 11, 13, -21};
	
	Console.WriteLine(FindOutlier(numre));
	
	Console.WriteLine(FindOutlier(numre1));
	
}


// You can define other methods, fields, classes and namespaces here
