using System.Collections.Generic;
using System.Diagnostics;

namespace Sentence_Rating
{
    internal class User
    {

        private Stopwatch playTime;
        private string email;
        private List<Game> games;

        public User(string newEmail)
        {
            email = newEmail;
            games = new List<Game>();
        }


        public void AddGame(Game game )
        {
            games.Add(game);
        }

        public void startGame()
        {

            Game newGame = new Game();

        }
    }
}