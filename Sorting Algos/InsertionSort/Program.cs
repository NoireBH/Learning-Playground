
int[] numbers = { 11, 17, 5, 4, 16, 9, 2, 20 };

int[] sortedArray = InsertionSort(numbers);

Console.WriteLine(String.Join(" ", sortedArray));

static int[] InsertionSort(int[] array)
{
	for (int i = 1; i < array.Length; i++)
	{
		int current = array[i];
		int j = i - 1;

		while (j >= 0 && array[j] > current)
		{
			array[j + 1] = array[j];
			j--;
		}

		array[j + 1] = current;

	}

	return array;
}