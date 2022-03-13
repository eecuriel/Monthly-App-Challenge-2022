namespace QuizzAppMoureDev.Model
{
    public class ScoreBoardModel
    {
        public Guid GameId { get; set; }
        public string PlayerName { get; set; }
        public float ActualScore { get; set; }
        public float AcumulatedScore { get; set; }

    }
}
