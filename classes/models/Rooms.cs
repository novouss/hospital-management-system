using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace hospital_management_system
{
    [Alias("Rooms")]
    public class Rooms
    {
        public int RoomID { get; set; }
        public String RoomNumber { get; set; }
        public int Status { get; set; }
        public int Fee { get; set; }
    }
}
