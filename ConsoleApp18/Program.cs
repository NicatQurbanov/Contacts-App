

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
            string menuSelection;
            ProfileController profileController = new ProfileController();
            Profile nijat = new Profile("nijat", "qwerty90");
            Profile ali = new Profile("ali", "qwerty901");
            Profile vusal = new Profile("vusal", "qwerty902");
            Profile seyyad = new Profile("seyyad", "qwerty903");

            Contact new_contact = new Contact("nijat", "qurbanov", "+994504949494");

            Console.WriteLine("Welcome. Enter your nickname and password to sign in separated by comma(,)");
            readResult = Console.ReadLine();

            


            ContactController contactController = new ContactController(profileController.profiles[0]);
            contactController.AddContact(new_contact);

            

        }
    }
}