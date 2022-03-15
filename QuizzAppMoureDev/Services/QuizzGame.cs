using QuizzAppMoureDev.Model;

namespace QuizzAppMoureDev.Services
{
    public class QuizzGame
    {

        private string _playerName;
        private double _count = 0; 

        public QuizzGame(string playerName)
        {
            _playerName = playerName;

        }

        public Task<ScoreBoardModel> CreateGame()
        {
            var gameId = new Guid();
            var scoreBoard = new ScoreBoardModel()
            {
                GameId = gameId,
                PlayerName = _playerName,
                ActualScore = 0,
                AcumulatedScore = 0
            };

            return Task.FromResult(scoreBoard);
        }

        public Task<int> IncrementScore(int newScore, ScoreBoardModel playerBoard)
        {
            var score = newScore + playerBoard.ActualScore;
            return Task.FromResult(score);
        }
    }
}
