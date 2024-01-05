using System;
using System.Globalization;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;

		CultureInfo.CurrentCulture = new CultureInfo("en-US");
		Console.WriteLine($"Percent: {percent*100}% tip");
		Console.WriteLine($"Currency: ${currency:N2}");
	}
}
