using System;

namespace Help
{
    public class HelperClass
    {
        public static Random rnd = new Random();

        public static int GetState()
        {
            int rand = rnd.Next(0, 3);
            return rand;
        }
    }

    public class Game
    {
        public int player1Score { get; set; }
        public int player2Score { get; set; }
        public int player1State { get; set; }
        public int player2State { get; set; }

        public static int player1HighScore { get; set; }
        public static int player2HighScore { get; set; }

        public int result;

        public Game()
        {
            player1Score = 0;
            player2Score = 0;
        }

        public int Play()
        {
            player1State = HelperClass.GetState();
            player2State = HelperClass.GetState();

            if (player1State == player2State)
            {
                result = 0;
            }
            else if (player1State == 0)
            {
                if (player2State == 1)
                {
                    result = 1;
                }
                else
                {
                    result = 2;
                }
            }
            else if (player1State == 1)
            {
                if (player2State == 2)
                {
                    result = 1;
                }
                else
                {
                    result = 2;
                }
            }
            else if (player1State == 2)
            {
                if (player2State == 0)
                {
                    result = 1;
                }
                else
                {
                    result = 2;
                }
            }

            return result;
        }
    }
}
