namespace APBD_Cw2_s33554.Mechanics;

public class Launcher
{

    public static void Main(string[] args)
    {
        Service service = new Service();

        while (true)
        {
            service.Info();
            string rawInput = Console.ReadLine();

            if (int.TryParse(rawInput, out int option))
            {
                if (option == 11) 
                    break;
                service.options(option);
            }
            else
            {
                Console.WriteLine("Choose an option");
            }

            
        }
    }
    
    
    
    
}