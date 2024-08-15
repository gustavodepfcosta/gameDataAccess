using GameDataParser.DataAccess;
using GameDataParser.UserInteraction;

namespace GameDataParser;

public class App(
    IPrompter prompter,
    IJsonTransform jsonTransform,
    IFileReader fileReader)
{
    private IPrompter Prompter { get; } = prompter;
    private IJsonTransform JsonTransform { get; } = jsonTransform;
    private IFileReader FileReader { get; } = fileReader;
    private static string BasePath => Path.GetPathRoot("./../../../")!;

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Enter the name of the file you want to read: ");
            
            
            var fileName = Prompter.GetUserEntry();
            var completePath = BasePath + fileName;
            
            if (fileName.Length <= 0 && !File.Exists(completePath)) continue;

            try
            {
                var fileContent = FileReader.Read(completePath);
                var jsonContent = JsonTransform.TextToJson(fileContent!);
                prompter.ShowGamesInformation(jsonContent);

                Console.WriteLine("Thanks for using Opsgenie");
                break;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Insert a valid JSON file path" + exception.Message);
            }
        }
    }
}
