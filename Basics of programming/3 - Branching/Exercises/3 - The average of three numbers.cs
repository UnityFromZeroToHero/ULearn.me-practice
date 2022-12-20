//Даны 3 числа - a, b и с.
//Из функции нужно вернуть среднее из них по величине.

public static int MiddleOf(int a, int b, int c)
{
	int[] arr = new int[3] {a, b, c};
	
	int temp = 0;
	for (int i = 1; i < arr.Length; i++)
	{
		for (int j = 0; j < arr.Length - i; j++)
		{
			if (arr[j] > arr[j + 1])
			{
				temp = arr[j];
				arr[j] = arr[j+1];
				arr[j+1] = temp;
			}
		}
	}
	
	return arr[1];
}
