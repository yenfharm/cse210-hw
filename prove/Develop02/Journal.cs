class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response, string date)
    {
        Entry newEntry = new Entry(prompt, response, date);
        entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    public void SaveJournalToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadJournalFromFile(string fileName)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                AddEntry(prompt, response, date);
            }
        }
    }
}