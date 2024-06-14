namespace ExDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerator = 0, denominator = 0, quotient = 0;

            try
            {
                Console.WriteLine("Enter the numerator\t");
                numerator = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter denominator");
                denominator = Convert.ToInt32(Console.ReadLine());
                quotient = numerator / denominator;

                Console.WriteLine("Quotient is " + quotient);

            }

            catch (FormatException ex)
            {

                Console.WriteLine("Please enter integer");
            }

            catch (DivideByZeroException ex)
            {

                Console.WriteLine("Division by zero is not allowed");
            }

            catch (Exception ex) {

                Console.WriteLine("Sorry error occured");
            }

            finally
            {
                Console.WriteLine("execute");
            }
            
        }
    }
}
