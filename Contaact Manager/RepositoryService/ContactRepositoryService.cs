using System;
using System.Collections.Generic;
using System.Text;
using Contaact_Manager.Interface;

namespace Contaact_Manager.RepositoryService
{
    internal class ContactRepositoryService : IContact
    {
        public void AddContact()
        {
            // Implementation for adding a contact
        }
        public void RemoveContact()
        {
            // Implementation for removing a contact
        }
        public void FindContact()
        {
            // Implementation for finding a contact
        }
        public void ListAllContacts()
        {
            // Implementation for listing all contacts
        }
        // List all contacts that have a/some character(s).. This could be on their names or phone number
    
        public void ListSomeContacts()
        {
            throw new NotImplementedException();
        }
    }
}
