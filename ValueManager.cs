namespace parking_manager;

public class ValueManager
{
    public double InitialPrice { get; set; }
    public double PricePerHour { get; set; }

    public void CalculateFinalPrice()
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Type the parked hours: ");
            int completeHours = Convert.ToInt32(Console.ReadLine());
            
            if (completeHours == 0)
            {
                Console.WriteLine($"Value: R${InitialPrice}");
                Console.WriteLine("Type Enter to return");
                Console.ReadLine();
                break;
            } else if (completeHours > 0)
            {
                double hours = Convert.ToDouble(completeHours);
                double finalPrice = hours * PricePerHour + InitialPrice;
                Console.WriteLine($"Value: R${finalPrice}");
                Console.WriteLine("Type Enter to return");
                Console.ReadLine();
                break;
            }
            
            Console.Clear();
            Console.WriteLine("Invalid hour");
            Console.WriteLine("Press Enter to return");
            Console.ReadLine();
        }
    }
}