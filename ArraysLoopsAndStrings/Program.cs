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
		/*Console.WriteLine(CheckDivide(5));
		string[] emails = new[]
		{
			"test.email+alex@leetcode.com",       // -> testemail@leetcode.com
			"test.e.mail+bob@leetcode.com",       // -> testemail@leetcode.com (тот же)
			"testemail+david@leetcode.com",       // -> testemail@leetcode.com (тот же)
			"user.name+tag+sorting@example.com",  // -> username@example.com
			"user.name@example.com",              // -> username@example.com (тот же)
			"username@example.com",               // -> username@example.com (тот же)
			"user.name+something@domain.com",     // -> username@domain.com
			"u.sername@domain.com",               // -> username@domain.com (тот же)
			"another.email+test@different.com",   // -> anotheremail@different.com
			"anotheremail@different.com"          // -> anotheremail@different.com (тот же)
		};
		int result = GetCountUniqueEmails(emails);
		Console.WriteLine(result);
		
		string [] arr = GetFizzBuzzArray(15);
		Console.WriteLine(string.Join(',', arr));
		string[] arrrr = AssingRanks(new int[] { 3, 2, 4, 1, 5 });
		Console.WriteLine(string.Join(", ", arrrr));
		string s = "LLPPPLLPPA";
		Console.WriteLine(CheckRecord(s));*/
		/*int a = 1;
		int b = 2;
		Swap(ref a, ref b);
		Console.WriteLine($"{a},{b}");*/
		/*int[] numbers = new int[] { 1, 2, 3 };
		ReplaceArray(ref numbers);
		Console.WriteLine(numbers[0]);
		string r = "arra";
		Console.WriteLine(IsPalindrom(r));
		string q = "qwerty";
		Console.WriteLine(Delete(q));
		Console.WriteLine(IsPassword("wqe21321ewqr12"));
		string sentence = "Это   строка    с   лишними  пробелами.";
		string overturn = "Hello World";
		Console.WriteLine(DeleteString(sentence));
		Console.WriteLine(Overturn(overturn));
		string sentence2 = "Hi! How are you? :) 123";
		string sentence3 = "пРИвЕт мИр";
		Console.WriteLine(DeleteChar(sentence2));
		Console.WriteLine(UpperStr(sentence3));
		string sentence4 = "Это пример строки";
		Console.WriteLine(CountString(sentence4));
		string text = "Phasellus luctus nibh tellus, in suscipit purus finibus ut. Vivamus tempor massa quis ante interdum tincidunt. Nam pellentesque dolor in leo feugiat placerat. Etiam rutrum id ligula sit amet euismod. Curabitur enim ex, ultrices vitae lobortis aliquet, porttitor eget lorem. Nam at dui accumsan, consequat purus nec, suscipit elit. Vestibulum quis turpis sit amet leo rhoncus cursus ac quis sapien. Suspendisse interdum nunc aliquam, laoreet mi vitae, ultrices urna. Sed mattis dolor massa, ac rutrum neque finibus a. Cras euismod commodo aliquet. Praesent sit amet efficitur nisl. Nunc in eros neque. Sed at urna sed lacus vulputate faucibus. Duis a augue gravida, lobortis ligula a, auctor mauris.";		
		Console.WriteLine(LongSentence(text));
		int[] burble = new int[]{3,2,5,4,1,6};
		int[] result = BurbleSort(burble);
		Console.WriteLine(string.Join(",", result));
		int[] snaker = new int[]{10,2,5,4,1,6};
        int[] result2 = ShakerSort(snaker);  // Исправлено на ShakerSort
        Console.WriteLine(string.Join(",", result2));*/
		int[] comb = new int[]{10,2,5,4,1,6,8,32,7};
        int[] result3 = CombSort(comb);  // Исправлено на ShakerSort
        Console.WriteLine(string.Join(",", result3));
		
			
    }
	
	static int[] CombSort(int[] comb)
	{
		int sort = 0;
		int distance = comb.Length;

		while (distance > 1)
		{
			distance = Math.Max(1, (distance * 10) / 13);

			for (int i = 0; i + distance < comb.Length; i++)
			{
			   if (comb[i] > comb[i + distance])
			   {
				   sort = comb[i];
				   comb[i] = comb[i + distance];
				   comb[i + distance] = sort;
			   }
			}			   
		}
		return comb;
	}
  
	
	static int[] BurbleSort(int[] burble)
	{
		int sort = 0;
		for(int i = 0; i < burble.Length; i++)
		{
			for(int j = 1; j < burble.Length; j++)
			{
				if(burble[j-1] > burble[j])
				{
					sort = burble[j];
					burble[j] = burble[j-1];
					burble[j-1] = sort;
					
				}
				
			}
		}
		return burble;
	}
	
	static int[] ShakerSort(int[] shaker)
	{
    int sort = 0;
    for (int i = 0; i < shaker.Length; i++)
    {
        for (int j = 1; j < shaker.Length; j++)
        {
            if (shaker[j - 1] > shaker[j])
            {
                sort = shaker[j];
                shaker[j] = shaker[j - 1];
                shaker[j - 1] = sort;
            }
        }
        
        for (int k = shaker.Length - 1; k > 0; k--)
        {
            if (shaker[k] < shaker[k-1])
            {
                sort = shaker[k];
                shaker[k] = shaker[k - 1];
                shaker[k -1] = sort;
            }
        }     
    }
    return shaker;
	}
	
	static string LongSentence(string text)
	{
		int index = 0;
		int length = 0;
		int lengthBefore = 0;
		string[] sent = text.Split('.');
		for(int i = 0; i < sent.Length; i++)
		{	
			if(length > lengthBefore)
			{	
				length = sent[i].Length;
				index = i;
			}			
		}
		
			
		string[] sent2 = sent[index].Split(' ');
		
		return $"{sent2[0]}-{sent2[^1]}";
	}
	
	
	static int CountString(string sentence4)
	{	
		int count = 0;
		char[] ch = sentence4.ToCharArray();
		for(int i = 0; i < sentence4.Length; i++)
		{
			if(ch[i] == ' ')
			{
				count += 1;
			}
			
			if(i == sentence4.Length -1)
			{
				count += 1;
			}
				
		}
		
		return count;
	}
	
	static string UpperStr(string sentence3)
	{
		char[] ch = sentence3.ToCharArray();
		ch[0] = char.ToUpper(ch[0]);
		for(int i = 0; i < sentence3.Length - 1; i++)
		{
			if(ch[i] == ' ')
			{
				ch[i+1] =  char.ToUpper(ch[i+1]);
				
			}
			else
			{
				ch[i+1] = char.ToLower(ch[i+1]);
			}
						
		}
		
		string str = new string(ch);
		
		return str;	
	}
	
	static string DeleteChar(string sentence2)
	{
		char[] ch = sentence2.ToCharArray();
		for(int i = 0; i < sentence2.Length; i++)
		{
			if(ch[i] == '!' || ch[i] == '?' || ch[i] == ')' || ch[i] == ':' || ch[i] == '1'|| ch[i] == '2'|| ch[i] == '3')
			{
				ch[i] = ' ';
			}
		}
		
		string str = new string(ch);
		
		return str;	
	}
	
	static string DeleteString(string sentence)
	{
		for(int i = 1; i < sentence.Length; i++)
		{
			
			if(sentence[i-1] == ' ' && sentence[i] == ' ')
			{
				sentence = sentence.Replace("  ", " ");
				i--; 
			}
		}
		return sentence;
	}
	
	static string Overturn(string overturn)
	{
		
		 char[] chars = overturn.ToCharArray(); 
		 Array.Reverse(chars);              
         return new string(chars);
	}
	
	static string Delete(string a)
	{
		string[] alpha = new string[] {"a","i","o","e","u"};
		for(int i = 0; i <  alpha.Length; i++)
		{
			a = a.Replace(alpha[i], "");			
		}
		return a;
	}
	
	static string IsPassword(string password)
	{	
		for(int i = 0; i <= 9; i++)
		{
			password = password.Replace(i.ToString(), "*");
		}
		return password;
		
	}
	
	static bool IsPalindrom(string s)
	{
		for(int i = 0; i < s.Length / 2; i++)
		{
			if(s[i] != s[s.Length - 1 - i])
			{
				return false;
			}
		}
		return true;
	}
	static void ReplaceArray(ref int[] arr)
	{
		arr = new int[] { 9, 9, 9 };
	}
	
	static void Swap(ref int a, ref int b)
	{
		(a, b) = (b, a);
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
		if(n == 3 || n == 5)
		{
			return true;
		}
		else if(n % 3 == 0)
		{
			n /= 3;
			return CheckDivide(n);
		}
		else if(n % 5 == 0)
		{
			n /= 5;
			return CheckDivide(n);
		}

		return false;		
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
			int place = 1;
			for(int j = 0; j < athlete.Length; j++)
			{
				if(athlete[i] > athlete[j])
				{
					place++;
				}
			}
			
			if (place == 1)
            result[i] = "1 место";
			else if (place == 2)
            result[i] = "2 место";
			else if (place == 3)
            result[i] = "3 место";
			else
            result[i] = place.ToString();
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
	
	static int GetCountUniqueEmails(string[] emails)
	{
		for(int i = 0; i < emails.Length; i++)
		{
			string[] chaptersOfEmail = emails[i].Split('@'); // ar.t+az@mail.ru => ["ar.t+az", "mail.ru"]
			chaptersOfEmail[0] = chaptersOfEmail[0].Replace(".",""); // ar.t+az => art+az
			int pluseIndex = chaptersOfEmail[0].IndexOf('+');
			if(pluseIndex != -1)
			{
				chaptersOfEmail[0] = chaptersOfEmail[0].Substring(0, pluseIndex);
			}
			emails[i] = $"{chaptersOfEmail[0]}@{chaptersOfEmail[1]}";
		}
		
		int count = 0;
		for(int i = 0; i < emails.Length; i++)
		{
			bool isDuplicate = false;
			for(int j = i+1; j < emails.Length; j++)
			{	
				if(emails[i] == emails[j])
				{	
					isDuplicate = true;
					break;
				}
			}
			if(!isDuplicate)
			{
				count++;
			}
		}
		return count;			
	}
	
	static string[] GetFizzBuzzArray(int n)
	{
		string[] array = new string[n];
		for(int i = 1; i <= n; i++)
		{
			if(i % 3 == 0 && i % 5 == 0)
			{
				array[i-1] = "FizzBuzz";
			}			
			else if(i % 3 == 0)
			{
				array[i-1] = "Fizz";
			}
			else if(i % 5 == 0)
			{
				array[i-1] = "Buzz";
			}
			else 
			{
				array[i-1] = i.ToString();
			}			
			
		}
		return array;
	}
	
	static bool CheckRecord(string s)
	{
		int countA = 0;
		int countL = 0;
		for(int i = 0; i < s.Length; i++)
		{	
			if(s[i] == 'A' && ++countA >= 2)
			{
				return false;									
			}
			
			if(s[i] == 'L' && ++countL >= 3)
			{
				return false;				
			}
			else
			{
				countL = 0;
			}								
		}
		
		return countA < 2 && countL <= 3;				
	}
	
	/*static bool IsSubsequence(string s, string t)
	{
		if(s.Length > t.Length || (s == "" && t == "")
		{
			ArgumentEx
		}
		for(int i = 0; i < t.Length; i++)
		{
			for(int j = 0; j < s.Length; j++)
			{
				
			}
		}
	}*/
}
