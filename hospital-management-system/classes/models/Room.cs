using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace hospital_management_system.classes
{
    [Alias("Room")]
    public class Room
    {
        public int RoomID { get; set; }
        public int Status { get; set; }
        public int RoomCharge { get; set; }
    }
}
