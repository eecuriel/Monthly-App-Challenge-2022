namespace QuizzAppMoureDev.Model
{
    public class ResultModel
    {
        public string category { get; set; }
        public string type { get; set; }
        public string difficulty { get; set; }
        public string question { get; set; }
        public string correct_answer { get; set; }
        public string[] incorrect_answer { get; set; }
    }
}
