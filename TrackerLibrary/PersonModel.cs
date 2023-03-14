using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string EmailAddress { get; set; }
       public string CellPhoneNumber { get; set; }
    }
}
