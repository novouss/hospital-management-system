using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace hospital_management_system.classes
{
    [Alias("Departments")]
    public class Departments
    {
        public int DepartmentID { get; set; }
        public string Description { get; set; }
        public int Fee { get; set; }
    }
}
