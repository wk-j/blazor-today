namespace MyWeb.Shared;

public partial class MainLayout {

    private DateTime now = DateTime.Now;

    protected override void OnInitialized() {
        // System.Timers.Timer timer = new() {
        //     Interval = 1000,
        //     AutoReset = false
        // };

        // timer.Elapsed += (_, _) => {
        //     now = DateTime.Now;
        //     timer.Start();
        //     Console.WriteLine($"Reload {DateTime.Now} ...");
        // };
        // timer.Start();
    }
}