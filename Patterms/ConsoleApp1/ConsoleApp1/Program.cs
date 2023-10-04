using FactoryMethod.Abstract.Concreate;

namespace FactoryMethod.Abstract
{
    internal class Program
    {
        static void Main()
        {
            //while (true)
            //{
            //    Thread.Sleep(1000);
            //    Logistics logistics = new AirLogistics();
            //    ITransport transport = logistics.CreateTransport();
            //    transport.Deliver();
            //}

            Logistics? logistics = null;
            ITransport? transport = null;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(@"
1. Road
2. Sea
3. Air
Any: Exit");
                Console.Write("c ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        logistics = new RoadLogistics();
                        break;
                    case "2":
                        logistics = new SeaLogistics();
                        break;
                    case "3":
                        logistics = new AirLogistics();
                        break;
                    default:
                        logistics = null;
                        break;
                }

                if (logistics == null) break;
                transport = logistics.CreateTransport();
                transport?.Deliver();
                Console.ReadLine();
            }
        }
    }
}