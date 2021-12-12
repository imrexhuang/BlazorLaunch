using Microsoft.AspNetCore.Components;

namespace BlazorLaunch.Pages
{
    // https://gist.github.com/vulcanlee/ccfce68ff963380bdb0387ea61eb0666
    // 練習:Razor 元件 - 繼承 CodeBehind

    // 這個類別需要繼承 [ComponentBase] 類別
    public class CounterInheritBase : ComponentBase
    {
        public int currentCount = 0;

        public void IncrementCount()
        {
            currentCount++;
        }
    }
}
