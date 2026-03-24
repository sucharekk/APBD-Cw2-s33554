using System;
using APBD_Cw2_s33554.Enums;
using APBD_Cw2_s33554.Mechanics;

namespace APBD_Cw2_s33554.Devices;

public class Stuff : Device
{
    private string _object;
    private bool _isBroken;
    public Stuff(string model, double marketPrice, int quantity) : base(model, marketPrice, quantity)
    {
        _type = DeviceType.ACADEMY_STUFF;
        Console.WriteLine("What is it");
        _object = Console.ReadLine();
        Console.WriteLine("Is it broken ? Yes/No");
        _isBroken = Service.YesNoOption(Console.ReadLine());
    }
}