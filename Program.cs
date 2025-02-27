namespace firstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallCarpet = 0;
            int largeCarpet = 0;

            Console.WriteLine("Islam's Carpet Cleaning Service\nCharges:\n$25 per small\n$35 per large\nSales tax rate is 6%\nEstimates are valid for 30 days\n");

            Console.WriteLine("Estimated for carpet cleaning service\n");

            Console.Write("Number of small carpets: ");
            smallCarpet = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of large carpets: ");
            largeCarpet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPrice per small room: $25");
            Console.WriteLine("Price per large room: $35");

            int costOfSmallCarpets = smallCarpet * 25;
            int costOfLargeCarpets = largeCarpet * 35;
            int totalCost = costOfSmallCarpets + costOfLargeCarpets;

            float tax = 0.06F;
            float totalTax = totalCost * tax;

            Console.WriteLine($"Cost: ${totalCost}");
            Console.WriteLine($"Tax: ${totalTax}");

            Console.WriteLine("\n===================================\n");

            float totalPriceAfterTax = totalCost + totalTax;

            Console.WriteLine($"Total estimate: ${totalPriceAfterTax}");
            Console.WriteLine("This estimate is valid for 30 days");

        }
    }
}
