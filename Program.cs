using System.Linq;



string testingString = "4of Fo1r pe6ople g3ood th5e the2";


Console.WriteLine(Kata.Order(testingString));

public static class Kata
{
	public static string Order(string words)
	{
		if (words == "")
		{
			return "";
		}

		string[] tempStringArray = words.Split(' ');
		string[] returnString = new string[tempStringArray.Length];

		for (int i = 0; i < tempStringArray.Length; i++)
		{
			int wordIndexValue = int.Parse(tempStringArray[i].FirstOrDefault(char.IsDigit).ToString());
			returnString[wordIndexValue - 1] = tempStringArray[i];
		}

		return string.Join(" ", returnString);
	}

}

