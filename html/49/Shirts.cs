using System.Diagnostics.Metrics;

namespace _49;



/*

Write a (console) program that does the following:

Define some colors e.g red, green, blue
Define some patterns e.g. striped, checked, plain
Write a class "Shirt" where a Shirt has a color and a pattern

Given the colors and patterns
1. Create a Shirt for each possible combination.
2. Print out all the shirts. Something like:

	red:striped
	red:checked 
	etc...

*/

internal class Shirt
{
    private string color;
    private string pattern;

    public string Color
    {
        get { return color; }
        set
        {
            if (value != null && value != "")
            {
                color = value;
            }
        }
    }

    public string Pattern
    {
        get { return pattern; }
        set
        {
            if (value != null && value != "")
            {
                pattern = value;
            }
        }
    }

    public Shirt(string color, string pattern)
    {
        Color = color;
        Pattern = pattern;
    }

    public override string ToString()
    {
        return $"This is a shirt with a color of {Color} and a pattern of {Pattern}";
    }


}

class Program
{
    static void Main(string[] args)
    {

        string[] colors = { "red", "green", "blue", "yellow" };
        string[] patterns = { "striped", "checked", "plain", "windowpane", "houndstooth", "solid" };

        int count = 0;
        foreach (string color in colors)
        {
            foreach (string pattern in patterns)
            {
                // should be 24 different shirts
                Shirt shirt = new Shirt(color, pattern);
                count++;
                Console.WriteLine($"Shirt number {count}: {shirt}");


            }
        }


    }
}
