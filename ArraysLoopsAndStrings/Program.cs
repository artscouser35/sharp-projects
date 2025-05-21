namespace ArraysLoopsAndStrings;

class Program
{
    static void Main(string[] args)
    {    	
		//Console.WriteLine(GetFactorial(100000));
		//GuessNumber(new Random().Next(1,1000));
		//ShowDividerOfThree(10);
		//ShowFibonachiNumber(5);
		/*ShowAllEvenNumbers(new int[] {1,2,3,4,5,6});*/
		//int[] result = new int[]{5,3,1,-1,-3};
		//string[] resultString = AssingRanks(result);//
		//IncrementDigits(result);//
		//Console.WriteLine(SearchTarget(result, 3));
		/*for(int i = 0; i < result.Length; i++)
		{
			Console.Write($"{result[i]} ");
		}*/
		/*int[] result = FindTwoSum(new int[]{1,2,3}, 4);
		for(int i = 0; i < result.Length; i++)
		{
			Console.Write($"{result[i]} ");
		}
		
		int[] array = [5,2,0];
		int c = 5;
		Sum(array, c);
		for(int i = 0; i < array.Length; i++)
		{
			Console.Write($"{array[i]} ");
		}
		Console.WriteLine();
		Console.WriteLine(c);
		string s = "Hello";
		s = ReplaceA(s);
		Console.WriteLine(s);*/
		Console.WriteLine(CheckDivide(5));
		
    }
	
	static int GetFactorial(int n)
	{
		if(n == 1)
		{
			return 1;	
		}
		
		return n * GetFactorial(n - 1);
	}
	
	static bool CheckDivide(int n)
	{
		if(n % 3 == 0)
		{
			n /= 3;
			return CheckDivide(n);
		}
		else if(n % 5 == 0)
		{
			n /= 5;
			return CheckDivide(n);
		}
		else if(n == 1)
		{
			return true;
		}
		else
		{
			return false;
		}
		
		
	}
	
	 
	
	static void GuessNumber(int number)
	{	
		
		int tryCount = 10;
		while(tryCount >= 1)
		{
			int inputNumber = int.Parse(Console.ReadLine());
			if(inputNumber > number)
			{
				tryCount -= 1;
				Console.WriteLine("Число больше загаданого");
			}
			else if(inputNumber < number)
			{
				tryCount -= 1;
				Console.WriteLine("Число меньше загаданого");
			}
			else 
			{
				Console.WriteLine("Вы угадали");
				return;
			}
					
		}
		
		Console.WriteLine($"Вы не угадали число. Загаданное число было {number}");
			
	}
	
	static void ShowDividerOfThree(int n)
	{
		int countOfDivider = 0;
		for(int i = 1; i <= n; i++)
		{
			if(i % 3 == 0)
			{
				countOfDivider++;
			}
		}
		
		Console.WriteLine(countOfDivider);
	}
	
	static void ShowFibonachiNumber(int number)
	{
		if(number == 1 || number == 0)
		{
			Console.WriteLine(number-1);
			return;
		}
				
		int first = 0;
		int second = 1;
		int current = 0;
		for(int i = 3; i <= number; i++)
		{
			current = first + second;
			first = second;
			second = current;
		}
		
		Console.WriteLine(current);
	}
	
	static void ShowAllEvenNumbers(int[] numbers)
	{
		
		/*for(int i = 0; i < numbers.Length; i++)
		{
			if(numbers[i] % 2 == 0)
			{
				Console.WriteLine(numbers[i]);	
			}
		}*/
		
		foreach(int current in numbers)
		{
			if(current % 2 == 0)
			{
				Console.WriteLine(current);
			}
		}
	}
	
	static void IncrementDigits(int[] digits)
	{		
		for (int i = digits.Length - 1; i >= 0; i--)
		{
			if (digits[i] < 9)
			{
				digits[i]++;
				return;
			}
			digits[i] = 0;
		}	
		
		digits = new int[digits.Length+1];
		digits[0] = 1;
		
	}	
	
	static int[] FindTwoSum(int[] twoSum, int target)
	{
		for(int i = 0; i < twoSum.Length; i++)
		{
			for(int j = i + 1; j < twoSum.Length; j++)
			{
				if(twoSum[i] + twoSum[j] == target)
				{
					return new int[]{i,j};
				}
			}
		}
		
		return new int[]{-1,-1};
	}
	
	static void Sum(int[] array, int c)
	{
		for(int i = 0; i < array.Length; i++)
		{
			array[i] += c;
			c++;
		}
	}
	
	static string ReplaceA(string s)
	{
		return s.Replace('o', 'a');
	}
	
	static string[] AssingRanks(int[] athlete)
	{	
		string[] result = new string[athlete.Length];
		for(int i = 0; i < athlete.Length; i++)
		{
			if(i == 0)
			{
				result[i] = "1 место";
			}
			else if(i == 1)
			{
				result[i] = "2 место"; 
			}
			else if(i == 2)
			{
				result[i] = "3 место";
			}
			else if(i == 3)
			{
				result[i] = "4";
			}
			else
			{
				result[i] = "5";
			}
			
		}
		
		return result;
	}
	
	static int SearchTarget(int[] array, int target)
	{
		int left = 0;
		int right = array.Length - 1;
		
		
		while(left <= right)
		{
			int mid = (left + right) / 2;
			if(array[mid] == target)
			{
				return mid;
			}
			else if(array[mid] < target)
			{
				right = mid + 1;
			}
			else
			{
				left = mid - 1;
			}
					
		}
		return -1;
	}
}
