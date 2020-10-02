using System;
public class program
{
	public static void Main(string []args)
	{
		Console.WriteLine("Welcome to Emaployee Wage Computation Program");
		Console.WriteLine("----------------------");
		Console.WriteLine("For Company1");
		EmployeeWageCalculator company1=new EmployeeWageCalculator(100, 20, 20, 8);
		EmployeeWageCalculator company2=new EmployeeWageCalculator(200, 40, 25, 10);
		company1.TotalWage();
		Console.WriteLine("----------------------");
		Console.WriteLine("For Company2");
		company2.TotalWage();
	}
}

public class EmployeeWageCalculator
{
	int totalHours;
	int totalDays;
	int wage;
	int hour;
	
	public EmployeeWageCalculator(int totalHours, int totalDays, int wage, int hour)
	{
		this.totalHours=totalHours;
		this.totalDays=totalDays;
		this.wage=wage;
		this.hour=hour;
	}

	public void TotalWage()
        {
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
