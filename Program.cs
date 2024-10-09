    /*bool end = true;
    List<string> history = new List<string>();
    void MathGame()
    {
        while (end)
        {
            Console.WriteLine("Welcome to the Math Game!");
            Console.WriteLine(@"Options:
1. Addition;
2. Subtraction;
3. Multiplication;
4. Division;
5. History;
6. Exit");



            Console.Write("Choose your operation: ");
            int x = Convert.ToInt32(Console.ReadLine());



            Random number1 = new Random();
            int xy = 0;
            int x1 = -1;
            int x2;
            int y1 = 3;
            int y2 = -2;
            switch (x)
            {
                case 1:

                    y1 = number1.Next(0, 100);
                    y2 = number1.Next(0, 100);
                    Console.Write(@$"You have chosen + option.
 Your Question:
{y1} + {y2} = ");
                    while (x1 != xy)
                    {

                        x1 = Convert.ToInt32(Console.ReadLine());
                        xy = y1 + y2;
                        if (x1 == xy)
                        {
                            history.Add($"{y1} + {y2} = {xy}");
                            Console.WriteLine($"Nice one! Answer is {x1}");
                        }
                        else
                        {
                            Console.WriteLine($"No:( Try Again");
                            continue;
                        }
                    }

                    break;
                case 2:
                    y1 = number1.Next(0, 100);
                    y2 = number1.Next(0, 100);
                    Console.Write(@$"You have chosen - option.
 Your Question:
{y1} - {y2} = ");
                    while (x1 != xy)
                    {

                        x1 = Convert.ToInt32(Console.ReadLine());
                        xy = y1 - y2;
                        if (x1 == xy)
                        {
                            history.Add($"{y1} - {y2} = {xy}");
                            Console.WriteLine($"Nice one! Answer is {x1}");
                        }
                        else
                        {
                            Console.WriteLine($"No:( Try Again");
                            continue;
                        }
                    }
                    break;
                case 3:
                    y1 = number1.Next(0, 10);
                    y2 = number1.Next(0, 10);
                    Console.Write(@$"You have chosen * option.
 Your Question:
{y1} * {y2} = ");
                    while (x1 != xy)
                    {

                        x1 = Convert.ToInt32(Console.ReadLine());
                        xy = y1 * y2;
                        if (x1 == xy)
                        {
                            history.Add($"{y1} * {y2} = {xy}");
                            Console.WriteLine($"Nice one! Answer is {x1}");
                        }
                        else
                        {
                            Console.WriteLine($"No:( Try Again");
                            continue;
                        }
                    }

                    break;
                case 4:

                    while (y1 % y2 != 0)
                    {
                        y1 = number1.Next(0, 100);
                        y2 = number1.Next(0, 100);
                        continue;
                    }

                    Console.Write(@$"You have chosen / option.
 Your Question:
{y1} / {y2} = ");
                    while (x1 != xy)
                    {

                        x1 = Convert.ToInt32(Console.ReadLine());
                        xy = y1 / y2;
                        if (x1 == xy)
                        {
                            history.Add($"{y1} / {y2} = {xy}");
                            Console.WriteLine($"Nice one! Answer is {x1}");
                        }
                        else
                        {
                            Console.WriteLine($"No:( Try Again");
                            continue;
                        }
                    }

                    break;
                case 5:
                    Console.WriteLine(@"You have chosen History option: ");
                    foreach (var t in history)
                        Console.WriteLine($"{t}");

                    Console.WriteLine(@"Returning to main menu... ");
                    continue;
                    break;
                case 6:
                    Console.WriteLine(@"Exiting...");
                    end = false;
                    break;
                default:
                    Console.Write(@"You have chosen wrong option.
 Please, choose again: ");
                    continue;
                    break;
            }
            if (end)
                Console.WriteLine($"Your answer: {xy}");
        }
    }


    MathGame();

*/


    using Math_Game;

    Menu menu = new Menu();
menu.MenuItems();



