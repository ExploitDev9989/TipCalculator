namespace TipCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double billAmount;

            // Validate bill amount from command line
            if (args.Length == 0 || !double.TryParse(args[0], out billAmount) || billAmount < 0)
            {
                Console.WriteLine("Please provide a valid bill amount as a command line argument.");
                return;
            }

            // Ask user for tip percentage
            Console.Write("Enter tip percentage (example: 15): ");
            double tipPercent = double.Parse(Console.ReadLine());

            // Convert percent to decimal
            double tipRate = tipPercent / 100;

            double tipAmount = billAmount * tipRate;

            Console.WriteLine();
            Console.WriteLine("*********************************************");
            Console.WriteLine($"Bill Amount: \t{billAmount,8:C}");
            Console.WriteLine($"Tip Amount : \t{tipAmount,8:C} ({tipRate:P1})");
            Console.WriteLine(("").PadRight(25, '-'));
            Console.WriteLine($"Grand Total : \t{billAmount + tipAmount,8:C}");
            Console.WriteLine("*********************************************");
        }
    }
}
