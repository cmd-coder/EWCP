using System;
class program
{
	public static void Main(string []args)
	{
		function(100, 20, 20, 8);
		function(200, 40, 25, 10);
	}
	static void function(int totalHours, int totalDays, int wage, int hour)
	{
		Console.WriteLine("Welcome to Employee Wage Coputation Program");
		Random ran = new Random();
		int totalWage=0;
		//int totalHours=100;
		for(int i=0;i<totalDays;i++)
		{
			int atten = ran.Next(0,3);
			int tempHour=hour;
			switch(atten)
			{
				case 0:
					tempHour=0;
					Console.WriteLine("Employee is absent");
					break;
				case 1:
					tempHour/=2;
					Console.WriteLine("Employee is prersent for part time");
					break;
				default:
					Console.WriteLine("Employee is present for full time");
					break;
			}
			totalWage+=(wage*tempHour);
			totalHours-=tempHour;
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
