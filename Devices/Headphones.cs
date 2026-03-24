using APBD_Cw2_s33554.Enums;
using APBD_Cw2_s33554.Errors;
using APBD_Cw2_s33554.Mechanics;

namespace APBD_Cw2_s33554.Devices;


public class Headphones : Device
{
    private bool _isWireless;
    private bool _microphone;
    public Headphones(string model, double marketPrice, int quantity) : base(model, marketPrice, quantity)
    {
        _type = DeviceType.HEADPHONES;
        Console.WriteLine("Is wireless ? Yes/No");
        _isWireless = Service.YesNoOption(Console.ReadLine());
        Console.WriteLine("Does have a microphone ? Yes/No");
        _microphone = Service.YesNoOption(Console.ReadLine());
        
    }
}