using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace hospital_management_system
{
    [Alias("Roles")]
    public class Roles
    {
        public int RoleID { get; set; }
        public string Description { get; set; }
    }
}
