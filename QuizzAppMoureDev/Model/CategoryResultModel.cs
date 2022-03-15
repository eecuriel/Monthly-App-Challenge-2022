namespace QuizzAppMoureDev.Model
{
    public class CategoryResultModel
    {
        public string category { get; set; }

        public string type { get; set; }

        public string difficulty { get; set; }

        public string question { get; set; }

        public string correct_Answer { get; set; }

        public String[] incorrect_Answers { get; set; }
    }
}
