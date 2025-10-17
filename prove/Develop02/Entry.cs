using System;



public class Entry
{
    public DateTime _entrydate;
    public string _entrytext;
    public string _entryprompt;

    public override string ToString()
    {
        return $"Date: {_entrydate}\nPrompt: {_entryprompt}\nEntry: {_entrytext}\n";
    }
}