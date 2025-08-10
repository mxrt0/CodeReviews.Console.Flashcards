using Flashcards.Controllers;
using Flashcards.Services;
using Flashcards.Services.Contracts;

namespace Flashcards;

public class Program
{
    static void Main(string[] args)
    {
        IStackService stackService = new StackService();
        IFlashcardService flashcardService = new FlashcardService();
        IStudySessionService studySessionService = new StudySessionService();
        var controller = new FlashcardController(flashcardService, stackService, studySessionService);
    }
}

