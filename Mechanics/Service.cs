using APBD_Cw2_s33554.Devices;
using APBD_Cw2_s33554.Enums;
using APBD_Cw2_s33554.Errors;
using APBD_Cw2_s33554.Users;

namespace APBD_Cw2_s33554.Mechanics;

public class Service
{
    private List<User> _users;
    private List<Rent> _rents;
    private List<Device> _devices;

    public void Info()
    {
        Console.WriteLine("Starting Service");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Create a User");
        Console.WriteLine("2. Add a Device");
        Console.WriteLine("3. Show all devices with status");
        Console.WriteLine("4. Show  devices to rent");
        Console.WriteLine("5. Rent device");
        Console.WriteLine("6. Return device");
        Console.WriteLine("7. Show user rents");
        Console.WriteLine("8. Show expired devices");
        Console.WriteLine("9. Quick rental raport");
        Console.WriteLine("10. Close Service");
    }

    public void Program(int input)
    {
        switch (input)
        {
            case 1:
                Console.WriteLine("Input name <space> surname <space> user type");
                _users.Add(CreateUser(GetInput()));
                break;
            case 2:
                Console.WriteLine("Input device type <space> model <space> market price <space> quanity");
                _devices.Add(AddDevice(GetInput()));
                break;
            case 3:
                ShowDevices();
                break;
            case 4:
                ShowRentalDevices();
                break;
            case 5:
                Console.WriteLine("Input your name <space> your surname <space> device id (that you would like to rent)");
                RentADevice(GetInput());
                break;
            case 6:
                Console.WriteLine("Input your name <space> surname");
                ReturnDevice(GetInput());
                break;
            case 7:
                Console.WriteLine("Input id of device you would like to mark unavailable");
                TurnOffDevice(GetInput());
                break;
            case 8:
                Console.WriteLine("Input your name <space> surname");
                ShowUserRents(GetInput());
                break;
            case 9 :
                ShowOutDatedRents();
                break;
        }
    }

    private User CreateUser(string input)
    {
        if (input.Length != 3)
            throw new WrongInputException();

        string[] tokens = ShapeInput(input);
        string name = tokens[0];
        string surname = tokens[1];
        string userType = tokens[2];
        switch (userType)
        {
            case "Student":
                return new Student(name, surname);
            case "Teacher":
                return new Teacher(name, surname);
            case "Employee":
                return new Employee(name, surname);
            default:
                throw new UnkownTypeException("user type");
        }
    }


    private void TurnOffDevice(string input)
    {
        int id = int.Parse(input);
        
        
        
    }

    private Device AddDevice(string input)
    {
        if (input.Length != 4)
            throw new WrongInputException();
        string[] tokens = ShapeInput(input);
        string deviceType = tokens[0];
        string model = tokens[1];
        double marketPrice = double.Parse(tokens[2]);
        int quanity = int.Parse(tokens[3]);

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
                throw new UnkownTypeException("device type");
        }
    }

    private void RentADevice(string input)
    {
        if (input.Length != 3)
            throw new WrongInputException();
        string[] tokens = ShapeInput(input);
        
        string name = tokens[0];
        string surname = tokens[1];
        int id = int.Parse(tokens[2]);
        User user = CheckForUser(name, surname);
        Device device = CheckForDevice(id);
        
        if(user  is null ||  device is null)
            throw new WrongInputException("User not found or Device not available");

        if (user.DevicesCount + 1 > user.DevicesCap)
            throw new TooManyDevices();
        
        _rents.Add(new Rent(user, device));
        user.DevicesCount++;
     
        Console.WriteLine(user + " rented " + device);
        
        
    }

    private Device CheckForDevice(int id)
    {
        foreach (Device device in _devices)
            {
            if (device.Id == id && device.IsAvailable)
                return device;
            }
        return null;
    }

    private User CheckForUser(string name, string surname)
    {
        foreach (User user in _users)
        {
            if(user.Name.Equals(name) && user.Surname.Equals(surname))
                return user;
        }
        return null;
    }


    public static string GetInput()
    {
        return Console.ReadLine();
    }

    private string[] ShapeInput(string input)
    {
        string[] tokens = input.Split("/s+");
        foreach (string token in tokens)
        {
            token.ToLower().Trim();
        }

        return tokens;
    }

    public static bool YesNoOption(string input)
    {
        switch (input.ToLower().Trim())
        {
            case "yes":
                return true;
            case "no":
                return false;
            default:
                throw new WrongInputException();
        }
    }

    private void ShowDevices()
    {
        foreach (Device device in _devices)
            Console.WriteLine(device);
    }

    private void ShowRentalDevices()
    {
        foreach (Device device in _devices)
        {
            if(device.IsAvailable)
                Console.WriteLine(device);
        }
            
    }
    
    private void ReturnDevice(string input)
    {
        string [] tokens = input.Split("/s+");
        string name = tokens[0];
        string surname = tokens[1];
        User user = CheckForUser(name, surname);
        List<Rent> rents = LookForRents(user);
        if (rents is null)
        {
            throw new WrongInputException("Rental not found");
        }
        Console.WriteLine("Choose rent you would like to return : id>");
        Console.WriteLine(rents);
        int id = int.Parse(Console.ReadLine());
        Rent rent = rents.Find(e => e.Device.Id==id);
        if (rent is null)
            throw new WrongInputException("Rental not found");
        int fee = rent.CalculateFee();
        user.DevicesCount--;
        _rents.Remove(rent);
        Console.WriteLine("Rental fee: " + fee + " thank you");
        
        
    }

    private List<Rent> LookForRents(User user)
    {
        List<Rent> rents = new List<Rent>();
        foreach (Rent rent in _rents)
        {
            if(rent.User.Id == user.Id)
                rents.Add(rent);
        }
        return rents;
        
            
        
    }

    private void ShowUserRents(string input)
    {
        string [] tokens = input.Split("/s+");
        string name = tokens[0];
        string surname = tokens[1];
        User user = CheckForUser(name, surname);
        if(user is null)
            throw new WrongInputException("User not found");
        LookForRents(user);

    }


    private void ShowOutDatedRents()
    {
        foreach (Rent rent in _rents)
        {
            if(rent.CalculateFee() > 0 )
                Console.WriteLine(rent);
        }
    }
}
