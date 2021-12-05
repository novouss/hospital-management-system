using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace hospital_management_system.classes
{
    public class dbAccess
    {
        
        public List<Employees> findDepartmentsEmployees(int DepartmentsID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Employees>($"dbo.USP_FindDepartmentsEmployees @DepartmentsID = '{ DepartmentsID }'");

                return (List<Employees>)output;
            }       
        }

        #region Get Functions

        /*
        * Get Functions consists of public functions that returns one specific class based on their 'id.'
        * 
        * Region Contents:
        *     GetPatient(int id)               - Returns Patient Information from 'id' parameter.
        *     GetEmployee(int id)              - Returns Employee Information from 'id' parameter.
        *     GetAddresses(int id)             - Returns Addresses Information from 'id' parameter.
        *     GetRoles(int id)                 - Returns Roles Information from 'id' parameter.
        *     GetDepartments(int id)           - Returns Departments Information from 'id' parameter.
        *     GetRegistration(int id)          - Returns Registration Information from 'id' parameter.
        *     GetRooms(int id)                 - Returns Rooms Information from 'id' parameter.
        *     GetLaboratories(int id)          - Returns Laboratories Information from 'id' parameter.
        *     GetReport(int id)                - Returns Laboratories Report Information from 'id' parameter.
        *     GetBillings(int id)              - Returns Billings Information from 'id' parameter.
        *      
        * Special Cases Functions:
        *      GetDepartmentsEmployee(int emp_id, int dep_id)
        *      - Returns a Departments'Employee Details based on 'emp_id' and 'dep_id' parameter.
        *      GetEmployeeLogin(string email, string password)
        *      - Returns Employee Details based on 'email' and 'password'
        */

        public Patients GetPatient(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Patients>($"dbo.USP_FindPatients @PatientID = '{ id }'");

                return (Patients)output;
            }
        }

        public Employees GetEmployee(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Employees>($"dbo.USP_FindEmployees @EmployeeID = '{ id }'");

                return (Employees)output;
            }
        }

        public List<Addresses> GetAddress(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Addresses>($"dbo.USP_GetAddressInformation @AddressID = '{ id }'");

                return (List<Addresses>)output;
            }
        }

        public List<Roles> GetRoles(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Roles>($"dbo.USP_GetRoleInformation @RoleID = '{ id }'");

                return (List<Roles>)output;
            }
        }

        public List<Departments> GetDepartments(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Departments>($"dbo.USP_GetDepartmentInformation @DepartmentID = '{ id }'");

                return (List<Departments>)output;
            }
        }

        public Registrations GetRegistration(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Registrations>($"dbo.USP_FindRegistrations @RegistrationID = '{ id }'");

                return (Registrations)output;
            }
        }

        public Rooms GetRoomss(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Rooms>($"dbo.USP_FindRooms @RoomsID = '{ id }'");

                return (Rooms)output;
            }
        }

        public Laboratories GetLaboratories(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Laboratories>($"dbo.USP_FindLaboratories @LaboratoriesID = '{ id }'");

                return (Laboratories)output;
            }
        }

        public Reports GetReport(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Reports>($"dbo.USP_FindReports @ResultID = '{ id }'");

                return (Reports)output;
            }
        }

        public Billings GetBillings(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Billings>($"dbo.USP_FindBillings @BillingsID = '{ id }'");

                return (Billings)output;
            }
        }

        public Employees GetDepartmentsEmployee(int dep_id, int emp_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Employees>($"dbo.USP_FindEmployeeDepartments @DepartmentsID = '{ dep_id }', @EmployeeID = '{ emp_id }'");

                return (Employees)output;
            }
        }

        public List<Employees> GetEmployeeLogin(string email, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Employees>($"dbo.USP_GetEmployeeLogin @Email = '{ email }', @Password = '{ password }'");

                return (List<Employees>)output;
            }
        }

        #endregion

        #region Get List Functions

        /*
        * Get List Functions consists of public functions that returns a list of one specific class,
        * or depending on the parameters and conditions needed.
        * 
        * Region Contents:
        *      GetListPatients()        - Returns a List of Patient Information.
        *      GetListEmployees()       - Returns a List of Employee Information.
        *      GetListAddresses()       - Returns a List of Address Information.
        *      GetListRoless()          - Returns a List of Role Information.
        *      GetListDepartmentss()    - Returns a List of Department Information.
        *      GetListRegistrations()   - Returns a List of Registration Information.
        *      GetListRooms()           - Returns a List of Room Information.
        *      GetListLaboratories()    - Returns a List of Laboratory Information.
        *      GetListReports()         - Returns a List of Report Information.
        *      GetListBillings()        - Returns a List of Billing Information.
        * 
        *      Special Open Functions:
        *           GetListPatientRegistrations(int id)
        *           - Returns a List of Registrations of a Patient from 'id' parameter.
        *           GetListOpenRooms(int status)
        *           - Returns a List of Open Roomss from 'status' parameter.
        *           GetListOpenLaboratories(int status)
        *           - Returns a List of Open Laboratories from 'status' parameter.
        *           GetListOpenEmployeeDepartments(int dep_id, int status)
        *           - Returns a List of Open Employees from 'dep_id' and 'status' parameter.
        */

        public List<Patients> GetListPatients()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Patients>($"SELECT * FROM dbo.V_Patients");

                return (List<Patients>)output;
            }
        }

        public List<Employees> GetListEmployees()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Employees>($"SELECT * FROM dbo.V_Employees");

                return (List<Employees>)output;
            }
        }

        public List<Addresses> GetListAddresses()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Addresses>($"SELECT * FROM dbo.V_Addresses");

                return (List<Addresses>)output;
            }
        }

        public List<Roles> GetListRoles()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Roles>($"SELECT * FROM dbo.V_Roles");

                return (List<Roles>)output;
            }
        }

        public List<Departments> GetListDepartments()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Departments>($"SELECT * FROM dbo.V_Departments");

                return (List<Departments>)output;
            }
        }

        public List<Registrations> GetListRegistrations()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Registrations>($"SELECT * FROM dbo.V_Registration");

                return (List<Registrations>)output;
            }
        }

        public List<Rooms> GetListRooms()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Rooms>($"SELECT * FROM dbo.V_Rooms");

                return (List<Rooms>)output;
            }
        }

        public List<Laboratories> GetListLaboratories()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Laboratories>($"SELECT * FROM dbo.V_Laboratories");

                return (List<Laboratories>)output;
            }
        }

        public List<Reports> GetListReports()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Reports>($"SELECT * FROM dbo.V_Reports");

                return (List<Reports>)output;
            }
        }

        public List<Billings> GetListBillings()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Billings>($"SELECT * FROM dbo.V_Billings");

                return (List<Billings>)output;
            }
        }

        public List<Registrations> GetListPatientRegistrations(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Registrations>($"dbo.USP_GetPatientRegistration @PatientID = { id }");

                return (List<Registrations>)output;
            }
        }

        public List<Rooms> GetListOpenRooms(int status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Rooms>($"dbo.USP_OpenRoomss @Status = '{ status }'");

                return (List<Rooms>)output;
            }
        }

        public List<Laboratories> GetListOpenLaboratories(int status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Laboratories>($"dbo.USP_OpenLaboratories @Status = '{ status }'");

                return (List<Laboratories>)output;
            }
        }

        public List<Employees> GetListOpenDepartmentsEmployee(int dep_id, int status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Employees>($"dbo.USP_OpenDepartmentsEmployee @DepartmentsID = '{dep_id}',@Status = '{ status }'");

                return (List<Employees>)output;
            }
        }

        #endregion

        #region Patient Functions

        /*
         * Patient Functions consist of public functions that executes user stored procedures from the database.
         * 
         * Region Contents:
         *      AddPatient(Patient patient, Addresses address)        
         *      - Adds a patient record and address to the database.
         *      EditPatient(Patient patient)
         *      - Updates patient and address details.
         *      RemovePatient(Patient patient)
         *      - Removes patient and assigned address from database.
         * 
         */

        public void AddPatient(Patients patient, Addresses address)
        {
            
            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new {
                    FirstName = patient.FirstName,
                    MiddleName = patient.MiddleName,
                    LastName = patient.LastName,
                    Birthdate = patient.Birthdate,
                    Gender = patient.Gender,
                    Religion = patient.Religion,
                    Email = patient.Email,
                    PhoneNumber = patient.PhoneNumber,
                    Address1 = address.Address1,
                    Address2 = address.Address2,
                    City = address.City,
                    Province = address.Province,
                    Zipcode = address.Zipcode,
                    Country = address.Country
                };

                connection.Execute("dbo.USP_CreatePatient @FirstName, @LastName, @MiddleName, @Birthdate, @Gender, @Religion, @Email, @PhoneNumber, @Address1, @Address2, @City, @Province, @Zipcode, @Country", parameters);
            }
        }

        public void EditPatient(Patients patient, Addresses address)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    PatientID = patient.PatientID,
                    FirstName = patient.FirstName,
                    MiddleName = patient.MiddleName,
                    LastName = patient.LastName,
                    Birthdate = patient.Birthdate,
                    Gender = patient.Gender,
                    Religion = patient.Religion,
                    Email = patient.Email,
                    PhoneNumber = patient.PhoneNumber,
                    Address1 = address.Address1,
                    Address2 = address.Address2,
                    City = address.City,
                    Province = address.Province,
                    Zipcode = address.Zipcode,
                    Country = address.Country
                };

                connection.Execute("dbo.USP_UpdatePatient @PatientID, @FirstName, @MiddleName, @LastName, @Birthdate, @Gender, @Religion, @Email, @PhoneNumber, @Address1, @Address2, @City, @Province, @Zipcode, @Country", parameters);
            }
        }

        public void RemovePatient(Patients patient)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    PatientID = patient.PatientID
                };

                connection.Execute("dbo.USP_DropPatient @PatientID", parameters);
            }
        }

        #endregion

        #region Employee Functions

        /*
         * Employee Functions consist of public functions that executes user stored procedures from the database.
         * 
         * Region Contents:
         *      AddEmployee(Employees employee, Addresses address)        
         *      - Adds a employee record and address to the database.
         *      EditEmployee(Employees Employee)
         *      - Updates employee and address details.
         *      RemoveEmployee(Employees Employee)
         *      - Removes employee and assigned address from database.
         * 
         */
        public void AddEmployee(Employees employee, Addresses address)
        {


            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    RoleID = employee.RoleID,
                    DepartmentID = employee.DepartmentID,
                    Password = employee.Password,
                    FirstName = employee.FirstName,
                    MiddleName = employee.MiddleName,
                    LastName = employee.LastName,
                    Birthdate = employee.Birthdate,
                    Gender = employee.Gender,
                    Religion = employee.Religion,
                    Email = employee.Email,
                    PhoneNumber = employee.PhoneNumber,
                    Address1 = address.Address1,
                    Address2 = address.Address2,
                    City = address.City,
                    Province = address.Province,
                    Zipcode = address.Zipcode,
                    Country = address.Country
                };

                connection.Execute("dbo.USP_CreateEmployee @RoleID, @DepartmentID, @Password, @FirstName, @MiddleName, @LastName, @Birthdate, @Gender, @Religion, @Email, @PhoneNumber, @Address1, @Address2, @City, @Province, @Zipcode, @Country", parameters);
            }
        }

        public void EditEmployee(Employees employee, Addresses address)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    EmployeeID = employee.EmployeeID,
                    RoleID = employee.RoleID,
                    DepartmentID = employee.DepartmentID,
                    Status = employee.Status,
                    Password = employee.Password,
                    FirstName = employee.FirstName,
                    MiddleName = employee.MiddleName,
                    LastName = employee.LastName,
                    Birthdate = employee.Birthdate,
                    Gender = employee.Gender,
                    Religion = employee.Religion,
                    Email = employee.Email,
                    PhoneNumber = employee.PhoneNumber,
                    Address1 = address.Address1,
                    Address2 = address.Address2,
                    City = address.City,
                    Province = address.Province,
                    Zipcode = address.Zipcode,
                    Country = address.Country
                };

                connection.Execute("dbo.USP_UpdateEmployee @EmployeeID, @RoleID, @DepartmentID, @Status, @Password, @FirstName, @MiddleName, @LastName, @Birthdate, @Gender, @Religion, @Email, @PhoneNumber, @Address1, @Address2, @City, @Province, @Zipcode, @Country", parameters);
            }
        }

        public void RemoveEmployee(Employees employee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    EmployeeID = employee.EmployeeID
                };

                connection.Execute("dbo.USP_DropEmployee @EmployeeID", parameters);
            }
        }


        #endregion


    }
}
