using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace hospital_management_system
{
    [Alias("Reports")]
    public class Reports
    {
        public int ReportID { get; set; }
        public int RegistrationID { get; set; }
        public int DepartmentID { get; set; }
        public int EmployeeID { get; set; }
        public int LaboratoryID { get; set; }
        public string Report { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
