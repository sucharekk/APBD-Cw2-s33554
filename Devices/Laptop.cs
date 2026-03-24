using APBD_Cw2_s33554.Enums;

namespace APBD_Cw2_s33554.Devices;

public class Laptop : Device
{
    private int _ram;
    private int _batteryLife;
    public Laptop(string model, double marketPrice, int quantity) : base(model, marketPrice, quantity)
    {
        _type = DeviceType.LAPTOP;
        Console.WriteLine("How many gb of ram does it have ?");
        _ram = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("For how many hours does it work ?");
        _batteryLife = Convert.ToInt32(Console.ReadLine());
        
    }
}