using Microsoft.AspNetCore.Components;

namespace QuizzAppMoureDev.Pages
{
    public class CounterBase  : ComponentBase
    {
        public int currentCount { get; set; }
        

        public  void IncrementCount()
        {
            currentCount++;
        }
    }
}
