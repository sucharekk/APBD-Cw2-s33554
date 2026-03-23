using APBD_Cw2_s33554.Devices;
using APBD_Cw2_s33554.Enums;
using APBD_Cw2_s33554.Errors;
using APBD_Cw2_s33554.Users;

namespace APBD_Cw2_s33554.Mechanics;

public class Service
{
    private List<User> _users;
    private List<Rent> _rents;

    public void info()
    {
        Console.WriteLine("Starting Service");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Create a User");
        Console.WriteLine("2. Add a Device");
        Console.WriteLine("3. Show all devices with status");
        Console.WriteLine("4. Show  devices to rent");
        Console.WriteLine("5. Rent device");
        Console.WriteLine("7. Return device");
        Console.WriteLine("8. Show user rents");
        Console.WriteLine("9. Show expired devices");
        Console.WriteLine("10. Quick rental raport");
        Console.WriteLine("11. Close Service");
    }

    public void program(int input)
    {
        switch (input)
        {
            case 1:
                Console.WriteLine("Input name <space> surname <space> user type");
                createUser(getInput());
                break;
        }
    }

    public User createUser(string input)
    {
        if (input.Length != 3)
            throw new WrongInput();

        string[] tokens = input.Split("/s+");
        string name = tokens[0];
        string surname = tokens[1];
        string userType = tokens[2];
        userType = userType.ToLower().Trim();
        switch (userType)
        {
            case "Student":
                return new Student(name, surname);
            case "Teacher":
                return new Teacher(name, surname);
            case "Employee":
                return new Employee(name, surname);
            default:
                throw new UnkownUserType();
        }
        
    }

    public Device addDevice(string deviceType, string model, double marketPrice, int quanity)
    {
        deviceType = deviceType.ToLower().Trim();
        switch (deviceType)
        {
            case "keyboard":
                return new Keyboard(model, marketPrice, quanity);

            case "laptop":
                return new Laptop(model, marketPrice, quanity);
            case "headphones":
                return new Headphones(model, marketPrice, quanity);
            case "stuff":
                return new Stuff(model, marketPrice, quanity);
            case "mouse":
                return new Mouse(model, marketPrice, quanity);
            default:
                Console.WriteLine("Unknown user type");
                return null;
        }
    }


    private String getInput()
    {
        return Console.ReadLine();
    }
}