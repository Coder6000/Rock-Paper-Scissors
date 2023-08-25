Game();
Console.ReadKey();

static void Game()
{
    Random random = new Random();

    int RPS;
    int cpupoints = 0, playerpoints = 0;

    string response, playagain;
    
    bool play = true;

    while(play)
    {
        RPS = random.Next(1, 4);
        System.Console.WriteLine("Rock Paper Scissors?");
        response = Console.ReadLine().ToLower();

        #region ROCK
        if(RPS == 1)
        {
            System.Console.WriteLine("Rock!");

            if(response == "rock")
            {
                System.Console.WriteLine("CPU: Thats a tie!");
            }
            else if(response == "paper")
            {
                System.Console.WriteLine("CPU: I lost!");
                playerpoints++;
            }
            else if(response == "scissor")
            {
                System.Console.WriteLine("CPU: I won!");
                cpupoints++;
            }
        }
        #endregion

        #region PAPER
        if(RPS == 2)
        {
            System.Console.WriteLine("Paper!");

            if(response == "rock")
            {
                System.Console.WriteLine("CPU: I won!");
                cpupoints++;
            }
            else if(response == "paper")
            {
                System.Console.WriteLine("CPU: Thats a tie!");
            }
            else if(response == "scissor")
            {
                System.Console.WriteLine("CPU: I lost!");
                playerpoints++;
            }
        }
        #endregion

        #region Scissor
        if(RPS == 3)
        {
            System.Console.WriteLine("Scissor!");

            if(response == "rock")
            {
                System.Console.WriteLine("CPU: I lost!");
                playerpoints++;
            }
            else if(response == "paper")
            {
                System.Console.WriteLine("CPU: I won!");
                cpupoints++;
            }
            else if(response == "scissor")
            {
                System.Console.WriteLine("CPU: Thats a tie");
            }
        }
        #endregion
        
        System.Console.WriteLine("-------------------------------------");

        #region Aftergame

        Console.ForegroundColor = ConsoleColor.Blue;

        //---------------------------------------------------------
        System.Console.WriteLine($"CPU: {cpupoints} points!");
        System.Console.WriteLine($"Player: {playerpoints} points!");

        if(cpupoints > playerpoints)
        {   
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("CPU is leading!");
            Console.ResetColor();
        }
        else if(cpupoints == playerpoints)
        {   
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Its the same pointcount");
            Console.ResetColor();
        }
        else
        {   
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Player is leading!");
            Console.ResetColor();
        }
        //--------------------------------------------------------

        System.Console.WriteLine("-------------------------------------");

        //---------------------------------------------------------------
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine("Would you like to play again? (y) (n)");
        Console.ResetColor();
        playagain = Console.ReadLine().ToLower();
        //----------------------------------------------------------------

        //----------------------------------------------------------------
        switch (playagain)
        {
            case "y":
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("--------NEW GAME--------");
                Console.ResetColor();
            break;
            case "n":
                play = false;
            break;
        }
        //----------------------------------------------------------------
    }
        #endregion

    System.Console.WriteLine("GOOD BYE!");
}