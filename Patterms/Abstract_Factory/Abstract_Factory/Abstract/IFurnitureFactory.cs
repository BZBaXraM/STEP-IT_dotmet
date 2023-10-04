namespace Abstract_Factory.Abstract
{
    internal interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ICoffeTable CreateCoffeTable();
        
    }
}
