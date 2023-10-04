class BitrateReader
{
    public static string Read(string filename, string sourceCodec) => $"{filename} {sourceCodec} Read";
    public static string Convert(string filename, BaseCompressionCodec codec) => $"{filename} {codec} Convert";
}