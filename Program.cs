namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*    task 1    */
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\t\t\t\tWelcome to Islam Shop\n\n");

            double TotalPrice = 0;
            int SmallSize = 250;
            int largesize = 350;
            double tax = 0.14;
            double TotalTax;

            Console.WriteLine($"Small Size Price: {SmallSize:C} \nLarge Size Price: {largesize:C} \nthe Tax :{tax:P}");

            Console.Write("\nEnter How Many Small Size Carpet You Want to clean: ");
            int smallCount = Convert.ToInt32(Console.ReadLine());
            TotalPrice += SmallSize * smallCount;

            Console.Write("\nEnter How Many Big Size Carpet You Want to clean: ");
            int bigCount = Convert.ToInt32(Console.ReadLine());
            TotalPrice += largesize * bigCount;

            TotalTax = TotalPrice * tax;
            Console.WriteLine($"\n\nTotal Price is: {TotalPrice:C}");
            Console.WriteLine($"Total Tax is: {TotalTax:C}");

            TotalPrice += TotalTax;
            Console.WriteLine("================================");
            Console.WriteLine($"Total Price with Tax is: {TotalPrice:C}");
            Console.WriteLine("This estimate is valid for 30 days");



        }
    }
}
