using System.ComponentModel.Design;

public class ProgramUI
{
    public void Run()
    {
        
    }
    public void Menu()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
        System.Console.WriteLine("Welcome to the Delivery Service App. Please select your option:\n" +
        "1. Add new delivery to the history\n" +
        "2. List an in-transit delivery\n" +
        "3. Update a delivery status\n" + 
        "4. Cancel a delivery\n" + 
        "5. Exit the app\n");

        //Getting user input here...
        string input = Console.ReadLine();

        //Let's evaluate the uer input and act accordingly to it...
        switch (input)
        {
            case "1":
                break;
            case "2":
                break;
            case "3":
                break;
            case "4":
                break;
            case "5":
                System.Console.WriteLine("Goodbye.");
                keepRunning = false;
                break;
                default:
                    System.Console.WriteLine("Please enter a valid number.");
                    break;
            }
        }
    }
}
