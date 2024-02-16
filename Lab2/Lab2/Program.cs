
//using Lab2;

//Student student = new Student();

//int cem = student.Toplama(4, 5);

//Console.WriteLine(cem);

//for(int i = 0; i < 3; i++)
//{
//	for(int j = 0; j < 4; j++)
//	{
//        Console.Write("Salam" + " ");
//    }
//	Console.WriteLine();
//}

// int Toplama(int eded1, int eded2)
//{
//	int cem = eded1 + eded2;
//	return cem;

//}


#region Task9
//bool CheckNumber(int[] arr, int i)
//{
//	for (int j = 0; j < arr.Length; j++)
//	{
//		if (arr[j] == i)
//		{
//			return true;
//		}
//	}
//	return false;
//}


//int[] arr1 = { 1, 2, 4, 6 };
//Console.ForegroundColor = ConsoleColor.Red;
//Console.WriteLine(CheckNumber(arr1, 4));

#endregion


#region Task3

int ArrayMax(int[] array)
{
	int max = array[0];
	for (int i = 1; i < array.Length; i++)
	{
		if (array[i] > max)
		{
			max = array[i];
		}
	}
	return max;
}


int[] numbers = { 5, 2, -8, 6, 1, 7 };

Console.WriteLine(ArrayMax(numbers));
char[] chars = { 'a', 'b' };
Array.Sort(chars);

Console.WriteLine(Math.Pow(2,-3));
#endregion