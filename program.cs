class program
{
	static void Main(string args[])
	{
		Console.WriteLine("Welcome to Employee Wage Coputation Program");
		Random ran = new Random();
		int atten = ran.Next(0,2);
		if(atten == 0)
			Console.WriteLine("Employee is absent");
		else
			Console.WriteLine("Employee is prersent");
	}
}
