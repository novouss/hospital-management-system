using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace hospital_management_system.classes
{
    [Alias("Laboratories")]
    public class Laboratories
    {
        public int LaboratoryID { get; set; }
        public String LaboratoryNumber { get; set; }
        public int Status { get; set; }
        public int Fee { get; set; }
    }
}
