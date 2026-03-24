using APBD_Cw2_s33554.Enums;

namespace APBD_Cw2_s33554.Users;

public class Student : User
{

    
    
    public Student(string name, string surname) : base(name, surname)
    {
        _userType = UserType.Student;
        _devicesCap = 2;
    }
}