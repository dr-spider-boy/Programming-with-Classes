using System;
using System.IO;
using System.IO.Enumeration;


public class Journal
{
    public List<Entry> _listofentries = new List<Entry>();

    public void DisplayAllEntries()
    {
        foreach (Entry entry in _listofentries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveAllEntries()
    {
        string filename = "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(filename, append: true))
        {
            foreach (Entry entry in _listofentries)
            {
                outputFile.WriteLine(entry);
            }
            Console.WriteLine("File Saved!");

        }
    }
    
    public void LoadAllEntries()
    {
        string filename = "journal.txt";
        string filecontent = File.ReadAllText(filename);
        Console.WriteLine("\n ------Jounral Contents------");
        Console.WriteLine(filecontent);
    }

}