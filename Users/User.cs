using APBD_Cw2_s33554.Enums;
using APBD_Cw2_s33554.Devices;

namespace APBD_Cw2_s33554.Users;

public  class  User
{
    protected int _id;
    protected string _name;
    protected string _surname;
    protected UserType _userType;
    protected List<Device> _listOfDevices;

    public User( string name,string surname)
    {
        _id = Random.Shared.Next(1, 10000);
        _name = name;
        _surname = surname;
    }

   


    public void Rent(Device rentedDevice)
    {
        if (!rentedDevice.IsAvailable)
        {
            Console.WriteLine("Device is not available");
            return;
        }
        _listOfDevices.Add(rentedDevice);
        rentedDevice.Quanity -= 1;
    }
}