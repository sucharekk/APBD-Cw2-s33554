using APBD_Cw2_s33554.Devices;
using APBD_Cw2_s33554.Enums;
using APBD_Cw2_s33554.Users;

namespace APBD_Cw2_s33554.Mechanics;

public class Service
{
    public User createUser( string name,string surname , String userType)
    {
        name = name.ToLower().Trim();
        switch(userType)
        {
            case "Student":
                return new Student( name, surname);
            case "Teacher":
                return new Teacher( name, surname);
            case "Employee":
                return new Employee( name,surname);
            default:
                Console.WriteLine("Unknown user type");
                return null;
        }
    }
    public Device addDevice(  string deviceType,string model,double marketPrice, int quanity)
    {
        deviceType = deviceType.ToLower().Trim();
        switch(deviceType)
        {
            case "keyboard":
                return new Keyboard(model,marketPrice,quanity);
                
            case "laptop":
                return new Laptop(model,marketPrice,quanity);
            case "headphones":
                return new Headphones( model, marketPrice, quanity);
            case "stuff":
               return new Stuff(model, marketPrice, quanity);
            case "mouse":
                return new Mouse(model, marketPrice, quanity);
            default:
                Console.WriteLine("Unknown user type");
                return null;
        }
    }
}