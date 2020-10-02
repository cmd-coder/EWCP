using System;
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

public class EmpWageBuilder
{
	CompanyEmpWage []CEW = new CompanyEmpWage[100];
	int i=0;

	public void AddEmployeeWage(string companyName, int totalHours, int totalDays, int wage, int hour)
	{
		CEW[i]=new CompanyEmpWage(companyName, totalHours, totalDays, wage, hour);
		i++;
	}

	public void CalculateTotalWage()
	{
		for(int j=0;j<i;j++)
		{
			CEW[j].Calculate();
		}
	}

	public void TotalWage(string companyName, int totalHours, int totalDays, int wage, int hour)
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
                Console.WriteLine("Monthly Employee Wages for the company "+companyName+" is: "+totalWage);
		Console.WriteLine("----------------------------------");
        }
}
