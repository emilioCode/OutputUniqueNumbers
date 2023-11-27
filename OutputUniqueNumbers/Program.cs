using OutputUniqueNumbers;

Console.Write("Please write the filePath here: ");
string filePath = "C:\\Users\\Owner\\Desktop\\ISBN_Input_File.txt";// Console.ReadLine();

var content = FileContent.ReadToEnd(filePath);

foreach (var item in content)
{ 
    Console.WriteLine();
    Console.WriteLine($"=================: {item} :=================");
    var array = new List<char>();
    for (int i = 0; i < item.Length; i++)
    {
        char character = item[i];
        array.Add(character);
    }

    Console.Write("its unique numbers are: ");
    HashSet<char> uniqueNumbers = new HashSet<char>(array);
    Console.WriteLine(string.Join(", ", uniqueNumbers));

}



