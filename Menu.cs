namespace Math_Game;

public class Menu
{
    private GameQuestions gameQuestions = new GameQuestions();
    private bool end = true;
    private bool firstEnter = true;

    public void MenuItems()
    {
        while (end)
        {
            if(firstEnter)
                Console.WriteLine("Welcome to the Math Game!");
            firstEnter = false;
            Console.WriteLine(@"Options:
1. Addition;
2. Subtraction;
3. Multiplication;
4. Division
5. Random Game;
6. History;
7. Exit");

            Console.Write("Choose your operation: ");
            int inp;
            bool success = int.TryParse(Console.ReadLine(), out inp);
            switch (inp)
            {
                case 1:
                    
                    gameQuestions.Quest(GameQuestions.Operations.Add);
                    break;
                case 2:
                    gameQuestions.Quest(GameQuestions.Operations.Sub);
                    break;
                case 3:
                    gameQuestions.Quest(GameQuestions.Operations.Mul);
                    break;
                case 4:
                    gameQuestions.Quest(GameQuestions.Operations.Div);

                    break;
                case 5:
                    gameQuestions.RandomGame();
                    break;
                case 6:
                    gameQuestions.QuestHist();
                    break;
                case 7:
                    Console.WriteLine(@"Exiting...");
                    end = false;
                    break;
                default:
                    Console.Write(@"You have chosen wrong option.
 Please, choose again: ");
                    break;
            }
        }
    }
}