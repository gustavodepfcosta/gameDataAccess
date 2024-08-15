using GameDataParser;
using GameDataParser.DataAccess;
using GameDataParser.UserInteraction;

try
{
    Console.Clear();
    var app = new App(
        new Prompter(),
        new JsonTransform(),
        new FileReader());

    app.Run();
}
catch (Exception exception)
{
    throw new Exception($"Something went wrong:\n{exception.Message}");
}