using System;

class Program
{
    static void Main(string[] args)
    {

	Menu menu = new Menu();


	
	bool minding = true;
	while(minding)
	{
		menu.DisplayMenu();
		int choice = menu.GetChoice();

		switch(choice)
		{
			case 1:

				BreathingActivity breath = new BreathingActivity();
		
				breath.Run();
				break;
			case 2:
				ReflectionActivity reflection = new ReflectionActivity();
				reflection.Run();
				break;
			case 3:
				ListingActivity listing = new ListingActivity();
				listing.Run();
				break;
			case 4:
				minding = false;
				break;
		}
	}
	
    }

}
