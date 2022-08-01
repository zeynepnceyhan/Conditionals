
namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            var number1 = 15;
            if(number == 10)
            {
                Console.WriteLine("The number is 10!");
            }
            else
            {
                Console.WriteLine("The number is not 10!");
            }


            Console.WriteLine("Single Line if: ");
            Console.WriteLine(number == 10 ? "The number is 10!" : "The number is not 10!");

            if(number1 == 15)
            {
                Console.WriteLine("The number1 is 15!");
            }
            else if(number1 == 25)
            {
                Console.WriteLine("The number1 is 25!");
            }
            else
            {
                Console.WriteLine("The number1 is not 15 or 25!");
            }
            
            Console.ReadLine();
        }

    }
}