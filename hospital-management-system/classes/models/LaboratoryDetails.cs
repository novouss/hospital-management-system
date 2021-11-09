using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace hospital_management_system.classes
{
    [Alias("LaboratoryDetails")]
    public class LaboratoryDetails
    {
        public int ReportID { get; set; }
        public string Results { get; set; }
    }
}
