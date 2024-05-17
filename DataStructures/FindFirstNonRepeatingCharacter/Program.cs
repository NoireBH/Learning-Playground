string sentence = "therefore you must slay the dragon deez nuts";

string character = FindFirstNonRepeatingCharacter(sentence);
Console.WriteLine(character);

static string FindFirstNonRepeatingCharacter(string sentence)
{
	var dictionary = new Dictionary<char, int>();
	string firstChar = string.Empty;

	foreach (var character in sentence)
	{
		if (Char.IsWhiteSpace(character))
		{
			continue;
		}

		if (!dictionary.ContainsKey(character))
		{
			dictionary[character] = 0;
		}

		dictionary[character]++;		
	}

	foreach (var character in sentence)
	{
		if (dictionary[character] == 1)
		{
			return character.ToString();
		}
	}

	return firstChar;

}