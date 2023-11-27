namespace OutputUniqueNumbers
{
    public static class FileContent
    {

        public static IEnumerable<String> ReadToEnd(string filePath)
        {
            List<string> enumerable = new();
            try
            {
                //// Open the file with a StreamReader
                //using (StreamReader sr = new StreamReader(filePath))
                //{
                //    // Read the entire file content
                //    string content = sr.ReadToEnd();

                //    // Display the content
                //    return content;
                //}
                
                // Abre el archivo con un StreamReader
                using (StreamReader sr = new StreamReader(filePath))
                {
                    // Lee cada línea del archivo
                    while (!sr.EndOfStream)
                    {
                        // Lee la línea actual
                        string line = sr.ReadLine();

                        // Divide la línea en un arreglo usando la coma como delimitador
                        string[] values = line.Split(',');

                        // Itera a través de los valores e imprímelos
                        foreach (string value in values)
                        {
                            //Console.WriteLine(value);
                            enumerable.Add(value);
                        }

                        // Puedes hacer algo con los valores, como almacenarlos en una lista o procesarlos de alguna manera
                    }
                    
                }
            }
            catch (Exception e)
            {
                // Handle exceptions, such as file not found
                Console.WriteLine($"An error occurred: {e.Message}");
            }
            return enumerable;
            

        }
    }
}
