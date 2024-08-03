namespace parking_manager;

public class CarManager
{
    public List<string> LicensePlates { get; set; }

    public CarManager()
    {
        LicensePlates = new List<string>();
    }

    public void AddPlate()
    {
        string plate;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---------- Add License Plate ----------");
            Console.Write("Type the license plate: ");
            plate = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(plate))
            {
                break;
            }
            
            Console.Clear();
            Console.WriteLine("Invalid plate");
            Console.WriteLine("Press Enter to return");
            Console.ReadLine();
        }
        LicensePlates.Add(plate);
    }

    public void RemovePlate()
    {
        string plate;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---------- Remove License Plate ----------");
            
            Console.Write("Type the license plate: ");
            plate = Console.ReadLine();
            
            if (!string.IsNullOrWhiteSpace(plate))
            {
                bool isRemoved = LicensePlates.Remove(plate);
                if (isRemoved == true)
                {
                    break;
                }
            }

            Console.Clear();
            Console.WriteLine("Invalid plate");
            Console.WriteLine("Press Enter to return");
            Console.ReadLine();
        }
    }

    public void ListPlates()
    {
        Console.Clear();
        Console.WriteLine("---------- List License Plate ----------");
        foreach (string plate in LicensePlates)
        {
            Console.WriteLine(plate);
        }
        Console.WriteLine("Press Enter to return");
        Console.ReadLine();
    }
}