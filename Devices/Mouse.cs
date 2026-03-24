using System;
using APBD_Cw2_s33554.Enums;
using APBD_Cw2_s33554.Mechanics;

namespace APBD_Cw2_s33554.Devices;

public class Mouse : Device
{
    private bool _isWireless;
    private int _dpi;
    public Mouse(string model, double marketPrice, int quantity) : base(model, marketPrice, quantity)
    {
        _type = DeviceType.MOUSE;
        Console.WriteLine("Is wireless ? Yes/No");
        _isWireless = Service.YesNoOption(Console.ReadLine());
        Console.WriteLine("How many dpi does it have ?");
        _dpi = Convert.ToInt32(Console.ReadLine());
    }
}