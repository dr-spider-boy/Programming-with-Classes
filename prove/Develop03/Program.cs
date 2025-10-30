using System;

class Program
{
    static void Main(string[] args)
    {
        List<Paragraph> scriptures = new List<Paragraph>
        {
            new Paragraph(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),

            new Paragraph (new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),

            new Paragraph(new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy.")
        };

        Random random = new Random();
        Paragraph scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("/nPress Enter to hide more words or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("/nAll words are hidden! Congragulations!!");
                break;
            }
        }
    }
}