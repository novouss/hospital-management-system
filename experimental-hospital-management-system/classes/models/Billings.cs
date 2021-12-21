using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace experimental_hospital_management_system
{
    [Alias("Billings")]
    public class Billings
    {
        public int BillingID { get; set; }
        public int RegistrationID { get; set; }
        public int LaboratoryFee { get; set; }
        public int RoomFee { get; set; }
        public int DepartmentFee { get; set; }
        public int Status { get; set; }
        public int Total { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}
