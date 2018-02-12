<Query Kind="Statements" />


string[,,,,] realEstate = new string[5,4,30,30,10];
	
int totalCycleCounter = 0;
int totalM = 0;
int totalL = 0;
int totalK = 0;
int totalJ = 0;
int totalI = 0;
int i = 0, j = 0, k = 0, l = 0, m = 0;

for (i = 0; i < realEstate.GetLength(0); i++)   //should be 5 Owners
{
	totalCycleCounter++;
	totalI++;
	j = 0;
	k = 0; 
	l = 0;
	m = 0;
	realEstate[i,j,k,l,m] = ("Owner-" + i);
	for (j = 0; j < realEstate.GetLength(1); j++)   //should be 4 Buildings
	{
		totalCycleCounter++;
		totalJ++;
		k = 0; 
		l = 0;
		m = 0;
		realEstate[i,j,k,l,m] = ("Building-" + j);
		for (k = 0; k < realEstate.GetLength(2); k++)   //should be 30 Tenants
		{
			totalCycleCounter++;
			totalK++;
			l = 0;
			m = 0;
			realEstate[i,j,k,l,m] = ("Tenant-" + k);
			for (l = 0; l < realEstate.GetLength(3); l++)   //should be 30 Floors
			{
				totalCycleCounter++;
				totalL++;
				m = 0;
				realEstate[i,j,k,l,m] = ("Floor-" + l);
				for (m = 0; m < realEstate.GetLength(4); m++)     //should be 10 Departments
				{
					totalCycleCounter++;
					totalM++;
					realEstate[i,j,k,l,m] = ("Department-" + m);
					Console.WriteLine(realEstate[i,j,k,l,m]);
					Console.Write(i); Console.Write(j); Console.Write(k); Console.Write(l); Console.Write(m);
					Console.ReadLine();						
				}
			}
		}
	}
}

Console.WriteLine("Number of times through all loops: " + totalCycleCounter);
Console.WriteLine("Number of Ms: " + totalM);
Console.WriteLine("Number of Ls: " + totalL);
Console.WriteLine("Number of Ks: " + totalK);
Console.WriteLine("Number of Js: " + totalJ);
Console.WriteLine("Number of Is: " + totalI);



