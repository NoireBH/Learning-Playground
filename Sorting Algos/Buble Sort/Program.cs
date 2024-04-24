
int[] numbers = { 7,6,5,4,3,1,2};

int[] sortedArray = BubleSort(numbers);

Console.WriteLine(String.Join(" ", sortedArray));

static int[] BubleSort(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		bool isSorted = true;

		for (int j = 1; j < array.Length - i; j++)
		{
			if (array[j] < array[j - 1])
			{
				int temp = array[j - 1];
				array[j - 1] = array[j];
				array[j] = temp;
				isSorted = false;
			}
		}

		if (isSorted)
		{
			return array;
		}
	}

	return array;
}