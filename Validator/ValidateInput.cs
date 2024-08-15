namespace GameDataParser.Validator;

public class ValidateInput : IValidateInput
{
    public bool Validate(string input)
    {
        bool isValidInput = true;

        if (input.Split('.').Length <= 0)
        {
            isValidInput = false;
        }
        if (input.Length == 0)
        {
            isValidInput = false;
        }
        if (!File.Exists(input))
        {
            isValidInput = false;
        }

        return isValidInput;
    }
}