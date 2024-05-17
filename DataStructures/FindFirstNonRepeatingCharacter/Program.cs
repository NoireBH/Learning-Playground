string sentence = "the impostor is sus";

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

	foreach (KeyValuePair<char, int> entry in dictionary)
	{
		if (dictionary[entry.Key] == 1)
		{
			firstChar = entry.Key.ToString();
			return firstChar;
		}
		
	}

	return firstChar;

}