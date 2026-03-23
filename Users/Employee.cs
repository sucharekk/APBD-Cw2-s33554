using APBD_Cw2_s33554.Enums;

namespace APBD_Cw2_s33554.Users;

public class Employee : User
{
    public Employee(string name, string surname) : base(name, surname)
    {
        _userType = UserType.Employee;
    }
}