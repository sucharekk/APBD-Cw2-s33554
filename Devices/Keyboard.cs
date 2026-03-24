using APBD_Cw2_s33554.Enums;
using APBD_Cw2_s33554.Mechanics;

namespace APBD_Cw2_s33554.Devices;

public class Keyboard : Device

{
    private bool _isRGB;
    private string _switchesType;
    public Keyboard(string model, double marketPrice, int quantity) : base(model, marketPrice, quantity)
    {
        _type = DeviceType.KEYBOARD;
        Console.WriteLine("Is rgb ? Yes/No");
        _isRGB = Service.YesNoOption(Console.ReadLine());
        Console.WriteLine("What type of swtiches does it have ?");
        _switchesType = Console.ReadLine();
    }
}