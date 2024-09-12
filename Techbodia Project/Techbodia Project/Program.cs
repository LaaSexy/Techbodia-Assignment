using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // DECLARE
        string input = "", tag = "";
        List<string> validTags = new List<string> { "BE", "FE", "QA", "Urgent" };
        HashSet<string> channels = new HashSet<string>();

        // INPUT
        Console.Write("Enter notification title: ");
        input = Console.ReadLine();

        // PROCESS
        Regex regex = new Regex(@"\[(.*?)\]");
        MatchCollection matches = regex.Matches(input);

        foreach (Match match in matches)
        {
            tag = match.Groups[1].Value;
            if (validTags.Contains(tag))
            {
                channels.Add(tag);
            }
        }

        // OUTPUT
        if (channels.Count > 0)
        {
            Console.WriteLine("Receive channels: " + string.Join(", ", channels));
            Console.WriteLine("\n\n\n");
        }
        else
        {
            Console.WriteLine("Channels not found!");
            Console.WriteLine("\n\n\n");
        }
    }
}
