using System;

namespace Exceptions 
{
    public class MyException: ApplicationException
    {
        public DateTime TimeException { get; private set; }

        public MyException(): base("Try rollback time")
        {
            
            TimeException = DateTime.Now;
        }
        
    }


    [Serializable]
    public class MyException1 : ApplicationException
    {
        public MyException1() { }
        public MyException1(string message) : base(message) { }
        public MyException1(string message, Exception inner) : base(message, inner) { }
        protected MyException1(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    throw new MyException();

            //}
            //catch (MyException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.TimeException);
            //}

            //    try
            //    {
            //        throw new MyException1("Back to Future");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message); 
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Finaly");
            //    }

            int numb1, numb2, result = 0;

            Console.WriteLine("Enter two number");

            try
            {
                numb1 = int.Parse(Console.ReadLine());
                numb2 = int.Parse(Console.ReadLine());
                result = numb1 / numb2;
                Console.WriteLine($"{numb1} / {numb2} = {result}");
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
                Console.WriteLine("Ti v shkolu ne xodil? Delit na 0????");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
