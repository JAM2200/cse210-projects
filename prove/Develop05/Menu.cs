class Menu
{
	private string _options = @"1. Breathing Activity
2. Reflection Activity
3. Listing Activity
4. Quit";

	public void DisplayMenu()
	{
		Console.WriteLine(_options);
		Console.Write("Enter an option: ");
	}

	public int GetChoice()
	{
		return int.Parse(Console.ReadLine());
	}

}

