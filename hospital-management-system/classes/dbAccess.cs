using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace hospital_management_system.classes
{
    public class dbAccess
    {
        public List<EmployeeDetails> findAccount(string email, string password)
        {
            /* using (IDbConnection CONNECTION = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
             {
                 var output = CONNECTION.Query<EmployeeDetails>($"dbo.USP_FindAccount @Email = '{ email }', @Password = '{ password }'");

                 if (output.Count() == 1)
                 {
                     return (List<EmployeeDetails>)output;
                 }
             */
                    return null; 
            //}
        }

        public List<EmployeeDepartment> findDepartmentEmployees(int departmentID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<EmployeeDepartment>($"dbo.USP_FindDepartmentEmployees @DepartmentID = '{ departmentID }'");

                return (List<EmployeeDepartment>)output;
            }       
        }

        #region Appointment Functions
        public void addAppointment(PatientRegistration registration)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                // At exactly 4:45 am 10th of November 2021, Raymond Brian D. Gorospe (@Novous) has finally fixed a bug on this exact line that's been causing 3 hours of back pain, stress, anger, anxiety, and loss of hope, to finally fix a bug caused by a misspelling error. 
                // The Adminssion Incident of November 10 2021, AdmissionOn was spelled AdminssionOn.
                connection.Execute($"dbo.USP_AddRegistration @PatientID, @AdmissionOn, @DischargeOn, @EmployeeID, @RoomID, @LaboratoryID, @Results", registration);
            }
        }

        public List<PatientRegistration> getRegistrationInformation()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<PatientRegistration>($"SELECT * FROM dbo.V_RegisterInformation");

                return (List<PatientRegistration>)output;
            }
        }

        #endregion

        #region Roles Functions

        public List<Role> getRoles()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Role>($"SELECT * FROM dbo.V_RoleInformation");

                return (List<Role>)output;
            }
        }

        public List<Role> findRole(int role_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Role>($"dbo.USP_FindRole @RoleID = '{ role_id }'");

                return (List<Role>)output;
            }
        }

        #endregion

        #region Department Functions
        public List<Department> getDepartments()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Department>($"SELECT * FROM dbo.V_DepartmentInformation");

                return (List<Department>)output;
            }
        }
        
        public List<Department> findDepartment(int department_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Department>($"dbo.USP_FindDepartment @DepartmentID = '{ department_id }'");

                return (List<Department>)output;
            }
        }

        #endregion

        #region Room Function
        public List<Room> getRoomInformation()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Room>($"SELECT * FROM dbo.V_RoomInformation");

                return (List<Room>)output;
            }
        }

        public List<Room> getAvailableRooms(int status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Room>($"dbo.USP_FindAvailableLaboratories @Status = '{ status }'");

                return (List<Room>)output;
            }
        }

        #endregion

        #region Laboratory Functions

        public List<Laboratory> getLaboratoryInformation()
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Laboratory>($"SELECT * FROM dbo.V_LaboratoryInformation");

                return (List<Laboratory>)output;
            }
        }

        public List<Laboratory> getAvailableLaboratories(int status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Laboratory>($"USP_FindAvailableLaboratories @Status = '{ status }'");

                return (List<Laboratory>)output;
            }
        }
        #endregion

        #region Patient Functions

        public void addPatient(PatientDetails patient)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                connection.Execute("dbo.USP_AddPatient @FirstName, @LastName, @MiddleName, @Birthdate, @Gender, @Religion, @Email, @PhoneNumber, @Address1, @Address2, @City, @Province, @Zipcode, @Country", patient);
            }
        }

        public void modifyPatient(PatientDetails patient)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                connection.Execute("dbo.USP_ModifyPatient @PatientID, @FirstName, @LastName, @MiddleName, @Birthdate, @Gender, @Religion, @Email, @PhoneNumber, @Address1, @Address2, @City, @Province, @Zipcode, @Country", patient);
            }
        }

        public List<PatientDetails> getPatientInformation()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<PatientDetails>($"SELECT * FROM dbo.V_PatientInformation");

                return (List<PatientDetails>)output;
            }
        }
        #endregion

        #region Employee Functions
        
        public void addEmployee(EmployeeDetails employee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                connection.Execute("dbo.USP_AddEmployee @FirstName, @LastName, @MiddleName, @Birthdate, @Gender, @Religion, @Email, @PhoneNumber, @Password, @RoleID, @DepartmentID, @Address1, @Address2, @City, @Province, @Zipcode, @Country", employee);
            }
        }

        public void modifyEmployee(EmployeeDetails employee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                connection.Execute("dbo.USP_ModifyEmployee @EmployeeID, @FirstName, @LastName, @MiddleName, @Birthdate, @Gender, @Religion, @Email, @PhoneNumber, @Password, @RoleID, @DepartmentID, @Address1, @Address2, @City, @Province, @Zipcode, @Country", employee);
            }
        }

        public List<EmployeeDetails> getEmployeeInformation()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<EmployeeDetails>($"SELECT * FROM dbo.V_EmployeeInformation");

                return (List<EmployeeDetails>)output;
            }
        }

        public List<EmployeeDepartment> findAvailableEmployee(EmployeeDepartment employee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<EmployeeDepartment>($"USP_FindAvailableEmployees @DepartmentID, @Status", employee);

                return (List<EmployeeDepartment>)output;
            }
        }
        #endregion
    }
}
