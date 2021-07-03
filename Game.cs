using System.Diagnostics;

namespace Sentence_Rating
{
    internal class Game
    {
        private double score;
        private Stopwatch gameTime;


        public Game()
        {
            gameTime = new Stopwatch();
            gameTime.Start();

        }

    }
}