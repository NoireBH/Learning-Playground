
int[] numbers = { 1, 6, 5, 4, 3, 9, 2, 20, 14 };

int[] sortedArray = SelectionSort(numbers);

Console.WriteLine(String.Join(" ", sortedArray));

static int[] SelectionSort(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		int smallest = int.MaxValue; // can be optimised slightly by removing this and changing the logic a bit
		int index = 0;

		for (int j = i; j < array.Length; j++)
		{
			if (smallest > array[j])
			{
				smallest = array[j];
				index = j;
			}
		}

		int temp = array[i];
		array[i] = array[index];
		array[index] = temp;
	}

	return array;
}