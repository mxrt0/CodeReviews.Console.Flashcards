namespace Flashcards.Utils;
using Flashcards.Utils.Enums;
public static class Validator
{
    public static bool IsUserInputValid(string? input)
    {
        return !string.IsNullOrEmpty(input) && Enum.TryParse(typeof(MenuOption), input, out var option)
            && Enum.IsDefined(typeof(MenuOption), option);
    }

    public static bool IsStackNameValid(string? itemName)
    {
        return !string.IsNullOrEmpty(itemName) && itemName.Length <= 150;
    }

    public static bool IsFlashcardTextValid(string? text)
    {
        return !string.IsNullOrEmpty(text) && text.Length <= 255;
    }

    public static bool IsYearValid(string? year = "")
    {
        return !string.IsNullOrEmpty(year) && int.TryParse(year, out _) && int.Parse(year) >= 1;
    }
}
