class program
{
	static void main(string args[])
	{
		Console.WriteLine("Welcome to Employee Wage Coputation Program");
	}
	static int attendance()
	{
		Random ran=new Random();
		return ran.Next(0,2);
	}
	static int dailyWage()
	{
		return 8*20;
	}
	static void partTime()
	{
		Console.WriteLine("Enter name");
		String name=Console.ReadLine();
		Console.WriteLine("Enter wage per hour");
		int wage=Convert.ToInt(Console.ReadLine());
		Console.WriteLine("Name: "+name+"Total daily wage: "+(8*wage));
	}
	static void monthWage()
	{
		Console.WriteLine("Enter wage per hour");
		int wage=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Monthly Wage: "+8*20*wage);
	}
	static void workCond()
	{
		Console.WriteLine("Enter the number os working days in a month");
		int a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter wages per hour");
		int wage=Convert.ToInt32(Console.ReadLine());
		int max=Math.Max(100*wage, 20*8*wage);
		Console.WriteLine("Total Wages: "+max);
	}
}
