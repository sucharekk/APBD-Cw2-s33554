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
    protected List<Rent> _listOfRents;

    public User( string name,string surname)
    {
        _id = Random.Shared.Next(1, 10000);
        _name = name;
        _surname = surname;
        Console.WriteLine("Welcome "+_name +" " + _surname);
    }
    
}