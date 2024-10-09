using System.Timers;
using Timer = System.Timers.Timer;

namespace Math_Game;

internal class GameQuestions
{
    private static readonly List<string> historyEquation = new();
    private static readonly List<string> historyTime = new();
    private static readonly Random number = new();

    private static int firstRandom = 3;
    private static int secondRandom = -2;
    private int firstRandomFirstRange;
    private int secondRandomFirstRange;
    private int secondRandomRange;


    private Timer timer;
    private int elapsedSeconds;

    private int currentLeft;
    private int currentTop;


    public enum Operations
    {
        Add,
        Sub,
        Mul,
        Div
    }

    public void Quest(Operations operations)
    {
        Difficulty(operations);
        Timer();
        var trueAnswer = 0;
        var answer = -1;
        firstRandom = number.Next(firstRandomFirstRange, secondRandomFirstRange);
        secondRandom = number.Next(1, secondRandomRange);
        if (operations == Operations.Div)
            do
            {
                firstRandom = number.Next(firstRandomFirstRange, secondRandomFirstRange);
                secondRandom = number.Next(1, secondRandomRange);
            } while (firstRandom % secondRandom != 0);

        var operation = operations switch
        {
            Operations.Add => "+",
            Operations.Sub => "-",
            Operations.Mul => "*",
            Operations.Div => "/",
            _ => throw new ArgumentException("Fuck")
        };

        Console.WriteLine(" ");
        Console.WriteLine(@$"You have chosen {operation} option.
 Your Question:
{firstRandom} {operation} {secondRandom} = ");
        currentTop = Console.CursorTop;
        currentLeft = Console.CursorLeft;

        while (answer != trueAnswer)
        {
            var success = int.TryParse(Console.ReadLine(), out answer);
            trueAnswer = operations switch
            {
                Operations.Add => firstRandom + secondRandom,
                Operations.Sub => firstRandom - secondRandom,
                Operations.Mul => firstRandom * secondRandom,
                Operations.Div => firstRandom / secondRandom,
                _ => throw new ArgumentException("Invalid operation")
            };
            if (answer == trueAnswer && success)
            {
                timer.Stop();
                timer.Dispose();
                historyEquation.Add($"{firstRandom} + {secondRandom} = {trueAnswer}");
                Console.WriteLine($"Nice one! Answer is {answer}");
                Console.WriteLine($"\rYour time is: {elapsedSeconds / 60:D2}:{elapsedSeconds % 60:D2}");
                historyTime.Add($"{elapsedSeconds / 60:D2}:{elapsedSeconds % 60:D2}");
                elapsedSeconds = 0;
            }
            else
            {
                Console.Write("No:( Try Again: ");
            }
        }
    }


    internal void QuestHist()
    {
        Console.WriteLine(@"You have chosen History option: ");
        for (var index = 0; index < historyEquation.Count; index++)
        {
            var t = historyEquation[index];
            var t2 = historyTime[index];
            Console.WriteLine($"{t}\t\t{t2}");
        }

        Console.WriteLine(@"Press any key to return to main menu... ");
        Console.ReadKey();
    }


    internal void Difficulty(Operations operations)
    {
        Console.WriteLine(@"Choose difficulty: 
1.  Easy
2.  Normal
3.  Hard");
        int difficulty;
        var success = int.TryParse(Console.ReadLine(), out difficulty);
        if (difficulty < 4 && difficulty > 0 && success)
            Console.WriteLine($"You have chosen {difficulty} level! Be prepared!");


        switch (difficulty)
        {
            case 1:
                firstRandomFirstRange = 1;
                secondRandomFirstRange = 50;
                secondRandomRange = operations switch
                {
                    Operations.Mul => 5,
                    Operations.Div => 5,
                    _ => 50
                };
                break;
            case 2:
                firstRandomFirstRange = 50;
                secondRandomFirstRange = 100;
                secondRandomRange = operations switch
                {
                    Operations.Mul => 10,
                    Operations.Div => 10,
                    _ => 100
                };
                break;
            case 3:
                firstRandomFirstRange = 100;
                secondRandomFirstRange = 200;
                secondRandomRange = operations switch
                {
                    Operations.Mul => 20,
                    Operations.Div => 20,
                    _ => 200
                };
                break;
            default:
                Console.WriteLine("Wrong difficulty choice, choose once more.");
                Difficulty(operations);
                break;
        }
    }


    public void Timer()
    {
        timer = new Timer(1000);
        timer.Elapsed += OnTimedEvent;
        timer.AutoReset = true;
        timer.Enabled = true;
    }

    private void OnTimedEvent(object source, ElapsedEventArgs e)
    {
        var currentTop1 = Console.CursorTop;
        var currentLeft2 = Console.CursorLeft;

        elapsedSeconds++;

        Console.SetCursorPosition(currentLeft, currentTop - 4);

        Console.Write($"\rTimer: {elapsedSeconds / 60:D2}:{elapsedSeconds % 60:D2}");

        Console.SetCursorPosition(currentLeft2, currentTop1);
    }

    public void RandomGame()
    {
        Random random = new();
        var number = random.Next(1, 5);
        switch (number)
        {
            case 1:
                Quest(Operations.Add);
                break;
            case 2:
                Quest(Operations.Sub);
                break;
            case 3:
                Quest(Operations.Mul);
                break;
            case 4:
                Quest(Operations.Div);
                break;
            default:
                RandomGame();
                break;
        }
    }
}