using System;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
      Console.WriteLine($"date");
      Console.WriteLine($"prompt: {_promptText}");
      Console.WriteLine($"response: {_entryText}"); 
      Console.WriteLine();
    }
}