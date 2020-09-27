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
}
