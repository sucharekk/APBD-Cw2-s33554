using APBD_Cw2_s33554.Enums;

namespace APBD_Cw2_s33554.Users;

public class Teacher : User
{
    public Teacher(string name, string surname) : base(name, surname)
    {
        _userType = UserType.Teacher;
    }
}