using System;

namespace APBD_Cw2_s33554.Errors;

public class TooManyDevices : Exception
{
    public TooManyDevices() : base("Too many devices")
    {
    }
}