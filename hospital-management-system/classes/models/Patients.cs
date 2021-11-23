using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace hospital_management_system.classes
{
    [Alias("Patients")]
    public class Patients
    {
        [PrimaryKey][AutoIncrement]
        public int PatientID { get; set; }
        public int AddressID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}
