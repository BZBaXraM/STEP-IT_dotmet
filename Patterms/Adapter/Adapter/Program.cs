namespace Adapter;

class OggAdapter : IAudioFile
{
    private readonly Ogg? _ogg = null;

    public OggAdapter()
    {
        _ogg = new Ogg();
    }

    public void Play()
    {
        _ogg.PlayOgg();
    }
}

// class OggAdapter : Ogg, IAudioFile
// {
//     public void Play()
//     {
//         PlayOgg();
//     }
// }

internal class Program
{
    static void Main()
    {
        List<IAudioFile> rafetElRoman = new List<IAudioFile>()
        {
            new Flac(),
            new Waw(),
            new Mp3(),
            new OggAdapter()
        };
        foreach (var audioFile in rafetElRoman)
        {
            audioFile.Play();
            Thread.Sleep(2000);
        }
    }
}