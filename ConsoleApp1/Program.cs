// Usama Mohamed task 1
namespace ConsoleApp1
{
    class Book
    {
      public string Title;
      public int Pages;

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.Title = "A Song Of Ice And Fire";
            b1.Pages = 999;

            object obj = b1;
            Console.WriteLine(obj);

            /////////////////////////////////////////////
            Console.WriteLine(b1.ToString());

            Console.WriteLine(b1.Equals(b1));

            Console.WriteLine(b1.GetHashCode());

            Console.WriteLine(b1.GetType());
            ///////////////////////////////////////////////   
            // error  int pages = "80";
            int pages = 80;
            ////////////////////////////////////////////////////
            
            int x = 0;

            try
            {
                int result = 10 / x;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }
        
    }
}
