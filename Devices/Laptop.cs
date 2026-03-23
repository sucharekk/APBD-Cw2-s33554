using APBD_Cw2_s33554.Enums;

namespace APBD_Cw2_s33554.Devices;

public class Laptop : Device
{
    public Laptop(string model, double marketPrice, int quanity) : base(model, marketPrice, quanity)
    {
        _type = DeviceType.LAPTOP;
    }
}