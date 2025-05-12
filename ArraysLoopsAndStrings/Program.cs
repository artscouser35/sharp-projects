namespace ArraysLoopsAndStrings;

class Program
{
    static void Main(string[] args)
    {    	
		Console.WriteLine(GetFactorial(100000));
    }
	
	static int GetFactorial(int n)
	{
		if(n == 1)
		{
			return 1;	
		}
		
		return n * GetFactorial(n - 1);
	}
}
