namespace PalindromNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int input =Convert.ToInt32(Console.ReadLine());
            Reverse.ReverseFunction(input);
        }
    }
}