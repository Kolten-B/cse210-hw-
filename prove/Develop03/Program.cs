using System;

class Program
{
    static void Main(string[] args)
    {
        string reference = "John 3:16";
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input == "quit")
                break;

            scripture.HideRandomWords(3);
            if (scripture.AllWordsHidden())
                break;
            
        }

        Console.WriteLine("All words are hidden. Goodbye!");
    }
}