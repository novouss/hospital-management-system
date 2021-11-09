using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace hospital_management_system.classes
{
    [Alias("Registration")]
    public class PatientRegistration : LaboratoryDetails
    {
        [PrimaryKey][AutoIncrement]
        public int RegistrationID { get; set; }
        public int PatientID { get; set; }
        public DateTime AdmissionOn { get; set; }
        public DateTime DischargeOn { get; set; }
        public int EmployeeID { get; set; }
        public int RoomID { get; set; }
        public int LaboratoryID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
