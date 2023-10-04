Context context = new Context(new Binary());
context.Serialize();


class Context
{
    private readonly ISerializer _serializer;

    public Context(ISerializer serializer)
    {
        _serializer = serializer;
    }

    public void Serialize()
    {
        _serializer.Serialize();
    }
}