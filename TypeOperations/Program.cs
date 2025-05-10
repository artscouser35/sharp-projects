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
		Time(2);
		CheckChessStepHorse(4,4,6,3);
		Console.WriteLine(CheckChessStepHorse(3,4,6,3));
		Console.WriteLine(CheckChessStepPawn(3,4,6,3));
		Console.WriteLine(CheckChessStepKing(3,4,6,3));
		
		
	
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

	static double Time(double seconds)
	{
		double minutes = seconds/60;
		double hourses = minutes/60;
		
		Console.WriteLine($"{minutes},{hourses},{seconds}");
		
		return seconds;
	}
	/*любая фигура
1. Стоит на месте
2. 8x8 ( <1, >8) любая из координат

Конь!
3. dx, dy !=0
4. |dx + dy| = 3
*/

	static bool CheckChessStepHorse(int xSource, int ySource, int xDestination, int yDestination)
	{
		if(!StepIsReal(xSource,ySource,xDestination,yDestination))
		{
			return false;
		}

		int dx = Math.Abs(xSource-xDestination);
		int dy = Math.Abs(ySource-yDestination);
		
		return IsHorse(dx,dy);
	}
	
	static bool IsHorse (int dx, int dy)
	{
		return (dx != 0 || dy != 0) && (dx + dy) == 3;
	}
	
	static bool CheckChessStepBishop(int xSource, int ySource, int xDestination, int yDestination)
	{
		if(!StepIsReal(xSource,ySource,xDestination,yDestination))
		{
			return false;
		}

		int dx = Math.Abs(xSource-xDestination);
		int dy = Math.Abs(ySource-yDestination);
		
		return IsBishop(dx,dy);
	}
	
	static bool IsBishop(int dx, int dy)
	{
		return dx == dy;
	}
	
	static bool CheckChessStepRook(int xSource, int ySource, int xDestination, int yDestination)
	{
		if(!StepIsReal(xSource,ySource,xDestination,yDestination))
		{
			return false;
		}

		int dx = Math.Abs(xSource-xDestination);
		int dy = Math.Abs(ySource-yDestination);
		
		return IsRock(dx,dy);
	}
	
	static bool IsRock(int dx, int dy)
	{
		return (dx != 0 && dy == 0) || (dx == 0 && dy !=0);
	}
	
	static bool CheckChessStepQueen(int xSource, int ySource, int xDestination, int yDestination)
	{
		if(!StepIsReal(xSource,ySource,xDestination,yDestination))
		{
			return false;
		}
				
		int dx = Math.Abs(xSource-xDestination);
		int dy = Math.Abs(ySource-yDestination);
		
		return IsQueen(dx,dy);
	}
	
	static bool IsQueen(int dx, int dy)
	{
		return IsBishop(dx,dy) || IsRock(dx,dy);
	}
	
	static bool StepIsReal(int xSource, int ySource, int xDestination, int yDestination)
	{
		if(xSource == xDestination && ySource == yDestination)
		{
			Console.WriteLine("Стоит на месте");
			return false;
		}
		
		bool sourceIsNotReal = xSource < 1 || xSource > 8 || ySource < 1 || ySource > 8;
		bool destinationIsNotReal = xDestination < 1 || xDestination > 8 || yDestination < 1 || yDestination > 8;
		
		if(sourceIsNotReal || destinationIsNotReal)
		{
			Console.WriteLine("Ход некорректный");
			return false;
		}
		
		return true;
	}
	
	static bool CheckChessStepPawn(int xSource, int ySource, int xDestination, int yDestination)
	{
		if(!StepIsReal(xSource,ySource,xDestination,yDestination))
		{
			return false;
		}
				
		int dx = Math.Abs(xSource-xDestination);
		int dy = Math.Abs(ySource-yDestination);
		
		return dx == 0 && dy == 1;
	}
	
	static bool CheckChessStepKing(int xSource, int ySource, int xDestination, int yDestination)
	{
		if(!StepIsReal(xSource,ySource,xDestination,yDestination))
		{
			return false;
		}
				
		int dx = Math.Abs(xSource-xDestination);
		int dy = Math.Abs(ySource-yDestination);
		
		return (dx == 1 && dy == 0) || (dx == 0 && dy == 1) || (dx == 1 && dy == 1);
	}
		
}





