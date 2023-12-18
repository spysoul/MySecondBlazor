namespace MySecondBlazor.Client.Pages.Components;

public class CounterData
{
    private int count;
    public Action? CountChanged { get; set; }

    public int Count
    {
        get => count;
        set
        {
            if (value != count)
            {
                count = value;
                CountChanged?.Invoke();
            }
        }
    }

}