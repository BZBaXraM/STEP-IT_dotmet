using Bridge.Bridge;

namespace Bridge;

class Program
{
    static void Main()
    {
        IDevice device = new TV();
        var remote = new AdvancedRemoteControl(device);

        remote.TogglePower();
        while (true)
        {
            Thread.Sleep(2000);
            for (int i = 0; i < 5; i++)
            {
                remote.VolumeUp();
            }

            remote.VolumeDown();
            remote.ChanelUp();

            Console.WriteLine($"Device Enabled: {device.IsEnabled}");
            Console.WriteLine($"Device Volume: {device.Volume}");
            remote.Mute();
            Console.WriteLine($"Device Volume: {device.Volume}");
            Console.WriteLine($"Device Channel: {device.Channel}");
            remote.ChanelUp();
            remote.ChanelUp();
            Console.WriteLine($"Device Channel: {device.Channel}");
            remote.TogglePower();
            Console.WriteLine($"Device Enabled : {device.IsEnabled}");
        }
        
    }
}