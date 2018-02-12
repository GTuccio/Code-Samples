<Query Kind="Statements" />

int yearsMarried = 19, numOfChildren = 5, numOfKidsInCollege = 2;
bool married = false;
long savings = 125000;

if (married)  //married
	if (yearsMarried > 20) //married more than 20 years. Possible kids in college
		if (numOfChildren > 0) //has at least 1 kid
			if (numOfKidsInCollege > 0) //has at least 1 kid in college
				if (numOfKidsInCollege > 1)
					if (numOfKidsInCollege > 2)
						if (numOfKidsInCollege > 3)
							if (numOfKidsInCollege > 4)
								if (savings > 250000)
								{
								//savings sufficient for 4 (or more) kids in college
								Console.WriteLine("Sufficient Savings");
								}
								else {}
							else
							if (savings > 200000)
							{
							//savings sufficient for 4 kids in college
							Console.WriteLine("Sufficient Savings");
							}
							else {}
						else
						if (savings > 150000)
						{
						//savings sufficient for 3 kids in college
						Console.WriteLine("Sufficient Savings");
						}
						else {}
					else
					if (savings > 100000)
					{
						//savings sufficient for 2 kids in college
						Console.WriteLine("Sufficient Savings");
					}
					else {}
				else
				if (savings > 50000)
				{
					//savings sufficient for 1 kids in college
					Console.WriteLine("Sufficient Savings");
				}
				else {}
			else
			{
			//married less than 20 years
			//still planning for kids in college
			Console.WriteLine("Has kids but no in college yet");
			}
		else {}  //married > 20 years with NO children
	else //married 20 or fewer years
	if (numOfChildren > 0)
		if (numOfChildren > 1)
			if (numOfChildren > 2)
				if (numOfChildren > 3)
					if (numOfChildren > 4)
					{
						Console.WriteLine("4 kids (or more) could go to college");
					}
					else {}
				else
				{
				Console.WriteLine("3 kids could go to college");
				}
			else
			{
			Console.WriteLine("2 kids could go to college");
			}
		else
		{
		Console.WriteLine("1 kids could go to college");
		}
	else
	{
	Console.WriteLine("no kids no college no worries");
	}
else
//single
{
Console.WriteLine("YOU WIN - HOW SIMPLE IS THIS?");
}