namespace Flashcards.Utils;
using Flashcards.Utils.Enums;
public static class UIHelper
{
    public static readonly MenuOption[] AllOptions = (MenuOption[])Enum.GetValues(typeof(MenuOption));
    public static void DisplayOptions()
    {
        Console.WriteLine("\n\nMAIN MENU\n");
        Console.WriteLine($"{new string('-', 30)}");

        foreach (MenuOption option in AllOptions)
        {
            Console.WriteLine($"\nType {(int)option} to {GetOptionsDescription(option)}");
        }
        Console.WriteLine($"\n{new string('-', 30)}\n");
    }

    public static string GetOptionsDescription(MenuOption option) => option switch
    {
        MenuOption.ExitApplication => "Exit Application",
        MenuOption.AddNewFlashcard => "Add New Flashcard",
        MenuOption.DeleteFlashcardFromStack => "Delete Flashcard From Stack",
        MenuOption.AddNewStack => "Add New Stack",
        MenuOption.ViewFlashcardsInStack => "View Flashcards In Stack",
        MenuOption.DeleteStack => "Delete Stack",
        MenuOption.StartNewStudySession => "Start New Study Session",
        MenuOption.EditExistingFlashcard => "Edit Existing Flashcard",
        MenuOption.EditExistingStack => "Edit Existing Stack",
        MenuOption.ViewAllStudySessions => "View All Study Sessions",
        MenuOption.ViewMonthlySessionsCountByYear => "View Monthly Sessions Count By Year",
        MenuOption.ViewMonthlyAverageSessionScoreByYear => "View Monthly Average Session Score By Year",
        _ => "Unknown Option"
    };
}
