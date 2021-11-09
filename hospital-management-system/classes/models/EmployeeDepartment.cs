using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace hospital_management_system.classes
{
    [Alias("EmployeeDepartment")]
    public class EmployeeDepartment
    {
        public int DepartmentID { get; set; }
        public int EmployeeID { get; set; }
        public int Status { get; set; }
        public virtual EmployeeDetails employee { get; set; }
        public virtual Department department { get; set; }
    }
}
