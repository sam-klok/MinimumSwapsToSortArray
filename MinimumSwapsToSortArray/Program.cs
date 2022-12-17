static int minimumSwaps(int[] arr)
{
	printArray(arr);

    var visited = new HashSet<int>();
	var swapCount = 0;

	for (int i = 0; i < arr.Length; i++)
	{
		if (visited.Contains(i)) continue;

		if (arr[i] == i + 1)
		{
            // no swaps needed
			visited.Add(i);
            continue;
		}
		else
		{
			var index = arr[i] - 1;
			swap(ref arr, i, index);
			visited.Add(index);
			swapCount++;

			i--; // revisit, however this approach may be frown upon
		}
	}

    printArray(arr);
    return swapCount;
}

static void swap(ref int[] arr, int i, int j)
{
	var temp = arr[i];
	arr[i] = arr[j];
	arr[j] = temp;
}

static void printArray(int[] arr)
{
	foreach (var i in arr)
		Console.Write($"{i} ");

	Console.WriteLine();
}


//int[] arr = { 1, 3, 2 }; // 1 swap
int[] arr = { 3, 5, 2, 4, 1 };  // 3 swaps
//int[] arr = { 7, 1, 3, 2, 4, 5, 6 };  // 5 swaps


Console.WriteLine(minimumSwaps(arr));
