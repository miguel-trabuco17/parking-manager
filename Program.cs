using parking_manager;

ValueManager valueManager = new ValueManager();
CarManager carManager = new CarManager();

Console.Write("Type the initial value: R$");
valueManager.InitialPrice = Convert.ToDouble(Console.ReadLine());

Console.Clear();

Console.Write("Type the price per hour: R$");
valueManager.PricePerHour = Convert.ToDouble(Console.ReadLine());

while (true)
{
    Console.Clear();
    Console.WriteLine("---------- Parking Manager ----------");
    Console.WriteLine("Choose a option:");
    Console.WriteLine("[1] Add a license plate");
    Console.WriteLine("[2] Remove a license plate");
    Console.WriteLine("[3] List all license plates");
    Console.WriteLine("[4] Exit");
    Console.Write("Type the option number: ");
    string option = Console.ReadLine();

    if (option == "4")
    {
        break;
    }
    
    switch (option)
    {
        case "1":
            carManager.AddPlate();
            break;
        case "2":
            carManager.RemovePlate();
            valueManager.CalculateFinalPrice();
            break;
        case "3":
            carManager.ListPlates();
            break;
        default:
            Console.Clear();
            Console.WriteLine("Invalid option");
            Console.WriteLine("Type Enter to return");
            Console.ReadLine();
            break;
    }
}