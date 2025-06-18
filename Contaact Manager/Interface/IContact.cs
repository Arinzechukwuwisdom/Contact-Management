using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Contaact_Manager.Models;

namespace Contaact_Manager.Interface
{
    interface IContact
    {
        void AddContact();
        void RemoveContact();
        void FindContact();
        void ListAllContacts();
        void ListSomeContacts();
    }
}
