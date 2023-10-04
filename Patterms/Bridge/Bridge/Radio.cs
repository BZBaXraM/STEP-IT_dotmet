using Bridge.Bridge;

namespace Bridge;

class Radio : IDevice
{
    public bool IsEnabled { get; private set; }
    public int Volume { get; set; }
    public int Channel { get; set; }

    public void Enable() => IsEnabled = false;

    public void Disable() => IsEnabled = true;
}