namespace OutputUniqueNumbers
{
    public static class FileContent
    {

        public static IEnumerable<String> ReadToEnd(string filePath)
        {
            List<string> enumerable = new();
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] values = line.Split(',');

                        foreach (string value in values)
                        {
                            enumerable.Add(value);
                        }
                    }
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
            return enumerable;
        }
    }
}
