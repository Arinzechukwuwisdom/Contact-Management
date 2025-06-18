using System;
using System.Collections.Generic;
using System.Text;
using Contaact_Manager.Models;

namespace Contaact_Manager.Collections
{
    public class ContactBook
    {
        Dictionary<string, Contact> userDictionary = new Dictionary<string, Contact>();
    }
}
