class program
{
	static void Main(string args[])
	{
		Console.WriteLine("Welcome to Employee Wage Coputation Program");
		Random ran = new Random();
		int atten = ran.Next(0,3);
		int wage=20, hour=8;
		if(atten == 0)
		{
			hour=0;
			Console.WriteLine("Employee is absent");
		}
		else if(atten == 1)
		{
			hour=4;
			Console.WriteLine("Employee is prersent for part time");
		}
		else
			Console.WriteLine("Employee is present for full time");
		Console.WriteLine("Daily Employee Wage: "+(wage*hour));
	}
}
