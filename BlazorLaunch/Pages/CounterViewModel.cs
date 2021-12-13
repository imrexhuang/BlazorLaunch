namespace BlazorLaunch.Pages
{
    public class CounterViewModel
    {
        public int currentCount { get; set; }

        public void IncrementCount()
        {
            currentCount++;
        }
    }
}
