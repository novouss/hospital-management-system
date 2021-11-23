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
        *     GetPatient(int id)                - Returns Patient Information from 'id' parameter.
        *     GetEmployee(int id)              - Returns Employee Information from 'id' parameter.
        *     GetAddresses(int id)               - Returns Addresses Information from 'id' parameter.
        *     GetRoles(int id)                  - Returns Roles Information from 'id' parameter.
        *     GetDepartments(int id)            - Returns Departments Information from 'id' parameter.
        *     GetRegistration(int id)          - Returns Registration Information from 'id' parameter.
        *     GetRooms(int id)                  - Returns Rooms Information from 'id' parameter.
        *     GetLaboratories(int id)            - Returns Laboratories Information from 'id' parameter.
        *     GetReport(int id)                - Returns Laboratories Report Information from 'id' parameter.
        *     GetBillings(int id)               - Returns Billings Information from 'id' parameter.
        *      
        * Special Cases Functions:
        *      GetDepartmentsEmployee(int emp_id, int dep_id)
        *      - Returns a Departments's Employee Details based on 'emp_id' and 'dep_id' parameter.
        *      GetEmployeeLogin(string email, string password)
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

        public Addresses GetAddress(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Addresses>($"dbo.USP_FindAddresses @AddressID = '{ id }'");

                return (Addresses)output;
            }
        }

        public Roles GetRoles(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Roles>($"dbo.USP_FindRole @RoleID = '{ id }'");

                return (Roles)output;
            }
        }

        public Departments GetDepartmentss(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Departments>($"dbo.USP_FindDepartment @DepartmentID = '{ id }'");

                return (Departments)output;
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

        public Employees GetEmployeeLogin(string email, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Employees>($"dbo.USP_GetEmployeeLogin @Email = '{ email }', @Password = '{ password }'");

                return (Employees)output;
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
                var output = connection.Query<Patients>($"dbo.V_Patients");

                return (List<Patients>)output;
            }
        }

        public List<Employees> GetListEmployees()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Employees>($"dbo.V_Employees");

                return (List<Employees>)output;
            }
        }

        public List<Addresses> GetListAddresses()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Addresses>($"dbo.V_Addresses");

                return (List<Addresses>)output;
            }
        }

        public List<Roles> GetListRoles()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Roles>($"dbo.V_Roles");

                return (List<Roles>)output;
            }
        }

        public List<Departments> GetListDepartments()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Departments>($"dbo.V_Departments");

                return (List<Departments>)output;
            }
        }

        public List<Registrations> GetListRegistrations()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Registrations>($"dbo.V_Registrations");

                return (List<Registrations>)output;
            }
        }

        public List<Rooms> GetListRooms()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Rooms>($"dbo.V_Rooms");

                return (List<Rooms>)output;
            }
        }

        public List<Laboratories> GetListLaboratories()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Laboratories>($"dbo.V_Laboratories");

                return (List<Laboratories>)output;
            }
        }

        public List<Reports> GetListReports()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Reports>($"dbo.V_Reports");

                return (List<Reports>)output;
            }
        }

        public List<Billings> GetListBillings()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Billings>($"dbo.V_Billings");

                return (List<Billings>)output;
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
                var output = connection.Query<Employees>($"dbo.USP_OpenDepartmentsEmployee @DepartmentsID = '{dep_id}',@Status = { status }");

                return (List<Employees>)output;
            }
        }

        #endregion

        #region Appointment Functions
        public void addAppointment(Registrations registration)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                // At exactly 4:45 am 10th of November 2021, Raymond Brian D. Gorospe (@Novous) has finally fixed a bug on this exact line that's been causing 3 hours of back pain, stress, anger, anxiety, and loss of hope, to finally fix a bug caused by a misspelling error. 
                // The Adminssion Incident of November 10 2021, AdmissionOn was spelled AdminssionOn.
                connection.Execute($"dbo.USP_AddRegistration @PatientID, @AdmissionOn, @DischargeOn, @EmployeeID, @RoomsID, @LaboratoriesID, @Results", registration);
            }
        }

        public List<Registrations> getRegistrationInformation()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Registrations>($"SELECT * FROM dbo.V_RegisterInformation");

                return (List<Registrations>)output;
            }
        }

        #endregion

        #region Roless Functions

        public List<Roles> getRoless()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Roles>($"SELECT * FROM dbo.V_RolesInformation");

                return (List<Roles>)output;
            }
        }

        public List<Roles> findRoles(int Roles_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Roles>($"dbo.USP_FindRoles @RolesID = '{ Roles_id }'");

                return (List<Roles>)output;
            }
        }

        #endregion

        #region Departments Functions
        public List<Departments> getDepartmentss()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Departments>($"SELECT * FROM dbo.V_DepartmentsInformation");

                return (List<Departments>)output;
            }
        }
        
        public List<Departments> findDepartments(int Departments_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Departments>($"dbo.USP_FindDepartments @DepartmentsID = '{ Departments_id }'");

                return (List<Departments>)output;
            }
        }

        #endregion

        #region Rooms Function
        public List<Rooms> getRoomsInformation()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Rooms>($"SELECT * FROM dbo.V_RoomsInformation");

                return (List<Rooms>)output;
            }
        }

        public List<Rooms> getAvailableRoomss(int status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Rooms>($"dbo.USP_FindAvailableLaboratories @Status = '{ status }'");

                return (List<Rooms>)output;
            }
        }

        #endregion

        #region Laboratories Functions

        public List<Laboratories> getLaboratoriesInformation()
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Laboratories>($"SELECT * FROM dbo.V_LaboratoriesInformation");

                return (List<Laboratories>)output;
            }
        }

        public List<Laboratories> getAvailableLaboratories(int status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Laboratories>($"USP_FindAvailableLaboratories @Status = '{ status }'");

                return (List<Laboratories>)output;
            }
        }
        #endregion

        #region Patient Functions

        public void addPatient(Patients patient)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                connection.Execute("dbo.USP_AddPatient @FirstName, @LastName, @MiddleName, @Birthdate, @Gender, @Religion, @Email, @PhoneNumber, @Addresses1, @Addresses2, @City, @Province, @Zipcode, @Country", patient);
            }
        }

        public void modifyPatient(Patients patient)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                connection.Execute("dbo.USP_ModifyPatient @PatientID, @FirstName, @LastName, @MiddleName, @Birthdate, @Gender, @Religion, @Email, @PhoneNumber, @Addresses1, @Addresses2, @City, @Province, @Zipcode, @Country", patient);
            }
        }

        public List<Patients> getPatientInformation()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Patients>($"SELECT * FROM dbo.V_PatientInformation");

                return (List<Patients>)output;
            }
        }
        #endregion

        #region Employee Functions
        
        public void addEmployee(Employees employee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                connection.Execute("dbo.USP_AddEmployee @FirstName, @LastName, @MiddleName, @Birthdate, @Gender, @Religion, @Email, @PhoneNumber, @Password, @RolesID, @DepartmentsID, @Addresses1, @Addresses2, @City, @Province, @Zipcode, @Country", employee);
            }
        }

        public void modifyEmployee(Employees employee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                connection.Execute("dbo.USP_ModifyEmployee @EmployeeID, @FirstName, @LastName, @MiddleName, @Birthdate, @Gender, @Religion, @Email, @PhoneNumber, @Password, @RolesID, @DepartmentsID, @Addresses1, @Addresses2, @City, @Province, @Zipcode, @Country", employee);
            }
        }

        public List<Employees> getEmployeeInformation()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Employees>($"SELECT * FROM dbo.V_EmployeeInformation");

                return (List<Employees>)output;
            }
        }

        public List<Employees> findAvailableEmployee(Employees employee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Employees>($"USP_FindAvailableEmployees @DepartmentsID, @Status", employee);

                return (List<Employees>)output;
            }
        }
        #endregion


    }
}
