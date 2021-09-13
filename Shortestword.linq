<Query Kind="Program" />

void Main()
{

	// Simple, given a string of words, return the length of the shortest word(s).

	// String will never be empty and you do not need to account for different data types.



	static string FindShort(string s)
	{
		string word = "", smallestW = "", largestW = "";

		string[] words = new string[100];

		int length = 0;

		s = s + " ";

		for (int i = 0; i < s.Length; i++)
		{
			if (s[i] != ' ')
			{
				word = word + s[i];
			}
			else
			{
				words[length] = word;
				length++;
				word = "";
			}
		}
		smallestW = largestW = words[0];

		for (int i = 0; i < length; i++)
		{

			if (smallestW.Length > words[i].Length)
			{
				smallestW = words[i];
			}

			if (largestW.Length < words[i].Length)
			{
				largestW = words[i];
			}
		}

		string result = " Længste ord = " + largestW + "\n Korteste ord = " + smallestW;

		return result;
	}
string sentence = "bitcoin take over the world maybe who knows perhaps";

Console.Write(FindShort(sentence));


}

// You can define other methods, fields, classes and namespaces here
