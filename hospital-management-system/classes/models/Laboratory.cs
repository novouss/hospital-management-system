using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace hospital_management_system.classes
{
    [Alias("Laboratory")]
    public class Laboratory
    {
        public int LaboratoryID { get; set; }
        public int Status { get; set; }
        public int LabCharge { get; set; }
    }
}
