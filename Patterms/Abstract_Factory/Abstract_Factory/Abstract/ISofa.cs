namespace Abstract_Factory.Abstract
{
    internal interface ISofa
    {
        bool HasConrner { get; set; }
        bool CanOpen { get; set; }
        void SitOn();
    }
}
