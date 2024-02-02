#region Task1
//resultAgain:
//Console.Write("Please enter your score : ");
//int score = int.Parse(Console.ReadLine());


//if (score <= 100 && score >= 0)
//{


//	if (score < 51)
//	{
//		Console.WriteLine("Kesildiniz");
//	}
//	else if (score < 61)
//	{
//		Console.WriteLine("Your result is E");
//	}
//	else if (score < 71)
//	{
//		Console.WriteLine("Your result is D");
//	}
//	else if (score < 81)
//	{
//		Console.WriteLine("Your result is C");
//	}
//	else if (score < 91)
//	{
//		Console.WriteLine("Your result is B");
//	}
//	else
//	{
//		Console.WriteLine("Your result is A");
//	}
//}
//else
//{
//	goto resultAgain;
//}
#endregion

#region Task2 
//int[] numbers = { -5, -6, 4, 7, 2,0,0 };
//int countPos = 0;
//int countNeg = 0;	
//int countZero = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//	if (numbers[i] > 0)
//	{
//		countPos++;
//	}
//	else if (numbers[i] < 0)
//	{
//		countNeg++;
//	}
//	else { countZero++; }
//}

//Console.WriteLine($"Positive numbers:{countPos} Negative number:{countNeg}  Zero :{countZero}");
#endregion

#region Task3

//int[] numbers = {7,3,2,6,8,-3,4,5};

//int max = numbers[0];
//int min = numbers[0];	

//for (int i = 0; i < numbers.Length; i++)
//{
//	if (numbers[i] > max)
//	{
//		max = numbers[i];
//	}
//}
//for (int i = 0; i < numbers.Length; i++)
//{
//	if (numbers[i] < min)
//	{
//		min = numbers[i];
//	}
//}

//Console.WriteLine($"Max number:{max}  Min number:{min}");

#endregion

#region Task4

//int[] arr1 = { 1, 2, 3, 4 };
//int[] arr2 = { 5, 6, 7 };

//List<int> newList = new List<int>();

//foreach (int number in arr1)
//{
//	newList.Add(number);
//}

//foreach (int number in arr2)
//{
//	newList.Add(number);
//}

//for (int i = 0; i < newList.Count; i++)
//{
//	Console.Write(newList[i] + " ");
//}
#endregion

#region Task4OtherVariant
//int[] arr1 = { 1, 2, 3, 4 };
//int[] arr2 = { 5, 6, 7 };

//int[] arrConcat = new int[arr1.Length+arr2.Length];

//for (int i = 0; i < arr1.Length; i++)
//{
//	arrConcat[i] = arr1[i];
//}

//for (int i = arr1.Length;i < arr1.Length+arr2.Length; i++)
//{
//	arrConcat[i] = arr2[i-arr1.Length];
//}

#endregion


#region Task5
//List<int> numbers = new List<int>();
//int sum = 0;
//while (true)
//{
//	Console.Write("Please enter digit(If you stop program,please enter 0 : ");
//	int number = int.Parse(Console.ReadLine());

//	if(number == 0)
//	{
//		Console.WriteLine("Sum : " + sum);
//		break;
//	}
//	numbers.Add(number);
//	sum += number;
//}

//foreach(int number in numbers)
//{
//	Console.Write(number+" ");
//}

#endregion

#region Task6

Console.Write("Enter digit : ");

int number = int.Parse(Console.ReadLine());

int tempnumber = number;
int qaliq = 0;
int reverseNumber = 0;
while (tempnumber > 0)
{
	qaliq = tempnumber % 10;
	reverseNumber = reverseNumber*10 +qaliq;
	tempnumber = tempnumber / 10;
}

if( number == reverseNumber)
{
	Console.WriteLine("This is palindrome number");
}
else
{
	Console.WriteLine("This is not palindrome number");
}


#endregion