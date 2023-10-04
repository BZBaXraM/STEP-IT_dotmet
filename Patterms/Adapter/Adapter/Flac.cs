namespace Adapter;

class Flac : IAudioFile
{
    public void Play()
    {
        Console.WriteLine("FLAC");
    }
}