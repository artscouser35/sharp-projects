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
		SafeSum(92233720368547758, 2.6);
		Symbol('A');
		SymbolOut(97);
		CheckChessStepHorse((4,4),(6,3));
		Console.WriteLine(CheckChessStepHorse((3,4),(6,3)));
		Console.WriteLine(CheckChessStepPawn((3,4),(6,3)));
		Console.WriteLine(CheckChessStepKing((3,4),(6,3)));
	
		(string, int) student = ("Vasya", 18);
		Console.WriteLine(student.Item1);
		(int x, int y) point = (2,3);
		double a = 2.2;
		long b = 1;
		(double a, long b) operand = (a,b);
		Console.WriteLine(ConvertSecondToTime(1000));
		Zodiac((21,2));
		Console.WriteLine(Years(2024));
		Console.WriteLine(Taxi((23,11)));
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
		Console.WriteLine(Zodiac((21,2)));
			
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
		long result = checked((long)(a+b));		
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

	static (int, int, int) ConvertSecondToTime(int totalSeconds)
	{
		int totalMinutes = totalSeconds/60;
		int hourses = totalMinutes/60;
		int seconds = totalSeconds%60;
		int minutes = totalMinutes%60;
				
		Console.WriteLine($",{hourses},{minutes},{seconds}");
		
		return (hourses, minutes, seconds);
	}

	static bool CheckChessStepHorse((int x, int y)source, (int x, int y)destination)
	{
		if(!StepIsReal(source,destination))
		{
			return false;
		}

		int dx = Math.Abs(source.x-destination.x);
		int dy = Math.Abs(source.y-destination.y);
		
		return IsHorse(dx,dy);
	}
	
	static bool IsHorse (int dx, int dy)
	{
		return (dx != 0 || dy != 0) && (dx + dy) == 3;
	}
	
	static bool CheckChessStepBishop((int x, int y)source, (int x, int y)destination)
	{
		if(!StepIsReal(source,destination))
		{
			return false;
		}

		int dx = Math.Abs(source.x-destination.x);
		int dy = Math.Abs(source.y-destination.y);
		
		return IsBishop(dx,dy);
	}
	
	
	static bool IsBishop(int dx, int dy)
	{
		return dx == dy;
	}
	
	static bool CheckChessStepRook((int x, int y)source, (int x, int y)destination)
	{
		if(!StepIsReal(source,destination))
		{
			return false;
		}

		int dx = Math.Abs(source.x-destination.x);
		int dy = Math.Abs(source.y-destination.y);
		
		return IsRock(dx,dy);
	}
	
	static bool IsRock(int dx, int dy)
	{
		return (dx != 0 && dy == 0) || (dx == 0 && dy !=0);
	}
	
	static bool CheckChessStepQueen((int x, int y)source, (int x, int y)destination)
	{
		if(!StepIsReal(source,destination))
		{
			return false;
		}
				
		int dx = Math.Abs(source.x-destination.x);
		int dy = Math.Abs(source.y-destination.y);
		
		return IsQueen(dx,dy);
	}
	
	static bool IsQueen(int dx, int dy)
	{
		return IsBishop(dx,dy) || IsRock(dx,dy);
	}
	
	static bool StepIsReal((int x, int y)source, (int x, int y)destination)
	{
		if(source.x == destination.x && source.y == destination.y)
		{
			Console.WriteLine("Стоит на месте");
			return false;
		}
		
		bool sourceIsNotReal = source.x < 1 || source.x > 8 || source.y < 1 || source.y > 8;
		bool destinationIsNotReal = destination.x < 1 || destination.x > 8 || destination.y < 1 || destination.y > 8;
		
		if(sourceIsNotReal || destinationIsNotReal)
		{
			Console.WriteLine("Ход некорректный");
			return false;
		}
		
		return true;
	}
	
	static bool CheckChessStepPawn((int x, int y)source, (int x, int y)destination)
	{
		if(!StepIsReal(source,destination))
		{
			return false;
		}
		
		(int x, int y) d = GetDelta(source, destination);
		
		return d.x == 0 && d.y == 1;
	}
	
	static bool CheckChessStepKing((int x, int y) source, (int x, int y) destination)
	{
		if(!StepIsReal(source,destination))
		{
			return false;
		}
				
		(int x, int y) d = GetDelta(source, destination);
		
		return (d.x == 1 && d.y == 0) || (d.x == 0 && d.y == 1) || (d.x == 1 && d.y == 1);
	}
	
	static (int, int) GetDelta((int x, int y)source, (int x, int y)destination)
	{
		int dx = Math.Abs(source.x-destination.x);
		int dy = Math.Abs(source.y-destination.y);
		
		return (dx,dy);
	}
	
	static string Zodiac((int day, int mount) date)
	{
		if((date.day >= 21  && date.mount == 1) || (date.day <= 19 && date.mount == 2))
		{
			Console.WriteLine("Water bearer");
		}
		else if((date.day >= 20  && date.mount == 2) || (date.day <= 20 && date.mount == 3))
		{
			
			return "Fish";
		}
		else if((date.day >= 21  && date.mount == 3) || (date.day <= 20 && date.mount == 4))
		{
			return "Ram";
		}
		else if((date.day >= 21  && date.mount == 4) || (date.day <= 21 && date.mount == 5))
		{
			return "Bull";
		}
		else if((date.day >= 22  && date.mount == 5) || (date.day <= 21 && date.mount == 6))
		{
			return "Twins";
		}
		else if((date.day >= 22  && date.mount == 6) || (date.day <= 22 && date.mount == 7))
		{
			return "Crab";
		}
		else if((date.day >= 23  && date.mount == 7) || (date.day <= 21 && date.mount == 8))
		{
			return "Lion";
		}
		else if((date.day >= 22  && date.mount == 8) || (date.day <= 23 && date.mount == 9))
		{
			return "Maiden";
		}
		else if((date.day >= 24  && date.mount == 9) || (date.day <= 23 && date.mount == 10))
		{
			return "Scales";
		}
		else if((date.day >= 24  && date.mount == 10) || (date.day <= 22 && date.mount == 11))
		{
			return "Scorpion";
		}
		else if((date.day >= 23  && date.mount == 11) || (date.day <= 22 && date.mount == 12))
		{
			return "Archer";
		}
		else 
		{
			return "Sea-Goat";
		}
		
		return "No Zodiac";		 		
	}
	
	static string Years(int date)
	{
		if((date % 4 == 0 && date % 100 != 0) || date % 400 == 0)
		{
			return "Leap year";
		}
		
		return "No leap year";
	}
	
	static double Taxi((int date, int distance)parametr)
	{
		
		double price = 100;
		
		if(parametr.date >= 22 || parametr.date <= 6)
		{
			price = price * 1.3;
		}
		if(parametr.distance > 10)
		{
			price += ((parametr.distance - 10) * 15);
			
		}
		return price;		
	}
		
}





