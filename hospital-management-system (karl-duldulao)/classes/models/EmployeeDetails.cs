using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace hospital_management_system.classes
{
    [Alias("EmployeeDetails")]
    public class EmployeeDetails
    {
        [PrimaryKey][AutoIncrement]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Birthdate { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int AddressID { get; set; }
        public string RoleID { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedOn { get; set; }

    }
}
