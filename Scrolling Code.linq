<Query Kind="Statements" />

//Using Preferences;

int numOfLinesOnPage = /*Preferences.numOfLinesOnPage;*/ 10;
int numOfStartLine = 125;
int numOfEndingLine = numOfStartLine + (numOfLinesOnPage - 1);
bool linedown = false, lineup = false, pagedown = true, pageup = false;
string action = "nothing";
int totalNumOfLinesToDisplay = 563;
string errText = "Normal Condition";

if (linedown) {action = "linedown";}
else
if (lineup) {action = "lineup";}
else 
if (pagedown) {action = "pagedown";}
else
if (pageup) {action = "pageup";}
else 
{action = "nothing";}

switch (action)
{
	case "linedown":
	Console.WriteLine("execute linedown advancement");
	numOfStartLine++;
	numOfEndingLine++;
	if (numOfEndingLine > totalNumOfLinesToDisplay)
		{
		numOfEndingLine--;
		numOfStartLine--;
		errText = "End of Records";
		}
	Console.WriteLine(numOfStartLine);
	Console.WriteLine(numOfEndingLine);
	Console.WriteLine(errText);
	break;
	
	case "lineup":
	Console.WriteLine("execute lineup advancement");
	numOfStartLine--;
	numOfEndingLine--;
	if (numOfStartLine < 1)
		{
		numOfEndingLine++;
		numOfStartLine++;
		errText = "Start of Records";
		}
	Console.WriteLine(numOfStartLine);
	Console.WriteLine(numOfEndingLine);
	Console.WriteLine(errText);
	break;
	
	case "pagedown":
	Console.WriteLine("execute pagedown advancement");
	numOfStartLine = numOfStartLine + (numOfLinesOnPage - 1);
	numOfEndingLine = numOfEndingLine + (numOfLinesOnPage - 1);
	if (numOfEndingLine > totalNumOfLinesToDisplay)
		{
		numOfEndingLine = totalNumOfLinesToDisplay;
		numOfStartLine = numOfStartLine - numOfLinesOnPage;
		errText = "End of Records";
		}
	Console.WriteLine(numOfStartLine);
	Console.WriteLine(numOfEndingLine);
	Console.WriteLine(errText);
	break;
	
	case "pageup":
	Console.WriteLine("execute pageup advancement");
	numOfStartLine = numOfStartLine - (numOfLinesOnPage - 1);
	numOfEndingLine = numOfEndingLine - (numOfLinesOnPage - 1);
	if (numOfStartLine < 1)
		{
		numOfEndingLine = numOfEndingLine + numOfLinesOnPage;
		numOfStartLine = 1;
		errText = "End of Records";
		}
	Console.WriteLine(numOfStartLine);
	Console.WriteLine(numOfEndingLine);
	Console.WriteLine(errText);
	break;
}


