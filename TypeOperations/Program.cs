namespace TypeOperations;
using System;

static class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        //Divide(5,0);
        //int a = RoundAndCheck(double.MaxValue);
        //Console.WriteLine(a);
        //Console.WriteLine(double.MaxValue);
		CheckAge(55);
		CheckAge(25);
		CheckAge(15);
		CheckAge(13);
		CheckAge(5);
		int compareResult = CompareTwoNums(1,2);
		switch(compareResult)
		{
			case 1 :
				Console.WriteLine("Первое число больше второго");
				break;
			case -1 :
				Console.WriteLine("Первое число меньше второго");
				break;
			case 0 :
				Console.WriteLine("Первое число равно второму");
				break;
				
		}
		SafeSum(9223372036854775806, 2.6);
		Symbol('A');
		SymbolOut(97);
		Time(2);
	
    }

    static double Divide(int a, double b)
    {
        if (b == 0)
        {
            throw new ArgumentException("Divide by zero");
        }

        Console.WriteLine(a / b);

        return a / b;
    }

    static int RoundAndCheck(double value)
    {
        return checked((int)value);
    }
	
	static void CheckAge(int age)
	{
		/*
		if(age < 0)
		{
			Console.WriteLine("No age");
		}
		else if(age < 8) 
		{
			Console.WriteLine("Baby");
		}		
	    else if(age < 14)
		{
			Console.WriteLine("Teenager");
		}		
		else if(age < 17)
		{
			Console.WriteLine("Young");
		}		
		else if(age < 45)
		{
			Console.WriteLine("Adult");	
		}
		else
		{
			Console.WriteLine("Old");
		}
		*/
		
		string message = age < 0
			? "No age" 
			: age < 8
				? "Baby" 
				: age < 14
					? "Teenager" 
					: age < 17
						? "Young" 
						: age < 45
							? "Adult" 
							: "Old";
		
		Console.WriteLine(message);
		
			
	}
	
	static int CompareTwoNums(int a, int b)
	{
		return a > b
			? 1
			: a < b
				? -1
				: 0;
	}
	
	static long SafeSum(long a, double b)
	{
		long result = (long)(a+b);
		if(result > long.MaxValue)
		{
			throw new OverflowException();		
		}
		
		Console.WriteLine(result);
		return result;
	}
	
	static char Symbol(char code)
	{
		int a = (int)code;
		a++;
		code = (char)a;
		Console.WriteLine(code);
		return code;
	}
	
	static char SymbolOut (int codeOut)
	{
		char symbolOut = (char)codeOut;
		
		Console.WriteLine(symbolOut);
		return symbolOut;
		
	}

	static double Time(double seconds)
	{
		double minutes = seconds/60;
		double hourses = minutes/60;
		
		Console.WriteLine($"{minutes},{hourses},{seconds}");
		return seconds;
		
	}
}