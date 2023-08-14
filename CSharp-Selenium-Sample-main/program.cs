using System;
namespace csharp_selenium_lambdatest
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (Object obj in args)
            {
                String test = obj.ToString();
                switch (test)
                {
                    case "single":
                        SingleTest.execute();
                        break;
                    case "parallel":
                        ParallelTests.execute();
                        break;
                    default:
                        SingleTest.execute();
                        break;
                }
            }
        }
    }
}