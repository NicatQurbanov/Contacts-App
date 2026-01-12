using Contact.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Contact.Controllers
{
    public class ProfileController
    {
        public Profile[] profiles;
        public ProfileController() 
        {
            this.profiles = new Profile[1];
        } 

        public void AddProfile(Profile profile)
        {
            this.profiles[0] = profile;
            Array.Resize(ref profiles, profiles.Length + 1);
        }

        public void AddProfile(string input)
        {
            string[] processedInput = ProcessInput(input);

            this.profiles[0] = new Profile(processedInput[0], processedInput[1]);
            Array.Resize(ref profiles, profiles.Length + 1);
        }

      

        private string[] ProcessInput(string input)
        {
            string[] userInput = input.Split(",");
            string[] processedInput = new string[userInput.Length];

            for (int i = 0; i < userInput.Length; i++)
            {
                processedInput[i] = userInput[i].Trim();
            }

            return processedInput;
        }

    }
}
