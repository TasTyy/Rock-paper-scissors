using System;

namespace Help
{
    public class HelperClass
    {
        public static Random rnd = new Random();
        public static int rand = rnd.Next(3);

        public static int GetState()
        {
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

        public void Play()
        {
            // Player 1 state
            if (HelperClass.GetState() == 0)
            {
                player1State = HelperClass.GetState();
            }
            else if (HelperClass.GetState() == 1)
            {
                player1State = HelperClass.GetState();
            }
            else if (HelperClass.GetState() == 2)
            {
                player1State = HelperClass.GetState();
            }
        }
    }
}
