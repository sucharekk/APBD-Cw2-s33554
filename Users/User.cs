using System;
using APBD_Cw2_s33554.Enums;
using APBD_Cw2_s33554.Devices;
using APBD_Cw2_s33554.Mechanics;

namespace APBD_Cw2_s33554.Users;

public  class  User
{
    protected int _id;
    protected string _name;
    protected string _surname;
    protected UserType _userType;
    protected int _devicesCap = 0;
    protected int _devicesCount=0;
    

    public User( string name,string surname)
    {
        _id = Random.Shared.Next(1, 10000);
        _name = name;
        _surname = surname;
        _devicesCount = 0;
        Console.WriteLine("Welcome "+_name +" " + _surname);
    }


    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Surname
    {
        get => _surname;
        set => _surname = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    
    public override string ToString()
    {
        return $"name {_name} | surname: {_surname}";
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public int DevicesCap
    {
        get => _devicesCap;
        set => _devicesCap = value;
    }

    public int DevicesCount
    {
        get => _devicesCount;
        set => _devicesCount = value;
    }
}