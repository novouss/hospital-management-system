using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.classes
{
    public class patient
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string middlename{ get; set; }
        public string lastname { get; set; }
        public string birthdate { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string email{ get; set; }
        public string number { get; set; }
        public string address_id { get; set; }
        public string role_id { get; set; }
        public string password{ get; set; }
        public string created_on { get; set; }
        public string modified_on { get; set; }
        
    }
}
