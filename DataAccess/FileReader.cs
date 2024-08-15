namespace GameDataParser.DataAccess;

public class FileReader : IFileReader
{
    public string Read(string pathToFile)
    {
        if (File.Exists(pathToFile))
        {
            Console.WriteLine($"Path to file: {pathToFile}");
            var fileData = File.ReadAllText(pathToFile);
            
            return fileData;
        }
        else
        {
            throw new FileNotFoundException("The file does not exist");
        }
    }
}