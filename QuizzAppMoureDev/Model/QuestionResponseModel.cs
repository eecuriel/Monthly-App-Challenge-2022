namespace QuizzAppMoureDev.Model
{
    public class QuestionResponseModel
    {
        public int response_code { get; set; }
        public CategoryResultModel[] results { get; set; }
    }
}
