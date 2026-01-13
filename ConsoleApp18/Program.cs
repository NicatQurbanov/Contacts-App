

using Contact.Controllers;
using Contact.Models;
using System.ComponentModel;

namespace Contact
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? readResult;
            string menuSelection = "";
            ProfileController profileController = new ProfileController();
            //Profile nijat = new Profile("nijat", "qwerty90");
            //Profile ali = new Profile("ali", "qwerty901");
            //Profile vusal = new Profile("vusal", "qwerty902");
            //Profile seyyad = new Profile("seyyad", "qwerty903");

            //Contact new_contact = new Contact("nijat", "qurbanov", "+994504949494");

            do
            {
                Console.WriteLine("Welcome. Choose option:\n1.Sign in.\n2.Sign up.\n");
                Console.WriteLine("Enter exit to leave application.");
                readResult = Console.ReadLine();
                if (readResult != null)
                   menuSelection = readResult.ToLower();
                
                switch(menuSelection)
                {
                    case "1":

                        Console.WriteLine("Create nickname and password separated by comma (,)\nRequirements: \n" +
                                        "1. The nickname should consist of at least 3 characters and at most 20 characters.\n" +
                                        "2. The password should contain at least one uppercase letter, one lowercase letter, one symbol, and one number.\n" +
                                        "\tThe minimum length of password is: 6\n" +
                                        "\tThe maximum length of password is: 20\n");
                        readResult = Console.ReadLine();
                        
                        break;
                    case "2":


                        break;
                }

            } while (menuSelection != "exit");
            

            

            


            //ContactController contactController = new ContactController(profileController.profiles[0]);
            //contactController.AddContact(new_contact);

            

        }
    }
}