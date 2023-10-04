namespace Adapter;

class Mp3 : IAudioFile
{
    public void Play()
    {
        Console.WriteLine("MP3");
    }
}