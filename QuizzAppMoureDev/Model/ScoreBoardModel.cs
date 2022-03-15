

using System.ComponentModel.DataAnnotations;

namespace QuizzAppMoureDev.Model
{
    public class ScoreBoardModel
    { 
        [Key]
        public Guid GameId { get; set; }
        [Required(ErrorMessage ="Opps!... You must type your name")]
        public string PlayerName { get; set; }
        public int ActualScore { get; set; }
        public int AcumulatedScore { get; set; }

    }
}
