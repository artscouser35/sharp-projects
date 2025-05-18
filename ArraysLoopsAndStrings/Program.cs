namespace ArraysLoopsAndStrings;

class Program
{
    static void Main(string[] args)
    {    	
		//Console.WriteLine(GetFactorial(100000));
		//GuessNumber(new Random().Next(1,1000));
		//ShowDividerOfThree(10);
		//ShowFibonachiNumber(5);
		ShowAllEvenNumbers(new int[] {1,2,3,4,5,6});
    }
	
	static int GetFactorial(int n)
	{
		if(n == 1)
		{
			return 1;	
		}
		
		return n * GetFactorial(n - 1);
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

	
}
