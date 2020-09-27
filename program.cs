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
}
