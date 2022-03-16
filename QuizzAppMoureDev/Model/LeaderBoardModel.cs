using System.ComponentModel.DataAnnotations;

namespace QuizzAppMoureDev.Model
{
    public class LeaderBoardModel
    {
        [Key]
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public int PlayerScore { get; set; }
    }
}
