using System;
using System.Collections.Generic;
public class program
{
	public static void Main(string []args)
	{
		Console.WriteLine("Welcome to Emaployee Wage Computation Program");
		Console.WriteLine("----------------------");
		EmpWageBuilder EWB=new EmpWageBuilder();
		EWB.AddEmployeeWage("Company1", 100, 20, 20, 8);
		EWB.AddEmployeeWage("Company2", 200, 40, 25, 10);
		EWB.CalculateTotalWage();
	}
}

public class CompanyEmpWage
{
	int totalHours;
        int totalDays;
        int wage;
        int hour;
	string companyName;

        public CompanyEmpWage(string companyName, int totalHours, int totalDays, int wage, int hour)
        {
                this.totalHours=totalHours;
                this.totalDays=totalDays;
                this.wage=wage;
                this.hour=hour;
		this.companyName=companyName;
        }

	public void Calculate()
	{
		EmpWageBuilder builder=new EmpWageBuilder();
		builder.TotalWage(companyName, totalHours, totalDays, wage, hour);
	}

}

interface IEmpWageBuilder
{
	void AddEmployeeWage(string companyName, int totalHours, int totalDays, int wage, int hour);
	void CalculateTotalWage();
	void TotalWage(string companyName, int totalHours, int totalDays, int wage, int hour);
}

public class EmpWageBuilder : IEmpWageBuilder
{
	List<CompanyEmpWage> CEW = new List<CompanyEmpWage>();

	public void AddEmployeeWage(string companyName, int totalHours, int totalDays, int wage, int hour)
	{
		CEW.Add(new CompanyEmpWage(companyName, totalHours, totalDays, wage, hour));
	}

	public void CalculateTotalWage()
	{
		for(int j=0;j<CEW.Count;j++)
		{
			CEW[j].Calculate();
		}
	}

	public void TotalWage(string companyName, int totalHours, int totalDays, int wage, int hour)
        {
                Random ran = new Random();
                int totalWage=0;
                int []dailyWage = new int[totalDays];
		int markDays=0;
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
			dailyWage[i]=wage*tempHour;
			markDays++;
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
		Console.WriteLine("Daily Wages of the employee for working on a total of "+markDays+" days are");
		Console.Write("--");
		for(int i=0;i<markDays;i++)
			Console.Write(dailyWage[i]+"--");
                Console.WriteLine("Monthly Employee Wages for the company "+companyName+" is: "+totalWage);
		Console.WriteLine("----------------------------------");
        }
}
