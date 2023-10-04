class VideoFile : IFile
{
    string s;
    public VideoFile(string fileName)
    {
        s = fileName;
    }

    public override string ToString()
    {
        return s;
    }
}