using APBD_Cw2_s33554.Devices;
using APBD_Cw2_s33554.Users;

namespace APBD_Cw2_s33554.Mechanics;

public class Rent
{
    private User _user;
    private Device _device;
    private DateOnly _date;
    private double _fee;
    private bool _closed;
}