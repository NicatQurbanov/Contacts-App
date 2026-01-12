using Contact.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.Controllers
{
    public class ContactController
    {
        public Contact[] contacts;
        public Profile profile;

        public ContactController(Profile profile)
        {
            contacts = new Contact[1]; 
            this.profile = profile;
        }

        public void AddContact(Contact contact)
        {
            this.profile.contacts[0] = contact;
            Array.Resize(ref contacts, contacts.Length + 1);
        }

        public void AddContact(string firstName, string lastName, string phoneNumber)
        {
            this.profile.contacts[0] = new Contact(firstName, phoneNumber, lastName);
            Array.Resize(ref contacts, contacts.Length + 1);
        }

         
    }
}
