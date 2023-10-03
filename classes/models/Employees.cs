﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace hospital_management_system
{
    [Alias("Employees")]
    public class Employees
    {
        [PrimaryKey][AutoIncrement]
        public int EmployeeID { get; set; }
        public int AddressID { get; set; }
        public int RoleID { get; set; }
        public int DepartmentID { get; set; }
        public int Status { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string GetFullname()
        {
            return ($"{this.FirstName} {this.MiddleName} {this.LastName}");
        }
    }
}
