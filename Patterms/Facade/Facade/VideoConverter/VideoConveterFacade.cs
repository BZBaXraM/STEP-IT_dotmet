class VideoConveterFacade
{
    public IFile Convert(string filename, string format)
    {
        IFile file = new VideoFile(filename);
        string sourceCodec = new CodecFactory().Extract(file);
        BaseCompressionCodec destinationCodec = null;
        if (format == "mp4") destinationCodec = new H264Compression();
        else if (format == "ogg") destinationCodec = new OggCompression();
        else destinationCodec = new BaseCompressionCodec();

        string buffer = BitrateReader.Read(filename, sourceCodec);
        string result = BitrateReader.Convert(buffer, destinationCodec);
        result = new AudioMixer().Fix(result);
        return new VideoFile(result);
    }
}