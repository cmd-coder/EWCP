class program
{
	static void Main(string args[])
	{
		Console.WriteLine("Welcome to Employee Wage Coputation Program");
		Random ran = new Random();
		int totalWage=0;
		int totalHours=100;
		for(int i=0;i<20;i++)
		{
			int atten = ran.Next(0,3);
			int wage=20, hour=8;
			switch(atten)
			{
				case 0:
					hour=0;
					Console.WriteLine("Employee is absent");
					break;
				case 1:
					hour=4;
					Console.WriteLine("Employee is prersent for part time");
					break;
				default:
					Console.WriteLine("Employee is present for full time");
					break;
			}
			totalWage+=(wage*hour);
			totalHours-=hour;
			if(totalHours == 0)
				break;
			if(totalHours < 0)
			{
				totalWage-=(4*wage);
				break;
			}
		}
		Console.WriteLine("Monthly Employee Wages: "+totalWage);
	}
}
