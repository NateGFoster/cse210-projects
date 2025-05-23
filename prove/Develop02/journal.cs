public class Journal
{

    List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry location)
    {
        entries.Add(location);
}
    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"{entry.date}\n{entry.question}\n {entry.answer}");
          
        }
        }
    public void LoadEntries(string location)
    {
        // using (StreamReader sr = new StreamReader("Journal.txt"))
        
            int i = 0;
        Entry entry = null;
            foreach (string Line in File.ReadAllLines(location))
            {
                if (i % 3 == 0)
                {
                    entry = new Entry();
                    entry.date = Line;
                }
                if (i % 3 == 1)
                {
                    entry.question = Line;
                }
                if (i % 3 == 2)
                {

                    entry.answer = Line;
                    entries.Add(entry); // adds the complete entry to the list of entries
                }
            i++;
            
     }
}

    public void SaveEntries(string location)
    {
        foreach (Entry entry in entries)
        {
            using (StreamWriter sw = new StreamWriter(location))
            {sw.WriteLine($"{entry.date}\n{entry.question}\n {entry.answer}");} 
          
        }
}
}